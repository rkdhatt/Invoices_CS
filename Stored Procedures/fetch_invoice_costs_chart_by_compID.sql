SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =================================================================================
-- Author:		Raman Dhatt
-- Create date: 2015-06-01
-- Description:	Procedure that retreives invoice costs for chart by company ID and date.
-- Revisions:
--		Author                  Date       	Description                                       
--		------------------- 	---------- 	--------------------------------------
-- =================================================================================

IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'fetch_invoice_costs_chart_by_compID')
	DROP PROCEDURE fetch_invoice_costs_chart_by_compID
GO

CREATE PROCEDURE fetch_invoice_costs_chart_by_compID
	@company_id int,
	@year int = 2015
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

    -- Insert statements for procedure here
	BEGIN TRANSACTION
		select t1Result.name, t2Result.date, CAST(isnull(sum(t2Result.sum_cost), 0) as numeric(35, 2)) as 'total_cost'
		from (select c.name, i.invoice_id
			from companies c
			left join invoices i
			on c.company_id = i.company_id AND c.company_id = @company_id
		  ) As t1Result

		  full outer join

		  (select i.invoice_id, i.date, (quantity * cost) as sum_cost
			from invoices i
			left join details d
			on i.invoice_id = d.invoice_id
		  ) As t2Result
		  on t1Result.invoice_id = t2Result.invoice_id
		where YEAR(t2Result.date) = @year
		group by t1Result.name, t2Result.date
	COMMIT TRANSACTION

END
GO

GRANT EXECUTE ON fetch_invoice_costs_chart_by_compID TO PUBLIC
GO
