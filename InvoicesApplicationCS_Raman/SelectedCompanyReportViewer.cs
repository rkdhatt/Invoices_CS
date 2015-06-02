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
	/// SelectedCompanyReportViewer partial class
	/// </summary>
	public partial class SelectedCompanyReportViewer : Form
	{
		private DBDataSet dbAddressesReport;
		private DataSet dsAddressesReport;
		private DataTable tableAddressesReport;

		private DBDataSet dbInvoicesReport;
		private DataSet dsInvoicesReport;
		private DataTable tableInvoicesReport;

		private int companyId;

		/// <summary>
		/// Initializes a new instance of the <see cref="SelectedCompanyReportViewer"/> class.
		/// Selected Company Report constructor
		/// </summary>
		/// <param name="cID">Company ID</param>
		public SelectedCompanyReportViewer(int cID)
		{
			this.InitializeComponent();

			this.companyId = cID;

			// Set up CemDB to use the .udl file
			DBControl.ConnectionFile(Application.StartupPath + "\\newer_invoice.udl");

			// Initialize data sets and table
			this.dbAddressesReport = new DBDataSet();
			this.dbInvoicesReport = new DBDataSet();

			this.dsAddressesReport = new DataSet();
			this.dsInvoicesReport = new DataSet();

			this.tableAddressesReport = new DataTable();
			this.tableInvoicesReport = new DataTable();
			this.dbAddressesReport.BeforeFetch += this.DBAddressesReport_BeforeFetch;
			this.dbInvoicesReport.BeforeFetch += this.DBInvoicesReport_BeforeFetch;

			// Stored procedures for report
			this.dbAddressesReport.FetchStoredProcedure = "fetch_company_address";
			this.dbInvoicesReport.FetchStoredProcedure = "fetch_company_invoices";

			this.dbAddressesReport.DataSet = this.dsAddressesReport;
			this.dbInvoicesReport.DataSet = this.dsInvoicesReport;

			// Save data into tables
			this.dbAddressesReport.FetchDataTable(this.tableAddressesReport);
			this.dbInvoicesReport.FetchDataTable(this.tableInvoicesReport);

			// Check if table has data
			if (this.tableInvoicesReport.Rows.Count == 0)
			{
				MessageBox.Show("No data to display for this company.", "No Data", MessageBoxButtons.OK);
				this.selectedCompReportViewer.CancelRendering(100);
				this.Close();
			}
			else
			{
				// Connect report to report viewer
				this.selectedCompReportViewer.Reset();
				this.selectedCompReportViewer.LocalReport.ReportEmbeddedResource = "InvoicesApplicationCS_Raman.SelectedCompanyReport.rdlc";
				this.selectedCompReportViewer.LocalReport.DataSources.Clear();
				this.selectedCompReportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("selectedAddressDataSet", this.tableAddressesReport));
				this.selectedCompReportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("selectedInvoiceDataSet", this.tableInvoicesReport));
			}
		}

		private void DBInvoicesReport_BeforeFetch(object sender, System.Data.SqlClient.SqlCommand cmd, Cancel cancel)
		{
			cmd.Parameters["@company_id"].Value = this.companyId;
		}

		private void DBAddressesReport_BeforeFetch(object sender, System.Data.SqlClient.SqlCommand cmd, Cancel cancel)
		{
			cmd.Parameters["@company_id"].Value = this.companyId;
		}

		private void SelectedCompanyReportViewer_Load(object sender, EventArgs e)
		{
			this.selectedCompReportViewer.RefreshReport();
		}
	}
}