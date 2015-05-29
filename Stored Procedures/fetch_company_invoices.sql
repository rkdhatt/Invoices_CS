SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =================================================================================
-- Author:		Raman Dhatt
-- Create date: 2015-05-19
-- Description:	Procedure that retreives invoice information 
--              for the company report based on company ID.
-- Revisions:
--		Author                  Date       	Description                                       
--		------------------- 	---------- 	--------------------------------------
-- =================================================================================

IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'fetch_company_invoices')
	DROP PROCEDURE fetch_company_invoices
GO

CREATE PROCEDURE fetch_company_invoices
	-- Add the parameters for the stored procedure here
	@company_id int = 1

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	IF (@company_id IS NULL) BEGIN
		RAISERROR('Error: Company ID does not exist.', 16, 1)
		RETURN -1
	END
    -- Insert statements for procedure here
	BEGIN TRANSACTION

		select i.company_id, i.invoice_id, date, terms, description, quantity, cost
		from invoices i, details d
		where i.company_id = @company_id and i.invoice_id = d.invoice_id

	COMMIT TRANSACTION
END
GO

GRANT EXECUTE ON fetch_company_invoices TO PUBLIC
GO
