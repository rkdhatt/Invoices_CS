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

	public partial class MainForm : Form
	{
		private DBDataSet dbCompanies;
		private DataSet dsCompanies;
		private DataTable tableCompanies;
		DBView dbvCompanies;

		public MainForm()
		{
			InitializeComponent();

			// Set up CemDB to use the .udl file
			DBControl.ConnectionFile(Application.StartupPath + "\\newer_invoice.udl");

			// Initialize company data variables
			dbCompanies = new DBDataSet();
			dsCompanies = new DataSet();
			tableCompanies = new DataTable("Companies");

			// Must have DB View to send inserts/updates/deletes to SQL Server
			dbvCompanies = new DBView(compDataGridView, dbCompanies);

			// Initialize stored procedures
			dbCompanies.FetchStoredProcedure = "fetch_companies";
			dbCompanies.InsertStoredProcedure = "insert_company";
			dbCompanies.UpdateStoredProcedure = "update_company";
			dbCompanies.DeleteStoredProcedure = "delete_company";

			// Set  to corresponding datasource
			dbCompanies.DataSet = dsCompanies;

			// Fetch data and save to corresponding table 
			dbCompanies.FetchDataTable(tableCompanies);

			// Set Datasources
			compDataGridView.DataSource = this.tableCompanies;
			compDataGridView.AutoGenerateColumns = false;

			dbCompanies.BeforeInsert += dbCompanies_BeforeInsert;
			dbCompanies.AfterInsert += dbCompanies_AfterInsert;
		}


		void dbCompanies_AfterInsert(object sender, System.Data.SqlClient.SqlCommand cmd, DataRow row, Cancel cancel)
		{
			dbCompanies.FetchDataTable(tableCompanies);
		}

		void dbCompanies_BeforeInsert(object sender, System.Data.SqlClient.SqlCommand cmd, DataRow row, Cancel cancel)
		{
			System.Diagnostics.Debug.WriteLine("INSERT TEST");
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
		}


		private void compDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			string name = (string) compDataGridView[e.ColumnIndex, e.RowIndex].FormattedValue;
			int company_id = Convert.ToInt32(compDataGridView[0, e.RowIndex].FormattedValue);
			Console.WriteLine("Current name: {0}; column: {1}, row: {2}, company id: {3}", name, e.ColumnIndex, e.RowIndex, company_id);
			InvoicesAndAddressesForm frm_invoices = new InvoicesAndAddressesForm(company_id);
			frm_invoices.Show();
		}


		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Do message box first, then exit.
			DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Invoices Application", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

			if (result == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void reportAllCompaniesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TotalReportViewer rptviewer = new TotalReportViewer();
			rptviewer.Show();
		}

		private void reportSelectedCompanyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SelectedCompanyReportViewerForm rptviewer = new SelectedCompanyReportViewerForm();
			//rptviewer.Show();
		}
	}
}