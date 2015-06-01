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

		/// <summary>
		/// Initializes a new instance of the <see cref="SelectedCompanyInvoiceCostsChartForm"/> class.
		/// Selected Company Invoice Costs Chart Form constructor
		/// </summary>
		public SelectedCompanyInvoiceCostsChartForm()
		{
			// Set up CemDB to use the .udl file
			DBControl.ConnectionFile(Application.StartupPath + "\\newer_invoice.udl");

			// Initialize data set and table
			this.dbInvoicesReport = new DBDataSet();

			this.dsInvoicesReport = new DataSet();

			this.tableInvoicesReport = new DataTable();

			// Stored procedures for report
			this.dbInvoicesReport.FetchStoredProcedure = "fetch_invoice_costs_chart_by_compID";

			this.dbInvoicesReport.DataSet = this.dsInvoicesReport;

			// Save data into tables
			this.dbInvoicesReport.FetchDataTable(this.tableInvoicesReport);

			// Connect report to report viewer
			this.selectedCompInvoiceCostsReportViewer.Reset();
			this.selectedCompInvoiceCostsReportViewer.LocalReport.ReportEmbeddedResource = "InvoicesApplicationCS_Raman.InvoicesOverTimeChartReport.rdlc";
			this.selectedCompInvoiceCostsReportViewer.LocalReport.DataSources.Clear();
			this.selectedCompInvoiceCostsReportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("AllInvoiceCostChartDataSet", this.tableInvoicesReport));
		}

		private void SelectedCompanyInvoiceCostsChartForm_Load(object sender, EventArgs e)
		{

			this.selectedCompInvoiceCostsReportViewer.RefreshReport();
		}
	}
}
