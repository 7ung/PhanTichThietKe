
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
		insert into DOCUMENT(DocumentKey, [Type], Creator, CreateDate)
		values (@documentkey, 'vendorbill', @creator, @createdate)
	
		declare @id int
		select top 1 @id = Id from DOCUMENT
		order by DOCUMENT.Id desc

		insert into BILL
		values (@id, @debt_id, @paidmoney, @paidmethod)

		insert into VENDOR_BILL
		values (@id, @vendor_id, @paidstaff)

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
		insert into DOCUMENT(DocumentKey, [Type], Creator, CreateDate)
		values (@documentkey, 'customerdebt', @creator, @createdate)
	
		declare @id int
		select top 1 @id = Id from DOCUMENT
		order by DOCUMENT.Id desc

		insert into DEBT
		values (@id, @debtmoney, @paid, @remain, @datepaid, @extrapaid, @status)

		insert into CUSTOMER_DEBT
		values (@id, @customer_id, @purchase_id, @income)

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
		insert into DOCUMENT(DocumentKey, [Type], Creator, CreateDate)
		values (@documentkey, 'vendordebt', @creator, @createdate)
	
		declare @id int
		select top 1 @id = Id from DOCUMENT
		order by DOCUMENT.Id desc

		insert into DEBT
		values (@id, @debtmoney, @paid, @remain, @datepaid, @extrapaid, @status)

		insert into VENDOR_DEBT
		values(@id, @vendor_id, @vendororder_id, @outcome)

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
-- Customer Order
go
alter procedure Insert_Customer_Order
	@documentkey varchar(32),
	@creator int,
	@createdate smalldatetime,
	@transactiondate smalldatetime,
	@customer_id int,
	@extrapaid float = 0,
	@ismultipaid bit = 0,
	@datepaid_debt smalldatetime = null
as
begin
	begin tran Insert_Customer_Order
		insert into DOCUMENT(DocumentKey, [Type], Creator, CreateDate)
		values (@documentkey, 'customerorder', @creator, @createdate)
	
		declare @id int
		select top 1 @id = Id from DOCUMENT
		order by DOCUMENT.Id desc

		insert into [ORDER]
		values(@id, @transactiondate, 0, 0, 0, '')
		
		insert into PURCHASE_ORDER
		values(@id, @customer_id, 0, @extrapaid, @ismultipaid)

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
			@datepaid = @date_debt,
			@extrapaid = 0,
			@status = 'nopaid',
			@customer_id = @customer_id,
			@purchase_id = @id,
			@income = 0

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

		delete from ORDER_DETAIL where Order_id = @id
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



-- Vendor Order
go
alter procedure Insert_Vendor_Order
	@documentkey varchar(32),
	@creator int,
	@createdate smalldatetime,
	@transactiondate smalldatetime,
	@vendor_id int,
	@datepaid_debt smalldatetime = null
as
begin
	-- finalprice có trigger tự động tính. không cần nhập
	begin tran Insert_Vendor_Order
		insert into DOCUMENT(DocumentKey, [Type], Creator, CreateDate)
		values (@documentkey, 'vendororder', @creator, @createdate)
	
		declare @id int
		select top 1 @id = Id from DOCUMENT
		order by DOCUMENT.Id desc

		insert into [ORDER](Id, TransactionDate, TotalPrice, VAT, FinalPrice,[Status])
		values(@id, @transactiondate, 0, 0, 0, '')
		
		insert into VENDOR_ORDER
		values(@id, @vendor_id)

		declare @debt_key varchar(32)
		select @debt_key = N'VD_' + @documentkey
		declare @date_debt smalldatetime
		if (@datepaid_debt is null)
			select @date_debt = @createdate
		else 
			select @date_debt = @datepaid_debt
		exec Insert_Vendor_Debt
			@documentkey = @debt_key,
			@creator = @creator,
			@createdate = @createdate,
			@debtmoney = 0,	-- mới insert order thì finalprice = 0
			@paid = 0,
			@remain = 0,
			@datepaid = @date_debt,
			@extrapaid = 0,
			@status = 'nopaid',
			@vendor_id = @vendor_id,
			@vendororder_id = @id,
			@outcome = 0
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
create procedure Delete_Vendor_Bill_By_Debt
	@debt_id int
as
begin
	begin tran Delete_Vendor_Bill_By_Debt
		declare @ids table(id int)
		insert into @ids(id)
			(select Id from BILL where BILL.Debt_id = @debt_id)

		declare @count int, @curId int
		select @count = COUNT(id) from @ids
		while (@count > 0)
		begin
			select top 1 @curId = id from @ids
			exec Delete_Vendor_Bill
				@id = @curId

			delete top(1) from @ids
			select @count = COUNT(id) from @ids
		end
	commit tran
end

go
create procedure Delete_Vendor_Bill_By_Customer
	@customer_id int
as
begin
	begin tran Delete_Vendor_Bill_By_Customer
		declare @ids table(id int)
		insert into @ids(id)
			(select Id from BILL where BILL.Debt_id = @customer_id)

		declare @count int
		select @count = COUNT(id) from @ids

		declare @curId int
		while (@count > 0)
		begin
			select top 1 @curId = id from @ids
				exec Delete_Vendor_Bill
					@id = @curId
			delete top(1) from @ids
			select @count = COUNT(id) from @ids
		end

	commit tran
end

go
alter procedure Delete_Vendor_Debt_By_Vendor
	@vendor_id int
as
begin
	begin tran Delete_Vendor_Debt_By_Vendor
		declare @ids table(id int)
		insert into @ids(id)
			(select Id from VENDOR_DEBT where VENDOR_DEBT.Vendor_id = @vendor_id)

		declare @count int
		select @count = COUNT(id) from @ids

		declare @curId int
		while (@count > 0)
		begin
			select top 1 @curId = id from @ids
				exec Delete_Vendor_Debt
					@id = @curId
			delete top(1) from @ids
			select @count = COUNT(id) from @ids
		end
	commit tran
end

go
create procedure Delete_Vendor_Debt_By_Order
	@vendororder_id int
as
begin
	begin tran Delete_Vendor_Debt_By_Order
		declare @ids table(id int)
		insert into @ids(id)
			(select Id from VENDOR_DEBT where VENDOR_DEBT.VendorOrder_id = @vendororder_id)
		
		declare @count int
		select @count = COUNT(id) from @ids

		declare @curId int
		while (@count > 0)
		begin
			select top 1 @curId = id from @ids
				exec Delete_Vendor_Debt
					@id = @curId
			delete top(1) from @ids
			select @count = COUNT(id) from @ids
		end

	commit tran
end

go
create procedure Delete_Vendor_Order_By_Vendor
	@vendor_id int
as
begin
	begin tran Delete_Vendor_Order_By_Vendor
		
		declare @ids table(id int)
		insert into @ids(id)
			(select Id from VENDOR_ORDER where VENDOR_ORDER.Vendor_id = @vendor_id)
		
		declare @count int
		select @count = COUNT(id) from @ids

		declare @curId int
		while (@count > 0)
		begin
			select top 1 @curId = id from @ids
				exec Delete_Vendor_Order
					@id = @curId
			delete top(1) from @ids
			select @count = COUNT(id) from @ids
		end
	commit tran
end