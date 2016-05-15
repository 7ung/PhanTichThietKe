
-- Customer_Bill

alter PROCEDURE [dbo].Insert_Customer_Bill
	@documentkey varchar(32),
	@creator int,
	@createdate smalldatetime,
	@debt_id int,
	@paidmethod nvarchar(32),
	@customer_id int,
	@changemoney float,
	@receivemoney float = 0
AS
begin

	begin tran Insert_Customer_Bill
		insert into DOCUMENT(DocumentKey, [Type], Creator, CreateDate)
		values (@documentkey, 'customerbill', @creator, @createdate)
	
		declare @id int
		select top 1 @id = Id from DOCUMENT
		order by DOCUMENT.Id desc

		insert into BILL
		values (@id, @debt_id, 0, @paidmethod)

		insert into CUSTOMER_BILL
		values (@id, @customer_id, @receivemoney, @changemoney)
	commit tran

RETURN 0
end

go
alter procedure Delete_Customer_Bill
	@id int
as
begin
	begin tran Delete_Customer_Bill
		delete from CUSTOMER_BILL
		where CUSTOMER_BILL.Id = @id

		delete from BILL
		where BILL.Id = @id

		delete from DOCUMENT
		where DOCUMENT.Id = @id
	commit tran
return 0
end

go
alter procedure Delete_Customer_Bill_By_Debt
	@debt_id int
as
begin
	begin tran Delete_Customer_Bill_By_Debt
		declare @ids table(id int)
		insert into @ids(id)
			(select Id from BILL where BILL.Debt_id = @debt_id)

		declare @count int, @curId int
		select @count = COUNT(id) from @ids
		while (@count > 0)
		begin
			select top 1 @curId = id from @ids
			exec Delete_Customer_Bill
				@id = @curId

			delete top(1) from @ids
			select @count = COUNT(id) from @ids
		end
	commit tran
return 0
end

go
alter procedure Delete_Customer_Bill_By_CustomerId
	@customer_id int
as
begin
	begin tran Del_CustomerBill_By_Customer
		declare @ids table(id int)
		insert into @ids(id)
			(select Id from BILL where BILL.Debt_id = @customer_id)

		declare @count int
		select @count = COUNT(id) from @ids

		declare @curId int
		while (@count > 0)
		begin
			select top 1 @curId = id from @ids
				exec Delete_Customer_Bill
					@id = @curId
			delete top(1) from @ids
			select @count = COUNT(id) from @ids
		end

	commit tran
return 0
end

go
alter PROCEDURE [dbo].Update_Customer_Bill
	@id int,
	@documentkey varchar(32),
	@creator int,
	@createdate smalldatetime,
	@paidmethod nvarchar(32),
	@paidmoney float,
	@customer_id float,
	@changemoney float,
	@receivemoney float
AS
begin
	begin tran Update_Customer_Bill
		update CUSTOMER_BILL
		set Customer_id = @customer_id, ReceiveMoney = @receivemoney, ChangeMoney = @changemoney
		where CUSTOMER_BILL.Id = @id

		update BILL
		set PaidMoney = @paidmoney, PaidMethod = @paidmethod
		where BILL.Id = @id

		update DOCUMENT
		set DocumentKey = @documentkey, Creator = @creator, CreateDate = @createdate
		where DOCUMENT.Id = @id
	commit tran
return 0
end

-- Vendor Bill
go
alter procedure Insert_Vendor_Bill
	@documentkey varchar(32),
	@creator int,
	@createdate smalldatetime,
	@debt_id int,
	@paidmethod nvarchar(32),
	@paidmoney float,
	@paidstaff int,
	@vendor_id int
as
begin
	begin tran Insert_Vendor_Bill
	begin try
		insert into DOCUMENT(DocumentKey, [Type], Creator, CreateDate)
		values (@documentkey, 'vendorbill', @creator, @createdate)
	
		declare @id int
		select top 1 @id = Id from DOCUMENT
		order by DOCUMENT.Id desc

		insert into BILL
		values (@id, @debt_id, @paidmoney, @paidmethod)

		insert into VENDOR_BILL
		values (@id, @vendor_id, @paidstaff)
	end try
	begin catch
		rollback tran
	end catch
	commit tran
return 0
end
  
go
alter procedure Delete_Vendor_Bill
	@id int
as
begin
	begin tran Delete_Vendor_Bill
		delete from VENDOR_BILL
		where VENDOR_BILL.Id = @id

		delete from BILL
		where Id = @id

		delete from DOCUMENT
		where Id = @id
	commit tran
return 0
end

