﻿USE [AdventureWorks2012]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[uspGetEmployeeManagers]
		@BusinessEntityID = 3

SELECT	@return_value as 'Return Value'

GO
