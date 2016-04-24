
-- Hồ Hoàng Tùng

GO

create TRIGGER [dbo].[Trigger_BILL_PaidMoney]
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

			if (@sum_paidmoney > @debt_id)
			begin
				raiserror('R1', 16,1)
				rollback tran
			end
		end
        SET NoCount ON
    END


Go

create trigger trigger_DEBT_DebtMoney
on DEBT
for update
as
declare @debt float, @id int, @sumdebt float
begin
	if (UPDATE(DebtMoney))
	begin
		select @debt = DebtMoney, @id = Id from inserted
		select @sumdebt = SUM(PaidMoney) from BILL
			where (BILL.Debt_id = @id)
		if (@sumdebt > @debt)
		begin
			raiserror('R1', 16,1)
			rollback tran
		end
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
create trigger trigger_BILL_CUSTOMERBILL_PaidMoney
on BILL
for update
as
declare @id int, @paidmoney float, @receivemoney float, @changemoney float, @document varchar(32)
begin
	if (UPDATE(PaidMoney))
	begin
		select @id = Id, @paidmoney = PaidMoney from inserted
		select @document = DOCUMENT.DocumentKey from DOCUMENT
			where DOCUMENT.Id = @id 
		if (@document = 'customerbill')
		begin
			select @receivemoney = ReceiveMoney, @changemoney = ChangeMoney from CUSTOMER_BILL
				where (CUSTOMER_BILL.Id = @id)
			if (@paidmoney != @receivemoney - @changemoney)
			begin
				raiserror('R2', 16, 1)
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

Go
alter trigger trigger_DEBT_Status
on DEBT
for insert, update
as
declare @debt float, @paid float, @id int
begin
	if (UPDATE(DebtMoney) or UPDATE(Paid))
	begin
		select @debt = DebtMoney, @paid = Paid, @id = Id from inserted
		if (@paid = 0)
		begin
			update DEBT set [Status] = 'nopaid'
			where (Id = @id)
		end 
		if (@paid > 0 and @paid < @debt)
		begin
			update DEBT set [Status] = 'apart'
			where (Id = @id)
		end
		if (@paid = @debt)
		begin
			update DEBT set [Status] = 'finish'
			where (Id = @id)
		end
		Print 'R4'
	end
	set nocount on
end

Go
create trigger trigger_DEBT_Extra
on DEBT
for insert, update
as
declare @status varchar(10), @debt float, @id int
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
			update DEBT set ExtraPaid = 0
				where (DEBT.Id = @id) 
		end
		PRINT 'R5'
	end
	set nocount on
end

Go
create trigger trigger_DEBT_Income_Outcome
on DEBT
for insert, update
as
declare @debt float, @extra float, @id int, @document varchar(32)
begin
	select @debt = DebtMoney, @extra = ExtraPaid, @id = Id from inserted
	select @document = DocumentKey 
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
	Print 'R6'
end



Go
create trigger trigger_ORDER_VAT
on [ORDER]
for insert, update
as
declare @total float, @id int
begin
	if (UPDATE(VAT))
	begin
		select @total = TotalPrice, @id = Id from inserted
		update [ORDER] set VAT = @total *
			CAST((select Value from CONSTANT where Name = ('VAT_rate')) as float) 
			where (Id = @id)
		Print 'R7'
	end
end

Go
create trigger trigger_ORDER_FinalPrice
on [ORDER]
for insert, update
as
declare @finalprice float, @id int
begin
	select @finalprice = FinalPrice, @id = Id from inserted
	update DEBT set DebtMoney = @finalprice
		where (DEBT.Id = @id)
	Print 'R8'
end


Go
create trigger trigger_ORDERDETAIL_Result
on [ORDER_DETAIL]
for insert, update
as
declare @quantity int, @price float, @id int
begin
	select @quantity = Quantity, @price = Price, @id = Id from inserted
	update ORDER_DETAIL set Result = @price * @quantity
		where (ORDER_DETAIL.Id = @id)
	Print 'R9'
end

go
create trigger trigger_ORDERDETAIL_Result_ORDER_TotaPrice
on [ORDER_DETAIL]
for insert, update
as
declare @result float, @id int, @orderid int, @sum float
begin
	select @id = Id, @orderid = Order_id from inserted
	select @sum = (select SUM(Result) from ORDER_DETAIL 
			group by ORDER_DETAIL.Order_id
			having ORDER_DETAIL.Order_id = @orderid)
	update [ORDER] set TotalPrice = @sum
		where [ORDER].Id = @orderid
	Print 'R10: id = ' + @id + '\torderid =' + @orderid + '\tsum = ' + @sum + '.'
end

go
create trigger trigger_ORDERDETAIL_Result_ORDER_TotaPrice_Delete
on [ORDER_DETAIL]
for insert, update
as
declare @result float, @id int, @orderid int, @sum float
begin
	select @id = Id, @orderid = Order_id from deleted
	select @sum = (select SUM(Result) from ORDER_DETAIL 
			group by ORDER_DETAIL.Order_id
			having ORDER_DETAIL.Order_id = @orderid)
	update [ORDER] set TotalPrice = @sum
		where [ORDER].Id = @orderid
	Print 'R10: id = ' + @id + '\torderid =' + @orderid + '\tsum = ' + @sum + '.'
