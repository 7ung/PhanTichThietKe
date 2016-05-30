
-- Hồ Hoàng Tùng

GO

alter TRIGGER [dbo].[Trigger_BILL_PaidMoney]
    ON [dbo].[BILL]
    FOR INSERT, UPDATE
    AS
	declare @sum_paidmoney float, @debt_id int, @debt float
    BEGIN
		if (UPDATE(PaidMoney) or Update(Debt_id))
		begin
			select @debt_id = Debt_id from inserted;
			select @sum_paidmoney = SUM(PaidMoney) 
				from BILL group by Debt_id
				having (Debt_id = @debt_id)
			select @debt = DebtMoney from DEBT where DEBT.Id = @debt_id

			if (@sum_paidmoney > @debt)
			begin
				raiserror('R1', 16,1)
				rollback tran
			end
		end
        SET NoCount ON
    END


Go

alter trigger trigger_DEBT_DebtMoney
on DEBT
for update
as
declare @debt float, @id int, @sumdebt float
begin
	if (UPDATE(DebtMoney) )
	begin
		select @debt = DebtMoney, @id = Id from inserted
		select @sumdebt = SUM(PaidMoney) from BILL
			where (BILL.Debt_id = @id)
		if (@sumdebt > @debt)
		begin
			raiserror('R1', 16,1)
			rollback tran
		end
		--else 
		--begin
		--	if (@sumdebt = @debt)
		--	begin
		--		update DEBT set [Status] = 'finish'
		--			where DEBT.Id = @id
		--	end
		--	else
		--	begin
		--	end
		--end
	end
	set nocount on
end

Go
create trigger trigger_CUSTOMERBILL_ReceiveMoney_ChangeMoney
on CUSTOMER_BILL
for insert, update
as
declare @receivemoney float, @changemoney float, @id int
begin
	if (UPDATE(ReceiveMoney) or UPDATE(ChangeMoney))
	begin	
		select @receivemoney = ReceiveMoney, @changemoney = ChangeMoney, @id = Id from inserted
		update BILL set PaidMoney = (@receivemoney - @changemoney)
			where (BILL.Id = @id)
		Print 'R2'
	end
	set nocount on
end

go
alter trigger trigger_BILL_CUSTOMERBILL_PaidMoney
on BILL
for update
as
declare @id int, @paidmoney float, @receivemoney float, @changemoney float, @document varchar(32)
begin
	if (UPDATE(PaidMoney))
	begin
		select @id = Id, @paidmoney = PaidMoney from inserted
		select @document = DOCUMENT.[Type] from DOCUMENT
			where DOCUMENT.Id = @id 
		if (@document = 'customerbill')
		begin
			select @receivemoney = ReceiveMoney, @changemoney = ChangeMoney from CUSTOMER_BILL
				where (CUSTOMER_BILL.Id = @id)
			if (@paidmoney != @receivemoney - @changemoney)
			begin
				raiserror('R2', 16, 1)
				rollback tran
			end
		end
	end
	set nocount on
end


Go
create trigger trigger_DEBT_DebtMoney_Paid
on DEBT
for insert, update
as
declare @debt float, @paid float, @id int
begin
	if(UPDATE(DebtMoney) or UPDATE(Paid))
	begin
		select @debt = DebtMoney, @paid = Paid, @id = Id from inserted
		update DEBT set Remain = (@debt - @paid)
			where (DEBT.Id = @id)
		Print 'R3'
	end
	set nocount on
end

go
create trigger trigger_DEBT_Remain
on DEBT
for update
as
declare @id int, @debt float, @remain float, @paid float
begin
	if (UPDATE(Remain))
	begin
		select @id = Id, @debt = DebtMoney, @remain = Remain, @paid = Paid from inserted
		if (@remain != @debt - @paid)
		begin
			raiserror('R3', 16, 1)
			rollback tran
		end
	end
	set nocount on
end

go
alter trigger trigger_OrderDetail_Result
on ORDER_DETAIL
for insert, update
as
declare @id int, @result float
begin
	if (update(Quantity) or UPDATE(Price))
	begin
		select @result from inserted
		if (@result is null)
		begin
			select @id = Id, @result = Price * Quantity from inserted
			update ORDER_DETAIL
			set Result = @result
			where Id = @id
		end
	end
set nocount on
end

Go
alter trigger trigger_DEBT_Extra
on DEBT
for insert, update
as
declare @status varchar(16), @debt float, @id int
begin
	if (Update([Status]))
	begin
		select @status = [Status], @id = Id from inserted
		if (@status = 'expire')
		begin
			update DEBT set ExtraPaid = @debt *
				CAST((select Value from CONSTANT where Name = ('expired_paid')) as float) 
				where (DEBT.Id = @id) 
		end 
		else
		begin
			if (@status != 'finish')
			begin
			update DEBT set ExtraPaid = 0
				where (DEBT.Id = @id) 
			end
		end
		PRINT 'R5'
	end
	set nocount on
end

