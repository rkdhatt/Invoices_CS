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
	public partial class InvoiceChartForm : Form
	{
		private DBDataSet dbInvoicesReport;
		private DataSet dsInvoicesReport;
		private DataTable tableInvoicesReport;

		public InvoiceChartForm()
		{
			InitializeComponent();

			// Set up CemDB to use the .udl file
			DBControl.ConnectionFile(Application.StartupPath + "\\newer_invoice.udl");

			// Initialize data set and table
			dbInvoicesReport = new DBDataSet();

			dsInvoicesReport = new DataSet();

			tableInvoicesReport = new DataTable();

			// Stored procedures for report
			dbInvoicesReport.FetchStoredProcedure = "fetch_invoice_costs_chart_two";

			dbInvoicesReport.DataSet = dsInvoicesReport;

			// Save data into tables
			dbInvoicesReport.FetchDataTable(tableInvoicesReport);

			// Connect report to report viewer
			this.invoiceChartReportViewer.Reset();
			this.invoiceChartReportViewer.LocalReport.ReportEmbeddedResource = "InvoicesApplicationCS_Raman.InvoicesChartReport.rdlc";
			this.invoiceChartReportViewer.LocalReport.DataSources.Clear();
			this.invoiceChartReportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("invoiceCostChartDataSet", tableInvoicesReport));
		}

		private void InvoiceChartForm_Load(object sender, EventArgs e)
		{

			this.invoiceChartReportViewer.RefreshReport();
		}
	}
}
