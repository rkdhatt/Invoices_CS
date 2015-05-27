SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =================================================================================
-- Author:		Raman Dhatt
-- Create date: 2015-05-27
-- Description:	Procedure that retrieves all addresses by company ID.
-- Revisions:
--		Author                  Date       	Description                                       
--		------------------- 	---------- 	--------------------------------------
-- =================================================================================
IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'fetch_addresses_by_comp_ID')
	DROP PROCEDURE fetch_addresses_by_comp_ID
GO

CREATE PROCEDURE fetch_addresses_by_comp_ID 
	@company_id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	BEGIN TRANSACTION
	    -- Insert statements for procedure here
		SELECT c.company_id, address_id, phone, date_modify
		FROM companies c, addresses a
		WHERE c.company_id = a.company_id and a.company_id = @company_id
	COMMIT TRANSACTION

END
GO

GRANT EXECUTE ON fetch_addresses_by_comp_ID TO PUBLIC
GO