go
alter procedure Update_Vendor_Bill
	@id int,
	@documentkey varchar(32),
	@creator int,
	@createdate smalldatetime,
	@paidmethod nvarchar(32),
	@paidmoney float,
	@paidstaff int,
	@vendor_id int
as
begin
	begin tran Update_Vendor_Bill
		
		update VENDOR_BILL
		set Vendor_id = @vendor_id, PaidStaff = @paidstaff
		where Id = @id

		update BILL
		set PaidMoney = @paidmoney, PaidMethod = @paidmethod
		where BILL.Id = @id

		update DOCUMENT
		set DocumentKey = @documentkey, Creator = @creator, CreateDate = @createdate
		where DOCUMENT.Id = @id

	commit tran 
return 0
end



-- Customer Debt
go
alter procedure Insert_Customer_Debt
	@documentkey varchar(32),
	@creator int,
	@createdate smalldatetime,
	@debtmoney float,
	@paid float,
	@remain float,
	@datepaid smalldatetime,
	@extrapaid float,
	@status nvarchar(16),
	@customer_id int,
	@purchase_id int,
	@income float
as
begin
	begin tran Insert_Customer_Debt
	begin try
		insert into DOCUMENT(DocumentKey, [Type], Creator, CreateDate)
		values (@documentkey, 'customerdebt', @creator, @createdate)
	
		declare @id int
		select top 1 @id = Id from DOCUMENT
		order by DOCUMENT.Id desc

		insert into DEBT
		values (@id, @debtmoney, @paid, @remain, @datepaid, @extrapaid, @status)

		insert into CUSTOMER_DEBT
		values (@id, @customer_id, @purchase_id, @income)
	end try
	begin catch
		rollback tran
	end catch
	commit tran
return 0
end

go
alter procedure Delete_Customer_Debt
	@id int
as
begin
	begin tran Delete_Customer_Debt
		exec Delete_Customer_Bill_By_Debt
			@debt_id = @id

		delete CUSTOMER_DEBT where Id = @id
		delete DEBT where Id = @id
		delete DOCUMENT where Id = @id
	commit tran
return 0
end

go
alter procedure Delete_Customer_Debt_By_Order
	@purchaseorder_id int
as
begin
	begin tran Delete_Customer_Debt_By_Order

		declare @ids table(id int)
		insert into @ids(id)
			(select Id from CUSTOMER_DEBT where PurchaseOrder_id = @purchaseorder_id)

		declare @count int
		select @count = COUNT(id) from @ids

		declare @curId int
		while (@count > 0)
		begin
			select top 1 @curId = id from @ids
				exec Delete_Customer_Debt
					@id = @curId
			delete top(1) from @ids
			select @count = COUNT(id) from @ids
		end

	commit tran
return 0
end

go
create procedure Delete_Customer_Debt_By_CustomerId
	@customer_id int
as
begin
	begin tran Del_CustomerDebt_By_CustomerId

		declare @ids table(id int)
		insert into @ids(id)
			(select Id from CUSTOMER_DEBT where CUSTOMER_DEBT.Customer_id = @customer_id)

		declare @count int
		select @count = COUNT(id) from @ids

		declare @curId int
		while (@count > 0)
		begin
			select top 1 @curId = id from @ids
				exec Delete_Customer_Debt
					@id = @curId
			delete top(1) from @ids
			select @count = COUNT(id) from @ids
		end

	commit tran
return 0
end

go
alter procedure Update_Customer_Debt
	@id int,
	@documentkey varchar(32),
	@creator int,
	@createdate smalldatetime,
	@debtmoney float,
	@paid float,
	@remain float,
	@datepaid smalldatetime,
	@extrapaid float,
	@status nvarchar(16),
	@customer_id int,
	@income float
as
begin
	begin tran Update_Customer_Debt
		update CUSTOMER_DEBT
		set Customer_id = @customer_id, InCome = @income
		where Id = @id

		update Debt
		set DebtMoney = @debtmoney, Paid = @paid, Remain = @remain, DatePaid = @datepaid, ExtraPaid = @extrapaid, [Status] = @status
		where Id = @id

		update DOCUMENT
		set DocumentKey = @documentkey, Creator = @creator, CreateDate = @createdate
		where DOCUMENT.Id = @id
	commit tran
return 0
end

-- Vendor Debt
go
alter procedure Insert_Vendor_Debt
	@documentkey varchar(32),
	@creator int,
	@createdate smalldatetime,
	@debtmoney float,
	@paid float,
	@remain float,
	@datepaid smalldatetime,
	@extrapaid float,
	@status nvarchar(16),
	@vendor_id int,
	@vendororder_id int,
	@outcome float
