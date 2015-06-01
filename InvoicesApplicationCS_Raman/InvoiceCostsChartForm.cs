using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CemDB;

namespace InvoicesApplicationCS_Raman
{
	[SuppressMessage("StyleCop.CSharp.NamingRules", "SA1305:FieldNamesMustNotUseHungarianNotation", Justification = "Reviewed.")]

	/// <summary>
	/// Invoice Chart for total invoice costs per company over time.
	/// </summary>
	public partial class InvoiceCostsChartForm : Form
	{
		private DBDataSet dbInvoicesReport;
		private DataSet dsInvoicesReport;
		private DataTable tableInvoicesReport;

		/// <summary>
		/// Initializes a new instance of the <see cref="InvoiceCostsChartForm"/> class.
		/// Invoice Chart Form constructor
		/// </summary>
		public InvoiceCostsChartForm()
		{
			this.InitializeComponent();

			// Set up CemDB to use the .udl file
			DBControl.ConnectionFile(Application.StartupPath + "\\newer_invoice.udl");

			// Initialize data set and table
			this.dbInvoicesReport = new DBDataSet();

			this.dsInvoicesReport = new DataSet();

			this.tableInvoicesReport = new DataTable();

			// Stored procedures for report
			this.dbInvoicesReport.FetchStoredProcedure = "fetch_invoice_costs_chart_two";

			this.dbInvoicesReport.DataSet = this.dsInvoicesReport;

			// Save data into tables
			this.dbInvoicesReport.FetchDataTable(this.tableInvoicesReport);

			// Connect report to report viewer
			this.invoiceChartReportViewer.Reset();
			this.invoiceChartReportViewer.LocalReport.ReportEmbeddedResource = "InvoicesApplicationCS_Raman.InvoicesOverTimeChartReport.rdlc";
			this.invoiceChartReportViewer.LocalReport.DataSources.Clear();
			this.invoiceChartReportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("AllInvoiceCostChartDataSet", this.tableInvoicesReport));
		}

		private void InvoiceChartForm_Load(object sender, EventArgs e)
		{
			this.invoiceChartReportViewer.RefreshReport();
		}
	}
}