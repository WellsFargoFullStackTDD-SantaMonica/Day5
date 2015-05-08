CREATE FUNCTION [dbo].[ufnGetCustomerSalesCount]
(
	@CustomerID int
)
RETURNS INT
AS
BEGIN
	declare @count int;

	select @count = count(*)
	from Sales.SalesOrderHeader
	where CustomerID = @CustomerID

	RETURN @count
END