end


go
create trigger trigger_PURSCHAEORDER_Discount
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
		raiserror('R11: discount phai nho hon totalprice', 16, 1)
		rollback tran
	end
	Print 'R11: id=' + @id + '\tdiscount=' + @discount + '\ttotalprice=' + @totalprice
end

go
create trigger trigger_ORDER_TotalPrice_Discount
on [ORDER]
for update
as
declare @discount float, @totalprice float, @id int, @docuemnt varchar(32)
begin
	if (UPDATE(TotalPrice))
	begin
		select @id = Id from inserted
		select @docuemnt = DocumentKey from DOCUMENT
			where (Id = @id)
		if (@docuemnt = 'purchaseorder')
		begin
			select @totalprice = TotalPrice from inserted
			select @discount = Discount from PURCHASE_ORDER
				where (PURCHASE_ORDER.Id = @id)
			if (@discount >= @totalprice)
			begin
				raiserror('R11: discount phai nho hon totalprice', 16, 1)
				rollback tran
			end
			Print 'R11: id=' + @id + '\tdiscount=' + @discount + '\ttotalprice=' + @totalprice
		end
	end
end

go
create trigger trigger_PURCHASEORDER_IsMultiPaid
on PURCHASE_ORDER
for insert, update
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
	Print 'R12: id=' + @id + '\ttotalprice=' + @totalprice
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
		select @docuement = DocumentKey from DOCUMENT
			where DOCUMENT.Id = @id
		if (@docuement = 'purchaseorder')
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
			end
		end
		Print 'R12: id=' + @id + '\ttotalprice=' + @totalprice + '\tismultipaid=' + @ismultipaid + '\tpricemultipaid=' + @price_multipaid
	end
end

go
create trigger trigger_PURCHASEORDER_FinalPrice
on PURCHASE_ORDER
for insert, update
as
declare @discount float, @extrapaid float, @id int, @vat float, @totalprice float, @finalprice float
begin

	select @discount = Discount, @extrapaid = ExtraPaid, @id = Id from inserted

	select @vat = VAT, @totalprice = TotalPrice from [ORDER]

	select @finalprice = @totalprice + @vat + @extrapaid - @discount

	update [ORDER] set FinalPrice = @finalprice
		where ([ORDER].Id = @id)

	Print 'R13: id=' + @id + '\tdiscount=' + @discount + '\textrapaid=' + @extrapaid + '\tvat=' + @vat + 
		'\ttotalprice=' + @totalprice + '\tfinalprice' + @finalprice
end

go
create trigger trigger_ORDER_PURCHASEORDER_TotalPrice_Vat
on [ORDER]
for update
as
declare @discount float, @extrapaid float, @id int, @vat float, @totalprice float, @finalprice float,
	@document varchar(32)
begin
	if (UPDATE(TotalPrice) or UPDATE(VAT))
	begin
		select @id = Id from inserted
		select @document = DocumentKey from DOCUMENT
			where (DOCUMENT.Id = @id)
		if (@document = 'purchaseorder')
		begin
			select @totalprice = TotalPrice, @vat = VAT from inserted
			select @discount = Discount, @extrapaid = ExtraPaid from PURCHASE_ORDER
				where PURCHASE_ORDER.Id = @id
			select @finalprice = @totalprice + @vat + @extrapaid - @discount
			
			update [ORDER] set FinalPrice = @finalprice
				where ([ORDER].Id = @id)
		end
		Print 'R13: id=' + @id + '\tdiscount=' + @discount + '\textrapaid=' + @extrapaid + '\tvat=' + @vat + 
			'\ttotalprice=' + @totalprice + '\tfinalprice' + @finalprice
	end
end

go
create trigger trigger_ORDER_PURCHASEORDER_FinalPrice
on [ORDER]
for update
as
declare @discount float, @extrapaid float, @id int, @vat float, @totalprice float, @finalprice float,
	@candfinalprice float, @document varchar(32)
begin
	if (UPDATE(FinalPrice))
	begin
		select @id = Id from inserted
		select @document = DocumentKey from DOCUMENT
			where (DOCUMENT.Id = @id)
		if (@document = 'purchaseorder')
		begin
			select @totalprice = TotalPrice, @vat = VAT from inserted
			select @discount = Discount, @extrapaid = ExtraPaid from PURCHASE_ORDER
				where PURCHASE_ORDER.Id = @id
			select @finalprice = @totalprice + @vat + @extrapaid - @discount
			
			select @candfinalprice = FinalPrice from inserted
			if (@finalprice = @candfinalprice)
			begin
				raiserror('R13', 16, 1)
				rollback tran
			end
		end
		print 'R13:'
	end
end

