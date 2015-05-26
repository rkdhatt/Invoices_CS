SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =================================================================================
-- Author:		Raman Dhatt
-- Create date: 2015-05-26
-- Description:	Procedure that retrieves all invoices by company ID.
-- Revisions:
--		Author                  Date       	Description                                       
--		------------------- 	---------- 	--------------------------------------
-- =================================================================================
IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'fetch_invoices_by_comp_ID')
	DROP PROCEDURE fetch_invoices_by_comp_ID
GO

CREATE PROCEDURE fetch_invoices_by_comp_ID 
	@company_id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

    -- Insert statements for procedure here
	SELECT * from invoices
	WHERE invoices.company_id = @company_id;
	
END
GO

GRANT EXECUTE ON fetch_invoices_by_comp_ID TO PUBLIC
