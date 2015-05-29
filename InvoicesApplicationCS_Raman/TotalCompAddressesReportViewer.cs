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
	// Report that displays all companies and their addresses
	public partial class TotalCompAddressesReportViewer : Form
	{
		DBDataSet dbAddressesReport;
		DataSet dsAddressesReport;
		DataTable tableAddressesReport;

		public TotalCompAddressesReportViewer()
		{
			InitializeComponent();

			// Set up CemDB to use the .udl file
			DBControl.ConnectionFile(Application.StartupPath + "\\newer_invoice.udl");

			// Initialize data sets and table
			dbAddressesReport = new DBDataSet();
			dsAddressesReport = new DataSet();
			tableAddressesReport = new DataTable();

			// Stored procedure for report
			dbAddressesReport.FetchStoredProcedure = "fetch_all_company_addresses_report";

			dbAddressesReport.DataSet = dsAddressesReport;

			// Save data into tableAddressesReport
			dbAddressesReport.FetchDataTable(tableAddressesReport);

			// Connect report to report viewer
			this.compAddReportViewer.Reset();
			this.compAddReportViewer.LocalReport.ReportEmbeddedResource = "InvoicesApplicationCS_Raman.AllAddressesReport.rdlc";
			this.compAddReportViewer.LocalReport.DataSources.Clear();
			this.compAddReportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("allAddressesDataSet", tableAddressesReport));
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