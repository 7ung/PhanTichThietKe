


use  [C:\7UNG PROJECT\PTTK\PROJECT\DATABASE\SELLMANAGEMENTDB.MDF]

set dateformat DMY
insert into GROUPofCUSTOMER(Label, Discount)
values(N'Nhóm 1', 0.00)

insert into GROUPofCUSTOMER(Label, Discount)
values(N'Nhóm 2', 0.05)

insert into GROUPofCUSTOMER(Label, Discount)
values(N'Nhóm 3', 0.10)


------------------------------

insert into CUSTOMER(Group_id, CustomerKey, Name, Gender, Phone, Email, [Address], IdentifyNumber, BirthDay)
values (1, '0001', 'Nguyen van A', 1, '0913492', 'email test', 'address test', '981048 test', '01-01-1990')

insert into CUSTOMER(Group_id, CustomerKey, Name, Gender, Phone, Email, [Address], IdentifyNumber, BirthDay)
values (2, '0002', 'Nguyen van B', 1, '0913492', 'email test', 'address test', '981048 test', '01-01-1990')

insert into CUSTOMER(Group_id, CustomerKey, Name, Gender, Phone, Email, [Address], IdentifyNumber, BirthDay)
values (1, '0003', 'Nguyen van C', 1, '0913492', 'email test', 'address test', '981048 test', '01-01-1990')

insert into CUSTOMER(Group_id, CustomerKey, Name, Gender, Phone, Email, [Address], IdentifyNumber, BirthDay)
values (3, '0004', 'Nguyen van D', 1, '0913492', 'email test', 'address test', '981048 test', '01-01-1990')

insert into CUSTOMER(Group_id, CustomerKey, Name, Gender, Phone, Email, [Address], IdentifyNumber, BirthDay)
values (1, '0005', 'Nguyen van E', 1, '0913492', 'email test', 'address test', '981048 test', '01-01-1990')

insert into CUSTOMER(Group_id, CustomerKey, Name, Gender, Phone, Email, [Address], IdentifyNumber, BirthDay)
values (2, '0006', 'Nguyen van F', 1, '0913492', 'email test', 'address test', '981048 test', '01-01-1990')


------------------------------------------

insert into STAFF(StaffKey, Phone, Gender, Email, [Address], IdentifyNumber, [Function], Birthday, Salary)
values ('0001', '091872874',0, 'email', 'address', 'ident',N'thư kí', '01-01-1990', 43.5)

insert into STAFF(StaffKey, Phone, Gender, Email, [Address], IdentifyNumber, [Function], Birthday, Salary)
values ('0002', '091872874',1, 'email', 'address', 'ident',N'nhân công', '01-01-1990', 20.5)

insert into STAFF(StaffKey, Phone, Gender, Email, [Address], IdentifyNumber, [Function], Birthday, Salary)
values ('0003', '091872874',0, 'email', 'address', 'ident',N'bốc vác', '01-01-1990',90.2)

insert into STAFF(StaffKey, Phone, Gender, Email, [Address], IdentifyNumber, [Function], Birthday, Salary)
values ('0004', '091872874',1, 'email', 'address', 'ident',N'trưởng phòng', '01-01-1990', 15.2)

insert into STAFF(StaffKey, Phone, Gender, Email, [Address], IdentifyNumber, [Function], Birthday, Salary)
values ('0005', '091872874',1, 'email', 'address', 'ident',N'dọn vệ sinh', '01-01-1990', 52.6)

insert into STAFF(StaffKey, Phone, Gender, Email, [Address], IdentifyNumber, [Function], Birthday, Salary)
values ('0006', '091872874',0, 'email', 'address', 'ident',N'bưng cà phê', '01-01-1990', 15.3)


------------------------------

insert into PRODUCT(ProductKey, Name, BarCode, Picture, InPrice, OutPrice)
values ('Pr001', 'USB 2.0', '6755676','lorem',94.2, 94.2)

