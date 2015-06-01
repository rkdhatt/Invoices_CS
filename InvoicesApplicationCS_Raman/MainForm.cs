﻿using System;
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
		DBView dbvCompanies;

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
			this.dbvCompanies = new DBView(compDataGridView, this.dbCompanies);

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
			compDataGridView.DataSource = this.tableCompanies;
			compDataGridView.AutoGenerateColumns = false;
			this.dbCompanies.AfterInsert += this.dbCompanies_AfterInsert;
		}

		// Fetch latest data after insert
		void dbCompanies_AfterInsert(object sender, System.Data.SqlClient.SqlCommand cmd, DataRow row, Cancel cancel)
		{
			this.dbCompanies.FetchDataTable(this.tableCompanies);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
		}

		// Double click on company name to see list of its invoices
		private void compDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			string name = (string)compDataGridView[e.ColumnIndex, e.RowIndex].FormattedValue;
			int company_id = Convert.ToInt32(compDataGridView[0, e.RowIndex].FormattedValue);
			Console.WriteLine("Current name: {0}; column: {1}, row: {2}, company id: {3}", name, e.ColumnIndex, e.RowIndex, company_id);
			InvoicesAndAddressesForm frm_invoices = new InvoicesAndAddressesForm(company_id);
			frm_invoices.Show();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Ask if user wants to exit first
			DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Invoices Application", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
			if (result == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		// Shows report of all companies and their invoices
		private void reportAllCompaniesWithInvoices_Click(object sender, EventArgs e)
		{
			TotalCompInvoicesReportViewer rptviewer = new TotalCompInvoicesReportViewer();
			if (!rptviewer.IsDisposed)
			{
				rptviewer.Show();
			}
		}

		// Shows report of all companies and their addresses
		private void reportSelectedCompanyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TotalCompAddressesReportViewer rptviewer = new TotalCompAddressesReportViewer();
			if (!rptviewer.IsDisposed)
			{
				rptviewer.Show();
			}
		}

		private void selectedCompanyInformationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int column = compDataGridView.CurrentCell.ColumnIndex;
			int row = compDataGridView.CurrentCell.RowIndex;

			int company_id = Convert.ToInt32(compDataGridView.CurrentCell.OwningRow.Cells[0].Value);
			SelectedCompanyReportViewer rptviewer = new SelectedCompanyReportViewer(company_id);
			if (!rptviewer.IsDisposed)
			{
				rptviewer.Show();
			}
		}

		private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			MessageBox.Show("Author: Raman Dhatt \nCreated: May 2015", "About", MessageBoxButtons.OK);
		}

		private void invoicesCostChart_Click(object sender, EventArgs e)
		{
			InvoiceChartForm rptviewer = new InvoiceChartForm();
			if (!rptviewer.IsDisposed)
			{
				rptviewer.Show();
			}
		}
	}
}