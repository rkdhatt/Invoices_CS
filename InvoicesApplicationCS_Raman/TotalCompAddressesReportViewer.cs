using System;
using CemDB;
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
	// Report that displays all companies and their addresses
	public partial class TotalCompAddressesReportViewer : Form
	{
		DBDataSet dbAddressesReport;
		DataSet dsAddressesReport;
		DataTable tableAddressesReport;

		public TotalCompAddressesReportViewer()
		{
			this.InitializeComponent();

			// Set up CemDB to use the .udl file
			DBControl.ConnectionFile(Application.StartupPath + "\\newer_invoice.udl");

			// Initialize data sets and table
			this.dbAddressesReport = new DBDataSet();
			this.dsAddressesReport = new DataSet();
			this.tableAddressesReport = new DataTable();

			// Stored procedure for report
			this.dbAddressesReport.FetchStoredProcedure = "fetch_all_company_addresses_report";

			this.dbAddressesReport.DataSet = this.dsAddressesReport;

			// Save data into tableAddressesReport
			this.dbAddressesReport.FetchDataTable(this.tableAddressesReport);

			// Check if table has data
			if (this.tableAddressesReport.Rows.Count == 0)
			{
				MessageBox.Show("No data to display", "No Data", MessageBoxButtons.OK);
				this.compAddReportViewer.CancelRendering(100);
				this.Close();
			}
			else 
			{	// Connect report to report viewer
				this.compAddReportViewer.Reset();
				this.compAddReportViewer.LocalReport.ReportEmbeddedResource = "InvoicesApplicationCS_Raman.AllAddressesReport.rdlc";
				this.compAddReportViewer.LocalReport.DataSources.Clear();
				this.compAddReportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("allAddressesDataSet", this.tableAddressesReport));
			}
		}

		private void TotalCompAddressesReportViewer_Load(object sender, EventArgs e)
		{
			this.compAddReportViewer.RefreshReport();
		}

		private void compAddReportViewer_Load(object sender, EventArgs e)
		{
		}
	}
}