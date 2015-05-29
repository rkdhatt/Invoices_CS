using CemDB;
using Microsoft.Reporting.WinForms;
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
	// Report viewer displays all companies and their corresponding invoice terms and dates
	public partial class TotalCompInvoicesReportViewer : Form
	{
		private DBDataSet dbInvoicesReport;
		private DataSet dsInvoicesReport;
		private DataTable tableInvoicesReport;


		public TotalCompInvoicesReportViewer()
		{
			InitializeComponent();
			// Set up CemDB to use the .udl file
			DBControl.ConnectionFile(Application.StartupPath + "\\newer_invoice.udl");

			// Initialize data sets and table
			dbInvoicesReport = new DBDataSet();
			dsInvoicesReport = new DataSet();
			tableInvoicesReport = new DataTable();

			// Stored procedure for report
			dbInvoicesReport.FetchStoredProcedure = "fetch_main_report";

			dbInvoicesReport.DataSet = dsInvoicesReport;

			// Save data into tableInvoicesReport
			dbInvoicesReport.FetchDataTable(tableInvoicesReport);

			// Connect report to report viewer
			this.compInvReportViewer.Reset();
			this.compInvReportViewer.LocalReport.ReportEmbeddedResource = "InvoicesApplicationCS_Raman.AllInvoicesReport.rdlc";
			this.compInvReportViewer.LocalReport.DataSources.Clear();
			this.compInvReportViewer.LocalReport.DataSources.Add( new Microsoft.Reporting.WinForms.ReportDataSource("mainReportDataSet", tableInvoicesReport));

		}

		private void TotalReportViewer_Load(object sender, EventArgs e)
		{

			this.compInvReportViewer.RefreshReport();
		}

		private void reportViewer1_Load(object sender, EventArgs e)
		{

		}
	}
}