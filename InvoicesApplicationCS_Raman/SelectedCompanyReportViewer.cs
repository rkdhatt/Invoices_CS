using CemDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoicesApplicationCS_Raman
{
	public partial class SelectedCompanyReportViewer : Form
	{
		private DBDataSet dbAddressesReport;
		private DataSet dsAddressesReport;
		private DataTable tableAddressesReport;

		private DBDataSet dbInvoicesReport;
		private DataSet dsInvoicesReport;
		private DataTable tableInvoicesReport;

		int company_id;
		public SelectedCompanyReportViewer(int cID)
		{
			InitializeComponent();

			company_id = cID;

			// Set up CemDB to use the .udl file
			DBControl.ConnectionFile(Application.StartupPath + "\\newer_invoice.udl");

			// Initialize data sets and table
			dbAddressesReport = new DBDataSet();
			dbInvoicesReport = new DBDataSet();

			dsAddressesReport = new DataSet();
			dsInvoicesReport = new DataSet();

			tableAddressesReport = new DataTable();
			tableInvoicesReport = new DataTable();
			dbAddressesReport.BeforeFetch += dbAddressesReport_BeforeFetch;
			dbInvoicesReport.BeforeFetch += dbInvoicesReport_BeforeFetch;

			// Stored procedures for report
			dbAddressesReport.FetchStoredProcedure = "fetch_company_address";
			dbInvoicesReport.FetchStoredProcedure = "fetch_company_invoices";

			dbAddressesReport.DataSet = dsAddressesReport;
			dbInvoicesReport.DataSet = dsInvoicesReport;

			// Save data into tables
			dbAddressesReport.FetchDataTable(tableAddressesReport);
			dbInvoicesReport.FetchDataTable(tableInvoicesReport);

			// Connect report to report viewer
			this.selectedCompReportViewer.Reset();
			this.selectedCompReportViewer.LocalReport.ReportEmbeddedResource = "InvoicesApplicationCS_Raman.SelectedCompanyReport.rdlc";
			this.selectedCompReportViewer.LocalReport.DataSources.Clear();
			this.selectedCompReportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("selectedAddressDataSet", tableAddressesReport));
			this.selectedCompReportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("selectedInvoiceDataSet", tableInvoicesReport));
		}

		void dbInvoicesReport_BeforeFetch(object sender, System.Data.SqlClient.SqlCommand cmd, Cancel cancel)
		{
			cmd.Parameters["@company_id"].Value = company_id;
		}

		void dbAddressesReport_BeforeFetch(object sender, System.Data.SqlClient.SqlCommand cmd, Cancel cancel)
		{
			cmd.Parameters["@company_id"].Value = company_id;
		}

		private void SelectedCompanyReportViewer_Load(object sender, EventArgs e)
		{

			this.selectedCompReportViewer.RefreshReport();
		}
	}
}