-- nếu update số tiền nợ 
--	-- nếu status là expire thì cập nhật số tiền phạt = 15% * số tiền nợ
--	-- nếu status khác expire thì cập nhật số tiền nợ = 0
go 
alter trigger trigger_DEBT_Extra_DebtMoney
on DEBT
for update
as
declare @status varchar(16), @debt float, @id int
begin 
	if (update(DebtMoney))
	begin
		select @debt = DebtMoney, @id = Id, @status = [Status] from inserted
		if (@status = 'expire')
		begin
			update Debt set ExtraPaid = @debt * 
				CAST((select Value from CONSTANT where Name = ('expired_paid')) as float) 
				where (DEBT.Id = @id) 
		end
		else
		begin
			if (@status != 'finish')
			begin
			update Debt set ExtraPaid = 0
				where (DEBT.Id = @id)
			end
		end
	end
	set nocount on
end


-- nếu cập nhật ExtraPaid
--	-- nếu status = expire thì số nhập vào phải bằng 15% * DebtMoney
--	-- nếu status != expire thì số nhập vào phải bằng 0
--	--	trường hợp khác raiserror
go
alter trigger trigger_DEBT_Extra_Status
on DEBT
for update
as
declare @extrapaid float, @status varchar(16), @id int,  @debt float
begin
	if (update(ExtraPaid))
	begin
		select @id = Id, @status = [Status], @extrapaid = ExtraPaid, @debt = DebtMoney from inserted
		if (@status = 'expire')
		begin
			declare @calculate_extrapaid float
			select @calculate_extrapaid =  @debt * 
				CAST((select Value from CONSTANT where Name = ('expired_paid')) as float) 

			if (@extrapaid != @calculate_extrapaid)
			begin
				rollback tran
				raiserror('R5', 16, 1)
			end
		end
		else
		begin
			if (@extrapaid != 0)
			begin
				rollback tran
				raiserror('R5', 16, 1)
			end
		end
		print 'R5'
	end
	set nocount on
end

Go
alter trigger trigger_DEBT_Income_Outcome
on DEBT
for insert, update
as
declare @debt float, @extra float, @id int, @document varchar(32)
begin
	if (UPDATE(DebtMoney) or UPDATE(ExtraPaid))
	begin
	Print 'R6'
		select @debt = DebtMoney, @extra = ExtraPaid, @id = Id from inserted
		select @document = [Type] 
			from (DOCUMENT join inserted on (DOCUMENT.Id = @id))
		
		if (@document = 'customerdebt')
		begin 
			update CUSTOMER_DEBT set InCome = (@debt + @extra)
			where (CUSTOMER_DEBT.Id = @id)
		end
		
		if (@document = 'vendordebt')
		begin 
			update VENDOR_DEBT set OutCome = (@debt + @extra)
			where (VENDOR_DEBT.Id = @id)
		end	
	end

	set nocount on
end

go
alter trigger  trigger_CUSTOMERDEBT_InCome
on CUSTOMER_DEBT
for insert, update
as
declare @income float, @id int
begin
	if (update(InCome))
	begin
		select @id = Id, @income = InCome from inserted
		declare @check float
		select @check = (DebtMoney + ExtraPaid) from DEBT
			where (DEBT.Id = @id)
		if (@income != @check)
		begin
			rollback tran
			raiserror('R6', 16, 1)
		end
		print 'R6'
	end
	set nocount on
end

go
create trigger trigger_VENDORDEBT_OutCome
on VENDOR_DEBT
for insert, update
as
declare @outcome float, @id int
begin
	if (update(OutCome))
	begin
		select @outcome = OutCome, @id = Id from inserted
		declare @check float
		select @check = (DebtMoney + ExtraPaid) from DEBT
			where (DEBT.Id = @id)
		if (@outcome != @check)
		begin
			rollback tran
			raiserror('R6', 16, 1)
		end
		print 'R6'
	end
	set nocount on
end


-- Nếu cập nhật totalprice thì cập nhật lại VAT
Go
alter trigger trigger_ORDER_VAT
on [ORDER]
for insert, update
as
declare @total float, @id int
begin
	if (UPDATE(TotalPrice))
	begin
		select @total = TotalPrice, @id = Id from inserted
		declare @vat float
		select @vat =  @total *
			CAST((select Value from CONSTANT where Name = ('VAT_rate')) as float) 
		update [ORDER] set VAT = @vat
			where (Id = @id)
		Print 'R7'
	end
	set nocount on
end

-- Nếu cập nhật VAT thì kiểm tra xem có đúng bằng tỉ lệ VAT * TotalPrice
go
create trigger trigger_ORDER_VAT_TotalPrice
on [ORDER]
for insert, update
as
declare @vat float, @totalprice float, @id int
begin
	if (UPDATE(VAT))
	begin
		select @vat = VAT, @totalprice = TotalPrice, @id = Id from inserted
		declare @check float
		select @check = @totalprice *
			CAST((select Value from CONSTANT where Name = ('VAT_rate')) as float) 
		if (@vat != @check)
		begin
			rollback tran
			raiserror('R7', 16, 1)
		end
		print 'R7'
	end
	set nocount on
end