go
create trigger trgger_GROUPofCUSTOMER_Discount
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
		
		Print 'R14: ' + @countcustomer + ' customers effected'

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
			Print 'R14: ' + @countpurchaseorder + 'purchase order effected'
			while (@countpurchaseorder > 0)
			begin
				
				select @purchaseorderId = id from @purchaseorders
				
				select @totalprice = TotalPrice from [ORDER]
					where [ORDER].Id = @purchaseorderId

				update PURCHASE_ORDER set Discount = @totalprice * @discount
					where PURCHASE_ORDER.Id = @id
				
				Print 'R14: purchaseorder in id = ' + @id + ' has changed' 	

				delete top(1) from @purchaseorders
				select @countpurchaseorder = COUNT(*) from @purchaseorders
			end

			delete top(1) from @customers
			select @countcustomer = COUNT(*) from @customers
		end
			
	end
end

go
create trigger trigger_PURCHASEORDER_Discount_GroupofCustomer
on PURCHASE_ORDER
for insert, update
as
declare @id int, @orderdiscount float, @customerid int,
	@groupcustomerid int, @discountrate float,
	@totalprice float
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
	Print 'R14'
	-- Lấy totalprice từ order
	-- nhân totalprice với discountrate gán vào canddiscount
	-- so sánh canddiscount và discount
end

go
create trigger trigger_CUSTOMER_Groupid
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
		Print 'R14: '+ @orderscount + ' PurchaseOrders effected'
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

			Print 'R14: set PurchaseOrder.Discount = ' + @discount + ' Id = ' + @purchaseorderid

			delete top(1) from @purchaseorders
			select @orderscount = COUNT(*) from @purchaseorders
		end
	end
end

go
create trigger trigger_ORDER_TotalPrice_PURCHASEORDER_Discount
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
		exec @isPurchaseOrder = dbo.CheckDocumentType @id, 'purchasrorder'
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
			PRINT 'R14: update purchaseorder id=' + @id + ' discount=' + @discount
		end
	end
end

go
create trigger trigger_VENDORORDER_FinalPrice
on [ORDER]
for insert
as
declare @id int, @totalprice float, @vat float, @finalprice float
begin
	select @id = Id, @totalprice = TotalPrice, @vat = VAT, @finalprice = FinalPrice from inserted
	declare @isvendororder bit
	exec @isvendororder = dbo.CheckDocumentType @id, 'vendororder'
	if (@isvendororder = 1)
	begin
		update [ORDER] set FinalPrice = @totalprice + @vat
		print 'R15: update vendor order: id=' + @id + ' final price = ' + (@totalprice + @vat)
	end
end

go
create trigger trigger_VENDORORDER_update_totalprice_vat
on [ORDER]
for update
as
declare @id int, @totalprice float, @vat float
begin
	if (UPDATE(TotalPrice) or UPDATE(VAT))
	begin
		select @id = Id from inserted
		declare @isvendororder bit
		exec @isvendororder = dbo.CheckDocumentType @id, 'vendororder'
		if (@isvendororder = 1)
		begin
			select @totalprice = TotalPrice, @vat = VAT from inserted
			update [ORDER] set FinalPrice = @totalprice + @vat
			print 'R15: update vendor order: id=' + @id + ' final price = ' + (@totalprice + @vat)
		end
	end
end

go
create trigger trigger_VENDORORDER_update_finalprice
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
end

go
create trigger trigger_INOUTDETAIL
on INOUT_INVENTORY_DETAIL
for insert, update
as
declare @productid int,
	@orderdetailid int, @orderquantity int, @sumquantity int
begin
	if (UPDATE(Quantity))
	begin
		select @orderdetailid = OrderDetail_id from inserted
		select @productid = Product_id, @orderquantity = Quantity from ORDER_DETAIL
			where ORDER_DETAIL.Id = @orderdetailid
		select @sumquantity = SUM(INOUT_INVENTORY_DETAIL.Quantity) 
			from INOUT_INVENTORY_DETAIL join ORDER_DETAIL on INOUT_INVENTORY_DETAIL.OrderDetail_id = ORDER_DETAIL.Id
			group by OrderDetail_id, ORDER_DETAIL.Product_id
			having INOUT_INVENTORY_DETAIL.OrderDetail_id = @orderdetailid and Product_id = @productid
		if (@sumquantity > @orderquantity)
		begin
			raiserror('R16', 16,1)
			rollback tran
		end
	end
end


go
create trigger trigger_ORDERDETAIL_Quantity
on ORDER_DETAIL
for update
as
declare @orderdetailid int, @orderquantity int, @productid int, @sumquantity int
begin
	if (Update(Quantity))
	begin
		select @orderdetailid = Id, @orderquantity = Quantity, @productid = Product_id from inserted
		select @sumquantity = SUM(INOUT_INVENTORY_DETAIL.Quantity)
			from INOUT_INVENTORY_DETAIL join ORDER_DETAIL on INOUT_INVENTORY_DETAIL.OrderDetail_id = ORDER_DETAIL.Id
			group by OrderDetail_id, ORDER_DETAIL.Product_id
			having INOUT_INVENTORY_DETAIL.OrderDetail_id = @orderdetailid and Product_id = @productid
		if (@sumquantity > @orderquantity)
		begin
			raiserror('R16', 16,1)
			rollback tran
		end
	end
end