as
begin
	begin tran Insert_Vendor_Debt
	begin try
		insert into DOCUMENT(DocumentKey, [Type], Creator, CreateDate)
		values (@documentkey, 'vendordebt', @creator, @createdate)
	
		declare @id int
		select top 1 @id = Id from DOCUMENT
		order by DOCUMENT.Id desc

		insert into DEBT
		values (@id, @debtmoney, @paid, @remain, @datepaid, @extrapaid, @status)

		insert into VENDOR_DEBT
		values(@id, @vendor_id, @vendororder_id, @outcome)
	end try
	begin catch
		rollback tran
	end catch
	commit tran
return 0
end


go
create procedure Delete_Vendor_Debt
	@id int
as
begin
	begin tran Delete_Vendor_Debt
		delete from VENDOR_DEBT	where VENDOR_DEBT.Id = @id
		delete from DEBT where Id = @id
		delete from DOCUMENT where Id = @id
	commit tran
return 0
end

go
alter procedure Update_vendor_Debt
	@id int,
	@documentkey varchar(32),
	@creator int,
	@createdate smalldatetime,
	@debtmoney float,
	@paid float,
	@remain float,
	@datepaid smalldatetime,
	@extrapaid float,
	@status nvarchar(16),
	@vendor_id int,
	@outcome float
as
begin
	begin tran Update_vendor_Debt
		
		update VENDOR_DEBT
		set Vendor_id = @vendor_id, OutCome = @outcome
		where Id = @id

		update Debt
		set DebtMoney = @debtmoney, Paid = @paid, Remain = @remain, DatePaid = @datepaid, ExtraPaid = @extrapaid, [Status] = @status
		where Id = @id

		update DOCUMENT
		set DocumentKey = @documentkey, Creator = @creator, CreateDate = @createdate
		where DOCUMENT.Id = @id
	commit tran
return 0
end



-- Customer Order
go
alter procedure Insert_Customer_Order
	@documentkey varchar(32),
	@creator int,
	@createdate smalldatetime,
	@transactiondate smalldatetime,
	@totalprice float,
	@vat float,
	@finalprice float,
	@status nvarchar(16),
	@customer_id int,
	@discount float,
	@extrapaid float,
	@ismultipaid bit,
	@datepaid_debt smalldatetime = null
as
begin
	begin tran Insert_Customer_Order
	begin try
		insert into DOCUMENT(DocumentKey, [Type], Creator, CreateDate)
		values (@documentkey, 'customerorder', @creator, @createdate)
	
		declare @id int
		select top 1 @id = Id from DOCUMENT
		order by DOCUMENT.Id desc

		insert into [ORDER]
		values(@id, @transactiondate, @totalprice, @vat, @finalprice, @status)
		
		insert into PURCHASE_ORDER
		values(@id, @customer_id, @discount, @extrapaid, @ismultipaid)

		declare @debt_key varchar(32)
		select @debt_key = N'CD_' + @documentkey

		declare @date_debt smalldatetime
		if (@datepaid_debt is null)
			select @date_debt = @createdate
		else 
			select @date_debt = @datepaid_debt
		exec dbo.Insert_Customer_Debt
			@documentkey = @debt_key,
			@creator = @creator,
			@createdate = @createdate,
			@debtmoney = 0,	-- mới insert order thì finalprice = 0
			@paid = 0,
			@remain = 0,
			@datepaid = @datepaid_debt,
			@extrapaid = 0,
			@status = 'nopaid',
			@customer_id = @customer_id,
			@purchase_id = @id,
			@income = 0
	end try
	begin catch
		rollback tran
	end catch
	commit tran
return 0
end

go
alter procedure Delete_Customer_Order
	@id int
as
begin
	begin tran Delete_Customer_Order
		
		exec Delete_Customer_Debt_By_Order
			@purchaseorder_id = @id

		delete from PURCHASE_ORDER where Id = @id
		delete from ORDER_DETAIL where Id = @id
		delete from [ORDER] where Id = @id
		delete from DOCUMENT where Id = @id
	commit tran
return 0
end

go
create procedure Delete_Customer_Order_By_CustomerId
	@customer_id int
as
begin
	begin tran Del_CustomerOrder_By_CustomerId
		
		declare @ids table(id int)
		insert into @ids(id)
			(select Id from PURCHASE_ORDER where PURCHASE_ORDER.Customer_id = @customer_id)

		declare @count int
		select @count = COUNT(id) from @ids

		declare @curId int
		while (@count > 0)
		begin
			select top 1 @curId = id from @ids
				exec Delete_Customer_Order
					@id = @curId
			delete top(1) from @ids
			select @count = COUNT(id) from @ids
		end
	commit tran