Go
alter trigger trigger_ORDER_FinalPrice
on [ORDER]
for update
as
declare @finalprice float, @id int, @document varchar(32)
begin

	if (update(FinalPrice))
	begin
		select @finalprice = FinalPrice, @id = Id from inserted
		select @document = [Type] from DOCUMENT	
			where DOCUMENT.Id = @id
		if (@document = 'customerorder')
		begin
			update DEBT set DebtMoney = @finalprice
			where DEBT.Id = 
				(select Id from CUSTOMER_DEBT
				where CUSTOMER_DEBT.PurchaseOrder_id = @id)
		-- PurchaseOrder_id là unique
		end
		
		if (@document = 'vendororder')
		begin
			update DEBT set DebtMoney = @finalprice
			where DEBT.Id =
				(select Id from VENDOR_DEBT
				where VENDOR_DEBT.VendorOrder_id = @id)
		end

		Print 'R8'
	end
	set nocount on

end

go
alter trigger trigger_DEBT_DebtMoney_FinalPrice
on DEBT
for insert, update
as
declare @debt float, @id int, @document varchar(32)
begin
	if (UPDATE(DebtMoney))
	begin
		select @debt = DebtMoney, @id = Id from inserted
		select @document = [Type] from DOCUMENT
			where DOCUMENT.Id = @id
		
		declare @check float
		if (@document = 'customerdebt')
		begin
			select @check = [ORDER].FinalPrice
				from CUSTOMER_DEBT, [ORDER]
				where CUSTOMER_DEBT.PurchaseOrder_id = [ORDER].Id and CUSTOMER_DEBT.Id = @id
			if (@check != @debt)
			begin
				rollback tran
				raiserror('R8', 16, 1)
			end
		end
		if (@document = 'vendordent')
		begin
			select @check = [ORDER].FinalPrice
				from VENDOR_DEBT, [ORDER]
				where  VENDOR_DEBT.VendorOrder_id = [ORDER].Id and VENDOR_DEBT.Id = @id
			if (@check != @debt)
			begin
				rollback tran
				raiserror('R8', 16, 1)
			end
		end
		print 'R8'
	end
	set nocount on
end



go
alter trigger trigger_ORDERDETAIL_Result_ORDER_TotaPrice
on [ORDER_DETAIL]
for insert, update
as
declare @result float, @id int, @orderid int, @sum float
begin
	if (UPDATE(Result))
	begin
		select @id = Id, @orderid = Order_id from inserted
		select @sum = (select SUM(Result) from ORDER_DETAIL 
				group by ORDER_DETAIL.Order_id
				having ORDER_DETAIL.Order_id = @orderid)
		update [ORDER] set TotalPrice = @sum
			where [ORDER].Id = @orderid
	end
	set nocount on
end

go
alter trigger trigger_ORDER_TotalPrice_Result
on [ORDER]
for insert, update
as
declare @totalprice float, @id int, @sum float
begin
	if (UPDATE(TotalPrice))
	begin
		select @totalprice = TotalPrice, @id = Id from inserted
		select @sum = Sum(Result) from ORDER_DETAIL
			group by ORDER_DETAIL.Order_id
			having ORDER_DETAIL.Order_id = @id
		if (@sum != @totalprice)
		begin
			raiserror('R10', 16, 1)
			rollback tran
		end
		print 'R10'
	end
	set nocount on
end

go
alter trigger trigger_ORDERDETAIL_Result_ORDER_TotaPrice_Delete
on [ORDER_DETAIL]
for delete
as
declare @result float, @id int, @orderid int, @sum float
begin
	select @id = Id, @orderid = Order_id from deleted
	select @sum = (select SUM(Result) from ORDER_DETAIL 
			group by ORDER_DETAIL.Order_id
			having ORDER_DETAIL.Order_id = @orderid)
	if (@sum is null)
		select @sum = 0
	update [ORDER] set TotalPrice = @sum
	where [ORDER].Id = @orderid		

	set nocount on
end




go
alter trigger trigger_PURSCHAEORDER_Discount
on PURCHASE_ORDER
for insert, update
as
declare @discount float, @id int, @totalprice float
begin 
	select @discount = Discount, @id = id from inserted
	select @totalprice = TotalPrice from [ORDER]
		where [ORDER].Id = @id
	if (@discount > @totalprice)
	begin
		raiserror('R11:', 16, 1)
		rollback tran
	end
	set nocount on
end

go
alter trigger trigger_ORDER_TotalPrice_Discount
on [ORDER]
for update
as
declare @discount float, @totalprice float, @id int, @docuemnt varchar(32)
begin
	if (UPDATE(TotalPrice))
	begin
		select @id = Id from inserted
		select @docuemnt = [Type] from DOCUMENT
			where (Id = @id)
		if (@docuemnt = 'customerorder')
		begin
			select @totalprice = TotalPrice from inserted
			select @discount = Discount from PURCHASE_ORDER
				where (PURCHASE_ORDER.Id = @id)
			if (@discount > @totalprice)
			begin
				raiserror('R11: discount phai nho hon totalprice', 16, 1)
				rollback tran
			end
		end
	end
	set nocount on
end

go
alter trigger trigger_PURCHASEORDER_IsMultiPaid
on PURCHASE_ORDER
for insert
as
declare @id int, @totalprice float
begin
	select @id = Id from inserted
	select @totalprice = TotalPrice from [ORDER]
		where ([ORDER].Id = @id)

	if (@totalprice >= 
		CAST((select Value from CONSTANT where Name = ('price_multi_paid')) as float))
	begin
		update PURCHASE_ORDER set IsMultiPaid = 1
			where PURCHASE_ORDER.Id = @id
	end
	else
	begin
		update PURCHASE_ORDER set IsMultiPaid = 0
			where PURCHASE_ORDER.Id = @id
	end
	set nocount on
