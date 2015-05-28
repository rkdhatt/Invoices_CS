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
		private DBDataSet dbMainReport;
		private DataSet dsMainReport;
		private DataTable tableMainReport;


		public TotalCompInvoicesReportViewer()
		{
			InitializeComponent();
			// Set up CemDB to use the .udl file
			DBControl.ConnectionFile(Application.StartupPath + "\\newer_invoice.udl");

			// Initialize data sets and table
			dbMainReport = new DBDataSet();
			dsMainReport = new DataSet();
			tableMainReport = new DataTable();

			// Stored procedure for report
			dbMainReport.FetchStoredProcedure = "fetch_main_report";

			dbMainReport.DataSet = dsMainReport;

			dbMainReport.FetchDataTable(tableMainReport);

			// Connect report to report viewer
			this.compInvReportViewer.Reset();
			this.compInvReportViewer.LocalReport.ReportEmbeddedResource = "InvoicesApplicationCS_Raman.MainReport.rdlc";
			this.compInvReportViewer.LocalReport.DataSources.Clear();
			this.compInvReportViewer.LocalReport.DataSources.Add( new Microsoft.Reporting.WinForms.ReportDataSource("mainReportDataSet", tableMainReport));

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