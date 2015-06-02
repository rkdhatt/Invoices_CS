using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CemDB;

namespace InvoicesApplicationCS_Raman
{
	/// <summary>
	/// Invoice Chart for total invoice costs of a company during a specified year.
	/// </summary>
	public partial class SelectedCompanyInvoiceCostsChartForm : Form
	{
		private DBDataSet dbInvoicesReport;
		private DataSet dsInvoicesReport;
		private DataTable tableInvoicesReport;
		private int companyID;
		private int year;

		/// <summary>
		/// Initializes a new instance of the <see cref="SelectedCompanyInvoiceCostsChartForm"/> class.
		/// Selected Company Invoice Costs Chart Form constructor
		/// </summary>
		/// <param name="compID">Company ID</param>
		/// <param name="selectedYear">invoices obtained by specifying year</param>
		public SelectedCompanyInvoiceCostsChartForm(int compID, int selectedYear)
		{
			this.InitializeComponent();

			// Set up CemDB to use the .udl file
			DBControl.ConnectionFile(Application.StartupPath + "\\newer_invoice.udl");

			// Initialize data set and table
			this.dbInvoicesReport = new DBDataSet();
			this.dsInvoicesReport = new DataSet();
			this.tableInvoicesReport = new DataTable();

			// Initialize ID's
			this.companyID = compID;
			this.year = selectedYear;

			this.dbInvoicesReport.BeforeFetch += this.DBInvoicesReport_BeforeFetch;

			// Stored procedures for report
			this.dbInvoicesReport.FetchStoredProcedure = "fetch_invoice_costs_chart_by_compID";

			this.dbInvoicesReport.DataSet = this.dsInvoicesReport;

			// Save data into tables
			this.dbInvoicesReport.FetchDataTable(this.tableInvoicesReport);

			// Check if table has data
			if (this.tableInvoicesReport.Rows.Count == 0)
			{
				MessageBox.Show("No data to display for this company.", "No Data", MessageBoxButtons.OK);
				this.selectedCompInvoiceCostsReportViewer.CancelRendering(100);
				this.Close();
			}
			else
			{
				// Connect report to report viewer
				this.selectedCompInvoiceCostsReportViewer.Reset();
				this.selectedCompInvoiceCostsReportViewer.LocalReport.ReportEmbeddedResource = "InvoicesApplicationCS_Raman.SelectedCompanyCostsByYearReport.rdlc";
				this.selectedCompInvoiceCostsReportViewer.LocalReport.DataSources.Clear();
				this.selectedCompInvoiceCostsReportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("selectedCompCostsDataSet", this.tableInvoicesReport));
			}
		}

		// Pass in company ID and year parameters
		private void DBInvoicesReport_BeforeFetch(object sender, System.Data.SqlClient.SqlCommand cmd, Cancel cancel)
		{
			cmd.Parameters["@company_id"].Value = this.companyID;
			cmd.Parameters["@year"].Value = this.year;
		}

		private void SelectedCompanyInvoiceCostsChartForm_Load(object sender, EventArgs e)
		{
			this.selectedCompInvoiceCostsReportViewer.RefreshReport();
			this.selectedCompInvoiceCostsReportViewer.RefreshReport();
		}
	}
}