end

go
alter trigger trigger_ORDER_TotalPrice
on [ORDER]
for update
as
declare @id int, @totalprice float, @ismultipaid bit, @docuement varchar(32), @price_multipaid float
begin
	if (UPDATE(TotalPrice))
	begin
		select @id = Id from inserted
		select @docuement = [Type] from DOCUMENT
			where DOCUMENT.Id = @id
		if (@docuement = 'customerorder')
		begin
			select @totalprice = TotalPrice from inserted
			select @ismultipaid = IsMultiPaid from PURCHASE_ORDER
				where PURCHASE_ORDER.Id = @id
			select @price_multipaid = 
				CAST((select Value from CONSTANT where Name = ('price_multi_paid')) as float)
			if ((@ismultipaid = 1 and @totalprice < @price_multipaid)
				or (@ismultipaid = 0 and @totalprice >= @price_multipaid))
			begin
				raiserror('R12:', 16, 1)
				rollback tran
			end
		end
	end
	set nocount on
end

go
alter trigger trigger_PURCHASEORDER_FinalPrice
on PURCHASE_ORDER
for insert, update
as
declare @discount float, @extrapaid float, @id int, @vat float, @totalprice float, @finalprice float
begin

	select @discount = Discount, @extrapaid = ExtraPaid, @id = Id from inserted
	if (@discount is null)
		select @discount = 0
	if (@extrapaid is null)
		select @extrapaid = 0
	select @vat = VAT, @totalprice = TotalPrice from [ORDER]

	select @finalprice = @totalprice + @vat + @extrapaid - @discount

	update [ORDER] set FinalPrice = @finalprice
		where ([ORDER].Id = @id)
	set nocount on
end

go
alter trigger trigger_ORDER_PURCHASEORDER_TotalPrice_Vat
on [ORDER]
for update
as
declare @discount float, @extrapaid float, @id int, @vat float, @totalprice float, @finalprice float,
	@document varchar(32)
begin
	if (UPDATE(VAT))
	begin
		select @id = Id from inserted
		select @document = [Type] from DOCUMENT
			where (DOCUMENT.Id = @id)
		if (@document = 'customerorder')
		begin
			select @totalprice = TotalPrice, @vat = VAT from inserted
			select @discount = Discount, @extrapaid = ExtraPaid from PURCHASE_ORDER
				where PURCHASE_ORDER.Id = @id
			if (@discount is null)
				select @discount = 0
			if (@extrapaid is null)
				select @extrapaid = 0
			select @finalprice = @totalprice + @vat + @extrapaid - @discount
			
			update [ORDER] set FinalPrice = @finalprice
				where ([ORDER].Id = @id)
		end
		if (@document = 'vendororder')
		begin
			select @totalprice = TotalPrice, @vat = VAT from inserted
			select @finalprice = @totalprice + @vat 
			
			update [ORDER] set FinalPrice = @finalprice
				where ([ORDER].Id = @id)
		end
	end
	set nocount on
end

go
alter trigger trigger_ORDER_PURCHASEORDER_FinalPrice
on [ORDER]
for update
as
declare @discount float, @extrapaid float, @id int, @vat float, @totalprice float, @finalprice float,
	@candfinalprice float, @document varchar(32)
begin
	if (UPDATE(FinalPrice))
	begin
		select @id = Id from inserted
		select @document = [Type] from DOCUMENT
			where (DOCUMENT.Id = @id)
		if (@document = 'customerorder')
		begin
			select @totalprice = TotalPrice, @vat = VAT from inserted
			select @discount = Discount, @extrapaid = ExtraPaid from PURCHASE_ORDER
				where PURCHASE_ORDER.Id = @id
			if (@extrapaid is null)
				select @extrapaid = 0
			if (@discount is null)
				select @discount = 0
			select @finalprice = @totalprice + @vat + @extrapaid - @discount
			
			select @candfinalprice = FinalPrice from inserted
			if (@finalprice != @candfinalprice)
			begin
				raiserror('R13', 16, 1)
				rollback tran
			end
		end
	end
	set nocount on
end

go
alter trigger trgger_GROUPofCUSTOMER_Discount
on GroupofCustomer
for Update
as
declare @id int, @discount float
begin
	if (UPDATE(Discount))
	begin
		select @id = Id, @discount = Discount from inserted
		declare @customers table (id int)
		insert into @customers(id)
			(select Id from CUSTOMER
			where Group_id = @id)
		
		declare @countcustomer int, @customerid int
		select @countcustomer = COUNT(*) from @customers
		
		declare @purchaseorders table(id int)
		declare @orderid int, @totalprice float
		declare @purchaseorderId int, @countpurchaseorder int

		while(@countcustomer > 0)
		begin
			select top 1 @customerid = id from @customers
			
			insert into @purchaseorders(id)
				(select Id from PURCHASE_ORDER
				where PURCHASE_ORDER.Customer_id = @customerid)

			select @countpurchaseorder = Count(*) from @purchaseorders
			while (@countpurchaseorder > 0)
			begin
				
				select @purchaseorderId = id from @purchaseorders
				
				select @totalprice = TotalPrice from [ORDER]
					where [ORDER].Id = @purchaseorderId

				update PURCHASE_ORDER set Discount = @totalprice * @discount
					where PURCHASE_ORDER.Id = @id
				
				delete top(1) from @purchaseorders
				select @countpurchaseorder = COUNT(*) from @purchaseorders
			end

			delete top(1) from @customers
			select @countcustomer = COUNT(*) from @customers
		end
			
	end
	set nocount on