return 0
end

go
alter procedure Update_Customer_Order
	@id int,
	@documentkey varchar(32),
	@creator int,
	@createdate smalldatetime,
	@transactiondate smalldatetime,
	@totalprice float,
	@vat float,
	@finalprice float,
	@status nvarchar(16),
	@customer_id int,
	@discount float,
	@extrapaid float,
	@ismultipaid bit
as
begin
	begin tran Update_Customer_Order

		update PURCHASE_ORDER
		set  Customer_id = @customer_id, Discount = @discount, ExtraPaid = @extrapaid, IsMultiPaid = @ismultipaid
		where Id = @id

		update [ORDER]
		set TransactionDate = @transactiondate, TotalPrice = @totalprice, VAT = @vat, FinalPrice = @finalprice, [Status] = @status
		where Id = @id

		update DOCUMENT
		set DocumentKey = @documentkey, Creator = @creator, CreateDate = @createdate
		where Id = @id 
	commit tran
return 0
end


-- Vendor Order
go
alter procedure Insert_Vendor_Order
	@documentkey varchar(32),
	@creator int,
	@createdate smalldatetime,
	@transactiondate smalldatetime,
	@totalprice float,
	@vat float,
	@status nvarchar(16),
	@vendor_id int
as
begin
	-- finalprice có trigger tự động tính. không cần nhập
	begin tran Insert_Vendor_Order
	begin try
		insert into DOCUMENT(DocumentKey, [Type], Creator, CreateDate)
		values (@documentkey, 'vendororder', @creator, @createdate)
	
		declare @id int
		select top 1 @id = Id from DOCUMENT
		order by DOCUMENT.Id desc

		insert into [ORDER](Id, TransactionDate, TotalPrice, VAT, [Status])
		values(@id, @transactiondate, @totalprice, @vat, @status)
		
		insert into VENDOR_ORDER
		values(@id, @vendor_id)
	end try
	begin catch
		rollback tran
	end catch
	commit tran
return 0
end

go
create procedure Delete_Vendor_Order
	@id int
as
begin
	begin tran Delete_Vendor_Oreder
		delete from VENDOR_ORDER where Id = @id
		delete from [ORDER] where Id = @id
		delete from DOCUMENT where Id = @id
	commit tran
return 0
end

go
alter procedure Update_Vendor_Order
	@id int,
	@documentkey varchar(32),
	@creator int,
	@createdate smalldatetime,
	@transactiondate smalldatetime,
	@totalprice float,
	@vat float,
	@status nvarchar(16),
	@vendor_id int
as 
begin
	-- final price có trigger tự động tính. không cần nhập
	begin tran Update_Vendor_Order
		update VENDOR_ORDER
		set Vendor_id = @vendor_id
		where Id = @id

		update [ORDER]
		set TransactionDate = @transactiondate, TotalPrice = @totalprice, VAT = @vat, [Status] = @status
		where Id = @id

		update DOCUMENT
		set DocumentKey = @documentkey, Creator = @creator, CreateDate = @createdate
		where Id = @id 
	commit tran
return 0
end


-- InoutInventory

go
alter procedure Insert_InoutInventory
	@documentkey varchar(32),
	@creator int,
	@createdate smalldatetime,
	@respond int,
	@inventory_id int,
	@carry_fee float,
	@note nvarchar(256)
as
begin
	begin tran Insert_InoutInventory
	begin try
		insert into DOCUMENT(DocumentKey, [Type], Creator, CreateDate)
		values (@documentkey, 'inoutinventory', @creator, @createdate)
	
		declare @id int
		select top 1 @id = Id from DOCUMENT
		order by DOCUMENT.Id desc

		insert into INOUTINVENTORY
		values(@id, @respond, @inventory_id, @carry_fee, @note)
	end try
	begin catch
		rollback tran
	end catch
	commit tran
return 0
end

go
create procedure Delete_InoutInventory
	@id int
as
begin
	begin tran Delete_InoutInventory
		delete from INOUTINVENTORY where Id = @id
		delete from DOCUMENT where Id = @id
	commit tran
return 0
end
	
go
alter procedure Update_InoutInventory
	@id int,
	@documentkey varchar(32),
	@creator int,
	@createdate smalldatetime,
	@respond int,
	@carry_fee float,
	@note nvarchar(256)
as
begin
	begin tran Update_InoutInventory
		update INOUTINVENTORY
		set Respond = @respond, CarryFee = @carry_fee, Note = @note
		where Id = @id

		update DOCUMENT
		set DocumentKey = @documentkey, Creator = @creator, CreateDate = @createdate
	commit tran
return 0
end