

go
CREATE FUNCTION [dbo].CheckDocumentType
(
	@documentid int,
	@documenttypename varchar(32)
)
RETURNS BIT
AS
BEGIN
	declare @documenttype varchar(32)
	select @documenttype = DocumentKey from DOCUMENT
		where DOCUMENT.Id = @documentid
	if (@documenttype = @documenttypename)
		return 1
	return 0
END