end

go
alter trigger trigger_PURCHASEORDER_Discount_GroupofCustomer
on PURCHASE_ORDER
for insert, update
as
declare @id int, @orderdiscount float, @customerid int,
	@groupcustomerid int, @discountrate float,
	@totalprice float
begin
	if (UPDATE(Discount))
	begin
		select @id = Id, @orderdiscount = Discount, @customerid = Id from inserted
		select @groupcustomerid = Group_id from CUSTOMER
			where CUSTOMER.Id = @customerid
		select @discountrate = Discount from GROUPofCUSTOMER
			where (GROUPofCUSTOMER.Id = @groupcustomerid)

		select @totalprice = TotalPrice from [ORDER]
			where ([ORDER].Id = @id)

		if (@orderdiscount != @totalprice * @discountrate)
		begin
			raiserror('R14: discount wrong',16,1)
			rollback tran
		end
	end
	set nocount on
	-- Lấy totalprice từ order
	-- nhân totalprice với discountrate gán vào canddiscount
	-- so sánh canddiscount và discount
end

go
alter trigger trigger_CUSTOMER_Groupid
on CUSTOMER
for update
as
declare @customerid int, @groupid int, @discountrate float
begin
	if (UPDATE(Group_id))
	begin
		select @customerid = Id, @groupid = Group_id from inserted
		select @discountrate = Discount from GROUPofCUSTOMER
			where GROUPofCUSTOMER.Id = @customerid

		-- danh sách các đơn đặt hàng của customerid
		declare @purchaseorders table(id int)
		insert into @purchaseorders(id)
			select Id from PURCHASE_ORDER
			where PURCHASE_ORDER.Customer_id = @customerid

		-- Lặp mỗi đơn hàng
		declare @orderscount int, @purchaseorderid int,
			@discount float, @totalprice float
		select @orderscount = COUNT(*) from @purchaseorders

		while (@orderscount > 0)
		begin
			select top 1 @purchaseorderid = id from @purchaseorders

			-- Lấy ra totalprice của order theo Id = @purchaseorderid
			-- tính discount = totalprice * discountrate
			-- update ORDER.Discount = discount theo id = purchaseorderid

			select @totalprice = TotalPrice from [ORDER]
				where [ORDER].Id = @purchaseorderid
			select @discount = @totalprice * @discountrate
			update PURCHASE_ORDER set Discount = @discount
				where PURCHASE_ORDER.Id = @purchaseorderid

			delete top(1) from @purchaseorders
			select @orderscount = COUNT(*) from @purchaseorders
		end
	end
	set nocount on
end

go
alter trigger trigger_ORDER_TotalPrice_PURCHASEORDER_Discount
on [ORDER] 
for update
as
declare @id int, @totalprice float, @document varchar(32), @discount float,
	 @discountrate float
begin
	if (UPDATE(TotalPrice))
	begin
		select @id = Id from inserted
		declare @isPurchaseOrder bit
		exec @isPurchaseOrder = dbo.CheckDocumentType @id, 'customerorder'
		if (@isPurchaseOrder = 1)
		begin
			select @totalprice  = TotalPrice from inserted

			select @discountrate = GROUPofCUSTOMER.Discount
				from GROUPofCUSTOMER, CUSTOMER, PURCHASE_ORDER
				where (PURCHASE_ORDER.Id = @id and GROUPofCUSTOMER.Id = CUSTOMER.Group_id
					 and CUSTOMER.Id = PURCHASE_ORDER.Customer_id)

			select @discount = @totalprice * @discountrate
			update PURCHASE_ORDER set Discount = @discount
				where PURCHASE_ORDER.Id = @id
		end
	end
	set nocount on
end

go
alter trigger trigger_VENDORORDER_FinalPrice
on [ORDER]
for insert
as
declare @id int, @totalprice float, @vat float, @finalprice float
begin
	-- for insert nên không cần if UPDATE

	select @id = Id, @totalprice = TotalPrice, @vat = VAT, @finalprice = FinalPrice from inserted
	declare @isvendororder bit
	exec @isvendororder = dbo.CheckDocumentType @id, 'vendororder'
	if (@isvendororder = 1)
	begin
		update [ORDER] set FinalPrice = @totalprice + @vat
		where Id = @id
	end

	set nocount on
end

go
alter trigger trigger_VENDORORDER_update_totalprice_vat
on [ORDER]
for update
as
declare @id int, @totalprice float, @vat float
begin
	if (UPDATE(VAT))
	begin
		select @id = Id from inserted
		declare @isvendororder bit
		exec @isvendororder = dbo.CheckDocumentType @id, 'vendororder'
		if (@isvendororder = 1)
		begin
			select @totalprice = TotalPrice, @vat = VAT from inserted
			update [ORDER] set FinalPrice = @totalprice + @vat
				where Id = @id
		end
	end
	set nocount on
