SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =================================================================================
-- Author:		Raman Dhatt
-- Create date: 2015-05-28
-- Description:	Procedure that retreives all companies and their addresses.
-- Revisions:
--		Author                  Date       	Description                                       
--		------------------- 	---------- 	--------------------------------------
-- =================================================================================

IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'fetch_all_company_addresses_report')
	DROP PROCEDURE fetch_all_company_addresses_report
GO

CREATE PROCEDURE fetch_all_company_addresses_report

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

    -- Insert statements for procedure here
	BEGIN TRANSACTION
		SELECT c.company_id, name, address_id, addresses, phone, date_modify
		FROM companies c, addresses a
		WHERE c.company_id = a.company_id

	COMMIT TRANSACTION

	GRANT EXECUTE ON fetch_all_company_addresses_report TO PUBLIC

END
GO