insert into PRODUCT(ProductKey, Name, BarCode, Picture, InPrice, OutPrice)
values ('Pr002', 'Lap acer', '6755676','lorem',72.5, 75.2)

insert into PRODUCT(ProductKey, Name, BarCode, Picture, InPrice, OutPrice)
values ('Pr003', 'Ban phim', '6755676','lorem',81.3, 84.2)

insert into PRODUCT(ProductKey, Name, BarCode, Picture, InPrice, OutPrice)
values ('Pr004', 'Dien thoai', '6755676','lorem',94.2, 94.2)

insert into PRODUCT(ProductKey, Name, BarCode, Picture, InPrice, OutPrice)
values ('Pr005', 'Man HInh', '6755676','lorem',94.2, 94.2)


------------------------------

-- TEST  [Insert_Customer_Order]


EXEC	[dbo].[Insert_Customer_Order]
		@documentkey = N'''CO001''',
		@creator = 2,
		@createdate = '01-01-2016',
		@transactiondate = '01-01-2016',
		@totalprice = 0,
		@vat = 0,
		@finalprice = 0,
		@status = '',
		@customer_id = 2,
		@discount = 0,
		@extrapaid = 0,
		@ismultipaid = 0
GO

exec	dbo.Update_Customer_Order
		@id = 15,
		@docuemntkey = N'CO001',
		@creator = 2,
		@createdate = '01-01-2016',
		@transactiondate = '01-01-2016',
		@totalprice = 0,	
		@vat = 0,			
		@finalprice = 0,
		@status = '',
		@customer_id = 2,
		@discount = 0,
		@extrapaid = 0,
		@ismultipaid = 0


insert into ORDER_DETAIL(Order_id, Product_id, Price, Quantity)
values(15, 2, 89.2, 5) -- success


insert into ORDER_DETAIL(Order_id, Product_id, Price, Quantity)
values(15, 4, 56.2, 2) 

insert into ORDER_DETAIL(Order_id, Product_id, Price, Quantity)
values(15, 3, 71.5, 7) 


update [ORDER]
set TotalPrice = 8 
where Id = 15		-- trigger active -> success

update [ORDER]
set VAT = 8 
where Id = 15		-- trigger active -> success

update [ORDER]
set FinalPrice = 8 
where Id = 15		-- trigger active -> success

update ORDER_DETAIL
set Price = 87.2
where Id = 20		-- > success

delete from ORDER_DETAIL
where Id = 23		--> update order.TotalPrice ->success


------------------------------------------

EXEC	[dbo].[Insert_Customer_Order]
		@documentkey = N'CO002',
		@creator = 2,
		@createdate = '01-01-2016',
		@transactiondate = '01-01-2016',
		@totalprice = 0,
		@vat = 0,
		@finalprice = 0,
		@status = '',
		@customer_id = 5,
		@discount = 0,
		@extrapaid = 0,
		@ismultipaid = 0
GO


insert into ORDER_DETAIL(Order_id, Product_id, Price, Quantity)
values(16, 3, 86.1, 4)

exec Insert_Customer_Bill
	@documentkey = N'CB0001',
	@creator = 2,
	@createdate = 2,
	@debt_id = 17,
	@paidmethod = N'cash',
	@customer_id = 5,
	@changemoney = 0,
	@receivemoney = 178.84 

update CUSTOMER_BILL
set ReceiveMoney =  100, ChangeMoney = 50
where Id = 35

exec Delete_Customer_Bill
	@id	 = 34
		
update CUSTOMER_DEBT
set InCome = 1
where Id = 17		-- active trigger trigger_CUSTOMERDEBT_InCome

update DEBT
set DebtMoney = 3223
where Id = 17		-- active trigger trigger_DEBT_DebtMoney_FinalPrice

update DEBT
set Remain = 1
where Id = 17		-- active trigger trigger_DEBT_Remain

update BILL
set	PaidMoney = 1
where Id = 35