end

go
alter trigger trigger_VENDORORDER_update_finalprice
on [ORDER]
for update
as
declare @id int, @totalprice float, @vat float, @finalprice float
begin
	if (UPDATE(FinalPrice))
	begin
		select @id = Id from inserted
		declare @isvendororder bit
		exec @isvendororder = dbo.CheckDocumentType @id, 'vendororder'
		if (@isvendororder = 1)
		begin
			select @totalprice = TotalPrice, @vat = VAT, @finalprice = FinalPrice from inserted
			if (@finalprice != @totalprice + @vat)
			begin
				raiserror('R15: finalprice wrong', 16,1)
				rollback tran
			end
		end
	end
	set nocount on
end

---- fix
go
alter trigger trigger_Bill_Debt_Paid
on Bill
for insert, update
as
declare @debid int
begin
	if (UPDATE(PaidMoney))
	begin
		select @debid = Debt_id from inserted

		declare @sum float 
		select @sum = Sum(PaidMoney) from BILL
			group by Debt_id
			having Debt_id = @debid

		update DEBT SET Paid = @sum
			where Id = @debid			
	end
	set nocount on
end


go
alter trigger trigger_Bill_Debt_Paid_Delete
on Bill
for delete
as
declare @debid int
begin

	select @debid = Debt_id from deleted

	declare @sum float 
	select @sum = Sum(PaidMoney) from BILL
		group by Debt_id
		having Debt_id = @debid
	if (@sum is null)
		select @sum = 0
	update DEBT 
	SET Paid = @sum
	where Id = @debid			

	set nocount on
end

go
create trigger trigger_Debt_DebtMoney_Paid_Status
on Debt
for insert, update
as
declare @id int, @debtmoney float, @paid float
begin
	if (update(DebtMoney) or UPDATE(Paid))
	begin
		select @id = Id, @debtmoney = DebtMoney, @paid = Paid from inserted
		if (@debtmoney = @paid)
		begin
			update DEBT
			set [Status] = 'finish'
			where Id = @id
		end
		if (@debtmoney > @paid and @paid > 0)
		begin
			update DEBT
			set [Status] = 'apart'
			where Id = @id
		end
		if (@paid = 0)
		begin
			update DEBT
			set [Status] = 'nopaid'
			where Id = @id
		end
	end	
set nocount on
end

go
create trigger trigger_Debt_Status_DebtMoney_Paid
on Debt
for insert, update
as
declare @id int, @debtmoney float, @paid float, @status nvarchar(16)
begin
	if (UPDATE([Status]))
	begin
		select @id = Id, @debtmoney = DebtMoney, @paid = Paid, @status = [Status] from inserted
		if (@status = 'finish' and @debtmoney != @paid)
		begin
			raiserror('Status', 16, 1)
			rollback tran
		end
		if (@status = 'nopaid' and @paid != 0)
		begin
			raiserror('Status', 16, 1)
			rollback tran
		end
		if (@status = 'apart' and (@paid = 0 or @paid = @debtmoney))
		begin
			raiserror('Status', 16, 1)
			rollback tran
		end
	end
set nocount on
end

--------------------------------------------
-- Quản lý nhật xuất kho

-- 1. Nếu loại đơn là nhập kho thì orderi_id phải tham chiếu đến đơn nhập hàng.
-- 2. Nếu loại đơn là xuất kho thì orderi_id phải tham chiếu đến đơn bán hàng.
-- BTAH
--			R16				--		Insert		--		Update		--		Delete
-- InOutInventory			||					||					||	+ (Type)
-- InOutInventtoryDetail	||		+			||		-(*)		||	-

go
create trigger trigger_InOutInventory_Detail
on
INOUT_INVENTORY_DETAIL
for insert
as
declare @order_id int, @inoutinventory_id int
begin
	select @order_id = Order_id, @inoutinventory_id = InOutInventory_id from inserted
	declare @inout_ventory_type bit, @order_type nvarchar(32)
	
	select @inout_ventory_type = [Type]
		from INOUTINVENTORY
		where Id = @inoutinventory_id
	
	select @order_type = [Type]
		from DOCUMENT
		where Id = @order_id

	if (not ((@inout_ventory_type = 1 and @order_type = 'vendororder')
			or (@inout_ventory_type = 0 and @order_type = 'customerorder')))
	begin
		raiserror('R16', 16, 1)
		rollback tran		
	end

end


-- 3. Nếu là đơn nhập kho 
--		thì tổng số lượng nhập trong các đơn nhập hàng (InOutInventory_Detail_ProductQuantity_View) không quá số lượng cho phép của kho
-- BTAH
--			R17				--		Insert		--		Update		--		Delete
--	InOut_Inventory_Detail	||		+			||		-(*)		||		-
--		Order_Detail		||		-			||		+(Quantity)	||		-(*)
--	Inventory_Capability	||		-			||		+(MaxCount)	||		-(*)


