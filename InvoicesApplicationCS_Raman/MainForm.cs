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

	public partial class MainForm : Form
	{
		private DBDataSet dbCompanies;
		private DBDataSet dbAddresses;

		private DataSet dsCompanies;
		private DataSet dsAddresses;

		private DataTable tableCompanies;
		private DataTable tableAddresses;

		DataGridView addressDataGridView = new DataGridView();

		DBView dbvCompanies;

		public MainForm()
		{
			InitializeComponent();

			// Set up CemDB to use the .udl file
			DBControl.ConnectionFile(Application.StartupPath + "\\newer_invoice.udl");

			// initialize company data variables
			dbCompanies = new DBDataSet();
			dbAddresses = new DBDataSet();

			dsCompanies = new DataSet();
			dsAddresses = new DataSet();

			tableCompanies = new DataTable("Companies");
			tableAddresses = new DataTable("Addresses");

			// Must have DB Views to send inserts/updates/deletes to SQL Server
			dbvCompanies = new DBView(compDataGridView, dbCompanies);

			// Initialize stored procedures
			dbCompanies.FetchStoredProcedure = "fetch_companies";
			dbAddresses.FetchStoredProcedure = "fetch_addresses";

			dbCompanies.InsertStoredProcedure = "insert_company";
			dbAddresses.InsertStoredProcedure = "insert_address";

			// Set  to corresponding datasources
			dbCompanies.DataSet = dsCompanies;
			dbAddresses.DataSet = dsAddresses;

			// Fetch data and save to corresponding table 
			dbCompanies.FetchDataTable(tableCompanies);
			dbAddresses.FetchDataTable(tableAddresses);

			// Add master company and child address tables to dataset
			// DataSet dsDataSet = new DataSet();
			// dsDataSet.Tables.Add(this.tableCompanies);
			// dsDataSet.Tables.Add(this.tableAddresses);

			// Define relationship between master and child tables
			// dsDataSet.Relations.Add("Company Addresses",
			//		dsDataSet.Tables[0].Columns["company_id"],
			//		dsDataSet.Tables[1].Columns["company_id"], true);

			// Hide ID's
			// compDataGridView.Visible = false;
			// dsDataSet.Tables[0].Columns[0].ColumnMapping = MappingType.Hidden; // hide company_id in company table
			// dsDataSet.Tables[1].Columns[0].ColumnMapping = MappingType.Hidden; // hide company_id in address table
			// dsDataSet.Tables[1].Columns[1].ColumnMapping = MappingType.Hidden; // hide address_id in address table 

			// Bind data to main data grid

			// mainDataGrid.DataSource = dsDataSet.Tables[0];

			// Set Datasources
			compDataGridView.DataSource = this.tableCompanies;
			addressDataGridView.DataSource = this.tableAddresses;
			compDataGridView.AutoGenerateColumns = false;

			mainDataGrid.Visible = false;
			dbCompanies.BeforeInsert += dbCompanies_BeforeInsert;
		}

		void dbCompanies_BeforeInsert(object sender, System.Data.SqlClient.SqlCommand cmd, DataRow row, Cancel cancel)
		{
			System.Diagnostics.Debug.WriteLine("INSERT TEST");
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
		}


		private void mainDataGrid_Navigate(object sender, NavigateEventArgs ne)
		{

		}

		// Take user to invoices and invoice details - probably can't use it.... or can i?..
		private void mainDataGrid_MouseDoubleClick(object sender, MouseEventArgs e)
		{
		}


		private void compDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			string name = (string) compDataGridView[e.ColumnIndex, e.RowIndex].FormattedValue;
			int company_id = Convert.ToInt32(compDataGridView[0, e.RowIndex].FormattedValue);
			Console.WriteLine("Current name: {0}; column: {1}, row: {2}, company id: {3}", name, e.ColumnIndex, e.RowIndex, company_id);
			InvoicesForm frm_invoices = new InvoicesForm(company_id);
			frm_invoices.Show();
		}
	}
}