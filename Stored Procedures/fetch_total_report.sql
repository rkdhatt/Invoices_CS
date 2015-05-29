SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =================================================================================
-- Author:		Raman Dhatt
-- Create date: 2015-05-29
-- Description:	Procedure that retreives all information of database
-- Revisions:
--		Author                  Date       	Description                                       
--		------------------- 	---------- 	--------------------------------------
-- =================================================================================

IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'fetch_total_report')
	DROP PROCEDURE fetch_total_report
GO

CREATE PROCEDURE fetch_total_report

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

    -- Insert statements for procedure here
	BEGIN TRANSACTION
		SELECT distinct name, c.company_id, date, terms, i.invoice_id, 
			addresses, phone, date_modify, a.address_id, description, quantity, cost, d.detail_id
		FROM companies c, invoices i, details d, addresses a
		WHERE c.company_id = a.company_id and c.company_id = i.company_id and i.invoice_id = d.invoice_id
	COMMIT TRANSACTION

END
GO

GRANT EXECUTE ON fetch_total_report TO PUBLIC
GO