go
alter trigger trigger_InOutInventory_Detail_Product_Quantity
on INOUT_INVENTORY_DETAIL
for insert
as
declare  @inoutinventory_id int
begin
	select @inoutinventory_id = InOutInventory_id from inserted
	declare @temp table(inventory int, product int)
	insert into @temp
		select INVENTORY_CAPABILITY.Inventory_id, INVENTORY_CAPABILITY.Product_id
		from INVENTORY_CAPABILITY, INOUTINVENTORY, InOutInventory_Detail_ProductQuantity_View
		where INVENTORY_CAPABILITY.Inventory_id = INOUTINVENTORY.Inventory_id
			and INOUTINVENTORY.Id = InOutInventory_Detail_ProductQuantity_View.InOutInventory_id
			and INOUTINVENTORY.Id = @inoutinventory_id
			and INVENTORY_CAPABILITY.Product_id = InOutInventory_Detail_ProductQuantity_View.Product_id
			and INOUTINVENTORY.[Type] = 1
			and InOutInventory_Detail_ProductQuantity_View.Quantity + INVENTORY_CAPABILITY.CurrentCount > INVENTORY_CAPABILITY.MaxCount
	if ((select COUNT(*) from @temp) > 0)
	begin
		raiserror ('R17', 16, 1)
		rollback tran
	end
end

go
alter trigger trigger_OrderDetail_Quantity
on [ORDER_DETAIL]
for update
as
declare @order_id int, @inoutventory int
begin
	if (UPDATE(Quantity))
	begin
		
		select @order_id = Order_id from inserted
		declare @isPurchaseOrder bit
		exec @isPurchaseOrder = dbo.CheckDocumentType @order_id, 'vendororder'
		if (@isPurchaseOrder = 0)
			return

		select @inoutventory = INOUT_INVENTORY_DETAIL.InOutInventory_id 
			from INOUT_INVENTORY_DETAIL
			where INOUT_INVENTORY_DETAIL.Order_id = @order_id


		if (@inoutventory is not null)
		begin
			declare @temp table(inventory int, product int)
			insert into @temp
			select INVENTORY_CAPABILITY.Inventory_id, INVENTORY_CAPABILITY.Product_id
			from INVENTORY_CAPABILITY, INOUTINVENTORY, InOutInventory_Detail_ProductQuantity_View
			where INVENTORY_CAPABILITY.Inventory_id = INOUTINVENTORY.Inventory_id
				and INOUTINVENTORY.Id = InOutInventory_Detail_ProductQuantity_View.InOutInventory_id
				and INOUTINVENTORY.Id = @inoutventory
				and INVENTORY_CAPABILITY.Product_id = InOutInventory_Detail_ProductQuantity_View.Product_id
				and INOUTINVENTORY.[Type] = 1
				and InOutInventory_Detail_ProductQuantity_View.Quantity + INVENTORY_CAPABILITY.CurrentCount > INVENTORY_CAPABILITY.MaxCount
			if ((select COUNT(*) from @temp ) > 0)
			begin
				raiserror ('R17', 16, 1)
				rollback tran
			end
		end
	end
end

go
alter trigger trigger_Inventory_Capability
on INVENTORY_CAPABILITY
for update
as
declare @productid int, @inventoryid int
begin
	if (Update (MaxCount))
	begin

		declare @inoutinventory table(id int)
		select @productid = Product_id from inserted
		insert into @inoutinventory
		select INOUTINVENTORY.Id
			from InOutInventory_Detail_ProductQuantity_View, INOUTINVENTORY
			where InOutInventory_Detail_ProductQuantity_View.Product_id = @productid
				and InOutInventory_Detail_ProductQuantity_View.InOutInventory_id = INOUTINVENTORY.Id
				and INOUTINVENTORY.Inventory_id = @inventoryid
				and INOUTINVENTORY.[Type] = 1

		declare @count int
		select @count = COUNT(*) from @inoutinventory
		declare @curID int

		while (@count > 0)
		begin
			select top 1 @curID = id from @inoutinventory
			--
			declare @temp table(inventory int, product int)
			insert into @temp
			select INVENTORY_CAPABILITY.Inventory_id, INVENTORY_CAPABILITY.Product_id
			from INVENTORY_CAPABILITY, INOUTINVENTORY, InOutInventory_Detail_ProductQuantity_View
			where INVENTORY_CAPABILITY.Inventory_id = INOUTINVENTORY.Inventory_id
				and INOUTINVENTORY.Id = InOutInventory_Detail_ProductQuantity_View.InOutInventory_id
				and INOUTINVENTORY.Id = @curID
				and INVENTORY_CAPABILITY.Product_id = InOutInventory_Detail_ProductQuantity_View.Product_id
				and INOUTINVENTORY.[Type] = 1
				and InOutInventory_Detail_ProductQuantity_View.Quantity + INVENTORY_CAPABILITY.CurrentCount > INVENTORY_CAPABILITY.MaxCount

			if ((select COUNT(*) from @temp ) > 0)
			begin
				raiserror ('R17', 16, 1)
				rollback tran
			end
				
			--
			delete top (1) from @inoutinventory
			select @count = COUNT(*) from @inoutinventory

		end

	end
end


