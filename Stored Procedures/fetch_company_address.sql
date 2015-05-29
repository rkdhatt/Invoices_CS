SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =================================================================================
-- Author:		Raman Dhatt
-- Create date: 2015-05-19
-- Description:	Procedure that retreives address information 
--              for the company report based on company ID.
-- Revisions:
--		Author                  Date       	Description                                       
--		------------------- 	---------- 	--------------------------------------
-- =================================================================================

IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'fetch_company_address')
	DROP PROCEDURE fetch_company_address
GO

CREATE PROCEDURE fetch_company_address
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

		select name, c.company_id, addresses, address_id, phone, date_modify
		from companies c, addresses a
		where c.company_id = a.company_id and c.company_id = @company_id

	COMMIT TRANSACTION
END
GO

GRANT EXECUTE ON fetch_company_address TO PUBLIC
GO
