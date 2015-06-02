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
	/// The main entry point for the application - view list of companies.
	/// </summary>
	public partial class MainForm : Form
	{
		private DBDataSet dbCompanies;
		private DataSet dsCompanies;
		private DataTable tableCompanies;
		private DBView dbvCompanies;

		/// <summary>
		/// Initializes a new instance of the <see cref="MainForm"/> class.
		/// Main Form constructor
		/// </summary>
		public MainForm()
		{
			this.InitializeComponent();

			// Set up CemDB to use the .udl file
			DBControl.ConnectionFile(Application.StartupPath + "\\newer_invoice.udl");

			// Initialize company data variables
			this.dbCompanies = new DBDataSet();
			this.dsCompanies = new DataSet();
			this.tableCompanies = new DataTable("Companies");

			// Must have DB View to send inserts/updates/deletes to SQL Server
			this.dbvCompanies = new DBView(CompDataGridView, this.dbCompanies);

			// Initialize stored procedures
			this.dbCompanies.FetchStoredProcedure = "fetch_companies";
			this.dbCompanies.InsertStoredProcedure = "insert_company";
			this.dbCompanies.UpdateStoredProcedure = "update_company";
			this.dbCompanies.DeleteStoredProcedure = "delete_company";

			// Set  to corresponding datasource
			this.dbCompanies.DataSet = this.dsCompanies;

			// Fetch data and save to corresponding table 
			this.dbCompanies.FetchDataTable(this.tableCompanies);

			// Set Datasources
			CompDataGridView.DataSource = this.tableCompanies;
			CompDataGridView.AutoGenerateColumns = false;
			this.dbCompanies.AfterInsert += this.DBCompanies_AfterInsert;
		}

		// Fetch latest data after insert
		private void DBCompanies_AfterInsert(object sender, System.Data.SqlClient.SqlCommand cmd, DataRow row, Cancel cancel)
		{
			this.dbCompanies.FetchDataTable(this.tableCompanies);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
		}

		// Double click on company name to see list of its invoices
		private void CompDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			string name = (string)CompDataGridView[e.ColumnIndex, e.RowIndex].FormattedValue;
			int company_id = Convert.ToInt32(CompDataGridView[0, e.RowIndex].FormattedValue);
			Console.WriteLine("Current name: {0}; column: {1}, row: {2}, company id: {3}", name, e.ColumnIndex, e.RowIndex, company_id);
			InvoicesAndAddressesForm frm_invoices = new InvoicesAndAddressesForm(company_id);
			frm_invoices.Show();
		}

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Ask if user wants to exit first
			DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Invoices Application", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
			if (result == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		// Shows report of all companies and their invoices
		private void ReportAllCompaniesWithInvoices_Click(object sender, EventArgs e)
		{
			TotalCompInvoicesReportViewer rptviewer = new TotalCompInvoicesReportViewer();
			if (!rptviewer.IsDisposed)
			{
				rptviewer.Show();
			}
		}

		// Shows report of all companies and their addresses
		private void ReportAllCompaniesWithAddresses_Click(object sender, EventArgs e)
		{
			TotalCompAddressesReportViewer rptviewer = new TotalCompAddressesReportViewer();
			if (!rptviewer.IsDisposed)
			{
				rptviewer.Show();
			}
		}

		// Show address and invoice info for a selected company
		private void SelectedCompanyInformation_Click(object sender, EventArgs e)
		{
			int column = CompDataGridView.CurrentCell.ColumnIndex;
			int row = CompDataGridView.CurrentCell.RowIndex;

			int company_id = Convert.ToInt32(CompDataGridView.CurrentCell.OwningRow.Cells[0].Value);
			SelectedCompanyReportViewer rptviewer = new SelectedCompanyReportViewer(company_id);
			if (!rptviewer.IsDisposed)
			{
				rptviewer.Show();
			}
		}

		// Show information about application
		private void AboutToolStripMenuClick(object sender, EventArgs e)
		{
			MessageBox.Show("Author: Raman Dhatt \nCreated: May 2015", "About", MessageBoxButtons.OK);
		}

		// Show overall invoice costs of all companies for all years
		private void InvoicesCostChart_Click(object sender, EventArgs e)
		{
			InvoiceCostsChartForm rptviewer = new InvoiceCostsChartForm();
			if (!rptviewer.IsDisposed)
			{
				rptviewer.Show();
			}
		}

		// Show invoice costs for a selected company for a given year
		private void selectedCompanyYearlyInvoiceCosts_Click(object sender, EventArgs e)
		{
			YearForm yearFrm = new YearForm();
			yearFrm.ShowDialog();
			DialogResult result = yearFrm.DialogResult;
			if (yearFrm.DialogResult == DialogResult.OK)
			{
				int year = yearFrm.getYear();
				int company_id = Convert.ToInt32(CompDataGridView.CurrentCell.OwningRow.Cells[0].Value);
				SelectedCompanyInvoiceCostsChartForm rptviewer = new SelectedCompanyInvoiceCostsChartForm(company_id, year);
				if (!rptviewer.IsDisposed)
				{
					rptviewer.Show();
				}
			}
		}
	}
}