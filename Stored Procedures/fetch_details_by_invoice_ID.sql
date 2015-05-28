SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =================================================================================
-- Author:		Raman Dhatt
-- Create date: 2015-05-15
-- Description:	Procedure that retrieves all details for an invoice.
-- Revisions:
--		Author                  Date       	Description                                       
--		------------------- 	---------- 	--------------------------------------
-- =================================================================================
IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'fetch_details_by_invoice_ID')
	DROP PROCEDURE fetch_details_by_invoice_ID
GO

CREATE PROCEDURE fetch_details_by_invoice_ID
	@invoice_id INT

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

    -- Insert statements for procedure here
	BEGIN TRANSACTION
		SELECT i.invoice_id, d.detail_id, d.description, d.quantity, d.cost
		FROM invoices i, details d
		WHERE i.invoice_id = d.invoice_id AND d.invoice_id = @invoice_id
	COMMIT TRANSACTION

	GRANT EXECUTE ON fetch_details_by_invoice_ID TO PUBLIC
	
END
GO
