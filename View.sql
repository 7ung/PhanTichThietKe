
-- truy xuất dữ liệu đơn thanh toán khách hàng.
go
CREATE VIEW [dbo].[Customer_Bill_View]
	AS SELECT DOCUMENT.*,
	BILL.Debt_id, BILL.PaidMethod, BILL.PaidMoney,
	CUSTOMER_BILL.Customer_id, CUSTOMER_BILL.ChangeMoney, CUSTOMER_BILL.ReceiveMoney
	from CUSTOMER_BILL join BILL on CUSTOMER_BILL.Id = BILL.Id join DOCUMENT on BILL.Id = DOCUMENT.Id

go
create view Vendor_Bill_View
as 
select DOCUMENT.*,
	BILL.Debt_id, BILL.PaidMethod, BILL.PaidMoney,
	VENDOR_BILL.PaidStaff, VENDOR_BILL.Vendor_id
	from VENDOR_BILL join BILL on VENDOR_BILL.Id = BILL.Id join DOCUMENT on BILL.Id = DOCUMENT.Id

go
create view Customer_Debt_View
as
select DOCUMENT.*,
	DEBT.DebtMoney, DEBT.Paid, DEBT.Remain, DEBT.DatePaid, DEBT.ExtraPaid, DEBT.[Status],
	CUSTOMER_DEBT.PurchaseOrder_id, CUSTOMER_DEBT.Customer_id, CUSTOMER_DEBT.InCome
	from CUSTOMER_DEBT join DEBT on CUSTOMER_DEBT.Id = DEBT.Id join DOCUMENT on DEBT.Id = DOCUMENT.Id

go
create view Vendor_Debt_View
as
select DOCUMENT.*,
	DEBT.DebtMoney, DEBT.Paid, DEBT.Remain, DEBT.DatePaid, DEBT.ExtraPaid, DEBT.[Status],
	VENDOR_DEBT.VendorOrder_id, VENDOR_DEBT.Vendor_id, VENDOR_DEBT.OutCome
	from VENDOR_DEBT join DEBT on VENDOR_DEBT.Id = DEBT.Id join DOCUMENT on DEBT.Id = DOCUMENT.Id

go
create view Customer_Order_View
as
select DOCUMENT.*,
	[ORDER].TotalPrice,[ORDER].VAT,[ORDER].FinalPrice,[ORDER].TransactionDate,[ORDER].[Status],
	PURCHASE_ORDER.Customer_id, PURCHASE_ORDER.Discount, PURCHASE_ORDER.ExtraPaid, PURCHASE_ORDER.IsMultiPaid
from PURCHASE_ORDER join [ORDER] on PURCHASE_ORDER.Id = [ORDER].Id join DOCUMENT on [ORDER].Id = DOCUMENT.Id

go
create view Vendor_Order_View
as
select  DOCUMENT.*,
	[ORDER].TotalPrice,[ORDER].VAT,[ORDER].FinalPrice,[ORDER].TransactionDate,[ORDER].[Status],
	VENDOR_ORDER.Vendor_id
from VENDOR_ORDER join [ORDER] on VENDOR_ORDER.Id = [ORDER].Id join DOCUMENT on [ORDER].Id = DOCUMENT.Id

go
alter view InOut_Inventory_View
as
select DOCUMENT.*,
	INOUTINVENTORY.Inventory_id, INOUTINVENTORY.Respond, INOUTINVENTORY.CarryFee, INOUTINVENTORY.Term ,INOUTINVENTORY.[Type] as InOutType
from INOUTINVENTORY join DOCUMENT on INOUTINVENTORY.Id = DOCUMENT.Id

go
alter view InOutInventory_Detail_ProductQuantity_View
as
select INOUT_INVENTORY_DETAIL.InOutInventory_id, ORDER_DETAIL.Product_id, Sum(ORDER_DETAIL.Quantity) as Quantity
from INOUT_INVENTORY_DETAIL, ORDER_DETAIL
where INOUT_INVENTORY_DETAIL.Order_id = ORDER_DETAIL.Order_id
group by INOUT_INVENTORY_DETAIL.InOutInventory_id, ORDER_DETAIL.Product_id