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
	public partial class companyOverviewReportViewer : Form
	{
		private DBDataSet dbMainReport;
		private DataSet dsMainReport;
		private DataTable tableMainReport;


		public companyOverviewReportViewer()
		{
			InitializeComponent();
			// Set up CemDB to use the .udl file
			DBControl.ConnectionFile(Application.StartupPath + "\\newer_invoice.udl");

			dbMainReport = new DBDataSet();
			dsMainReport = new DataSet();
			tableMainReport = new DataTable();

			dbMainReport.FetchStoredProcedure = "fetch_main_report";

			dbMainReport.DataSet = dsMainReport;

			dbMainReport.FetchDataTable(tableMainReport);

			this.mainReportViewer.Reset();
			this.mainReportViewer.LocalReport.ReportEmbeddedResource = "InvoicesApplicationCS_Raman.MainReport.rdlc";
			this.mainReportViewer.LocalReport.DataSources.Clear();
			this.mainReportViewer.LocalReport.DataSources.Add( new Microsoft.Reporting.WinForms.ReportDataSource("mainReportDataSet", tableMainReport));

		}

		private void TotalReportViewer_Load(object sender, EventArgs e)
		{

			this.mainReportViewer.RefreshReport();
		}

		private void reportViewer1_Load(object sender, EventArgs e)
		{

		}
	}
}
