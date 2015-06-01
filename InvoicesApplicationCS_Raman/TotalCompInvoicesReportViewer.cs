using System;
using CemDB;
using Microsoft.Reporting.WinForms;
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
	/// <summary>
	/// Report viewer displays all companies and their corresponding invoice terms and dates.
	/// </summary>
	public partial class TotalCompInvoicesReportViewer : Form
	{
		private DBDataSet dbInvoicesReport;
		private DataSet dsInvoicesReport;
		private DataTable tableInvoicesReport;

		public TotalCompInvoicesReportViewer()
		{
			this.InitializeComponent();

			// Set up CemDB to use the .udl file
			DBControl.ConnectionFile(Application.StartupPath + "\\newer_invoice.udl");

			// Initialize data sets and table
			this.dbInvoicesReport = new DBDataSet();
			this.dsInvoicesReport = new DataSet();
			this.tableInvoicesReport = new DataTable();

			// Stored procedure for report
			this.dbInvoicesReport.FetchStoredProcedure = "fetch_main_report";

			this.dbInvoicesReport.DataSet = this.dsInvoicesReport;

			// Save data into tableInvoicesReport
			this.dbInvoicesReport.FetchDataTable(this.tableInvoicesReport);

			// Check if table has data
			if (this.tableInvoicesReport.Rows.Count == 0)
			{
				MessageBox.Show("No data to display", "No Data", MessageBoxButtons.OK);
				this.compInvReportViewer.CancelRendering(100);
				this.Close();
			}

			// Connect report to report viewer
			this.compInvReportViewer.Reset();
			this.compInvReportViewer.LocalReport.ReportEmbeddedResource = "InvoicesApplicationCS_Raman.AllInvoicesReport.rdlc";
			this.compInvReportViewer.LocalReport.DataSources.Clear();
			this.compInvReportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("mainReportDataSet", this.tableInvoicesReport));

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