-- 4. Nếu là đơn xuất kho
--		Thì tổng số lượng xuất kho không được quá số lượng hiện tại của kho
-- -- BTAH
--			R18				--		Insert		--		Update		--		Delete
--	InOut_Inventory_Detail	||		+			||		-(*)		||		-
--		Order_Detail		||		-			||		+(Quantity)	||		-(*)
--	Inventory_Capability	||		-			||		+(MaxCount)	||		-(*)


go
create trigger trigger_InOutInventory_Detail_Product_Quantity_Out
on INOUT_INVENTORY_DETAIL
for insert
as
declare  @inoutinventory_id int
begin
	select @inoutinventory_id = InOutInventory_id from inserted
	declare @temp table(inventory int, product int)
	insert into @temp
		select INVENTORY_CAPABILITY.Inventory_id, INVENTORY_CAPABILITY.Product_id
		from INVENTORY_CAPABILITY, INOUTINVENTORY, InOutInventory_Detail_ProductQuantity_View
		where INVENTORY_CAPABILITY.Inventory_id = INOUTINVENTORY.Inventory_id
			and INOUTINVENTORY.Id = InOutInventory_Detail_ProductQuantity_View.InOutInventory_id
			and INOUTINVENTORY.Id = @inoutinventory_id
			and INVENTORY_CAPABILITY.Product_id = InOutInventory_Detail_ProductQuantity_View.Product_id
			and INOUTINVENTORY.[Type] = 0
			and InOutInventory_Detail_ProductQuantity_View.Quantity > INVENTORY_CAPABILITY.CurrentCount
	if ((select COUNT(*) from @temp) > 0)
	begin
		raiserror ('R18', 16, 1)
		rollback tran
	end
end



go
create trigger trigger_OrderDetail_Quantity_Out
on [ORDER_DETAIL]
for update
as
declare @order_id int, @inoutventory int
begin
	if (UPDATE(Quantity))
	begin
		
		select @order_id = Order_id from inserted
		declare @isPurchaseOrder bit
		exec @isPurchaseOrder = dbo.CheckDocumentType @order_id, 'customerorder'
		if (@isPurchaseOrder = 0)
			return

		select @inoutventory = INOUT_INVENTORY_DETAIL.InOutInventory_id 
			from INOUT_INVENTORY_DETAIL
			where INOUT_INVENTORY_DETAIL.Order_id = @order_id


		if (@inoutventory is not null)
		begin
			declare @temp table(inventory int, product int)
			insert into @temp
			select INVENTORY_CAPABILITY.Inventory_id, INVENTORY_CAPABILITY.Product_id
			from INVENTORY_CAPABILITY, INOUTINVENTORY, InOutInventory_Detail_ProductQuantity_View
			where INVENTORY_CAPABILITY.Inventory_id = INOUTINVENTORY.Inventory_id
				and INOUTINVENTORY.Id = InOutInventory_Detail_ProductQuantity_View.InOutInventory_id
				and INOUTINVENTORY.Id = @inoutventory
				and INVENTORY_CAPABILITY.Product_id = InOutInventory_Detail_ProductQuantity_View.Product_id
				and INOUTINVENTORY.[Type] = 0
				and InOutInventory_Detail_ProductQuantity_View.Quantity > INVENTORY_CAPABILITY.CurrentCount 
			if ((select COUNT(*) from @temp ) > 0)
			begin
				raiserror ('R18', 16, 1)
				rollback tran
			end
		end
	end
end



go
create trigger trigger_Inventory_Capability_Out
on INVENTORY_CAPABILITY
for update
as
declare @productid int, @inventoryid int
begin
	if (Update (CurrentCount))
	begin

		declare @inoutinventory table(id int)
		select @productid = Product_id from inserted
		insert into @inoutinventory
		select INOUTINVENTORY.Id
			from InOutInventory_Detail_ProductQuantity_View, INOUTINVENTORY
			where InOutInventory_Detail_ProductQuantity_View.Product_id = @productid
				and InOutInventory_Detail_ProductQuantity_View.InOutInventory_id = INOUTINVENTORY.Id
				and INOUTINVENTORY.Inventory_id = @inventoryid

		declare @count int
		select @count = COUNT(*) from @inoutinventory
		declare @curID int

		while (@count > 0)
		begin
			select top 1 @curID = id from @inoutinventory
			--
			declare @temp table(inventory int, product int)
			insert into @temp
			select INVENTORY_CAPABILITY.Inventory_id, INVENTORY_CAPABILITY.Product_id
			from INVENTORY_CAPABILITY, INOUTINVENTORY, InOutInventory_Detail_ProductQuantity_View
			where INVENTORY_CAPABILITY.Inventory_id = INOUTINVENTORY.Inventory_id
				and INOUTINVENTORY.Id = InOutInventory_Detail_ProductQuantity_View.InOutInventory_id
				and INOUTINVENTORY.Id = @curID
				and INVENTORY_CAPABILITY.Product_id = InOutInventory_Detail_ProductQuantity_View.Product_id
				and INOUTINVENTORY.[Type] = 0
				and InOutInventory_Detail_ProductQuantity_View.Quantity >  INVENTORY_CAPABILITY.CurrentCount

			if ((select COUNT(*) from @temp ) > 0)
			begin
				raiserror ('R18', 16, 1)
				rollback tran
			end
				
			--
			delete top (1) from @inoutinventory
			select @count = COUNT(*) from @inoutinventory

		end

	end
end