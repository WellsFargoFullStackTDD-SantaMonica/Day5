USE [AdventureWorks2012]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[ufnGetCustomerSalesCount]
		@CustomerID = 29825

SELECT	@return_value as 'Return Value'

GO
