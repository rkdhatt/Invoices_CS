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
	public partial class InvoicesForm : Form
	{
		private DBDataSet dbInvoices;
		private DBDataSet dbDetails;
		private DBDataSet dbAddresses;

		private DataSet dsInvoices;
		private DataSet dsDetails;
		private DataSet dsAddresses;

		private DataTable tableInvoices;
		private DataTable tableDetails;
		private DataTable tableAddresses;

		DataGridView invoiceGridView;
		DataGridView detailGridView;
		DataGridView addressGridView;

		DBView dbvInvoices;
		DBView dbvDetails;
		DBView dbvAddresses;

		private int company_id;


		public InvoicesForm(int cID)
		{
			InitializeComponent();

			// Save company_id
			this.company_id = cID;

			// Set up CemDB to use the .udl file
			DBControl.ConnectionFile(Application.StartupPath + "\\newer_invoice.udl");

			// Initialize company data variables
			dbInvoices = new DBDataSet();
			dbDetails = new DBDataSet();
			dbAddresses = new DBDataSet();

			dsInvoices = new DataSet();
			dsDetails = new DataSet();
			dsAddresses = new DataSet();

			tableInvoices = new DataTable("Invoices");
			tableDetails = new DataTable("Details");
			tableAddresses = new DataTable("Addresses");

			// Initialize stored procedures
			dbInvoices.FetchStoredProcedure = "fetch_invoices_by_comp_ID";
			dbDetails.FetchStoredProcedure = "fetch_details";
			dbAddresses.FetchStoredProcedure = "fetch_addresses";

			// Initialize grid views to allow inserts/updates/deletes
			invoiceGridView = new DataGridView() { DataSource = tableInvoices };
			detailGridView = new DataGridView() { DataSource = tableDetails };
			addressGridView = new DataGridView() { DataSource = tableAddresses };

			// Set to corresponding datasources
			dbInvoices.DataSet = dsInvoices;
			dbDetails.DataSet = dsDetails;
			dbAddresses.DataSet = dsAddresses;

			// Ensure company_id parameter is passed to obtain corresponding invoices
			dbInvoices.BeforeFetch += dbInvoices_BeforeFetch;
			dbAddresses.BeforeFetch += dbAddresses_BeforeFetch;
			// Fetch data and save to corresponding tables
			dbInvoices.FetchDataTable(tableInvoices);
			dbDetails.FetchDataTable(tableDetails);
			dbAddresses.FetchDataTable(tableAddresses);

			dbvInvoices = new DBView(invoiceGridView, dbInvoices);
			dbvDetails = new DBView(detailGridView, dbDetails);
			dbvAddresses = new DBView(addressGridView, dbAddresses);

			// Add master and chil tables to dataset
			DataSet dsDataSet = new DataSet();
			dsDataSet.Tables.Add(this.tableInvoices);
			dsDataSet.Tables.Add(this.tableDetails);
			dsDataSet.Tables.Add(this.tableAddresses);

			// Define relationship between master and child tables
			dsDataSet.Relations.Add("Details of Invoice",
					dsDataSet.Tables[0].Columns["invoice_id"],
					dsDataSet.Tables[1].Columns["invoice_id"], false); // must be set to false: don't want to enforce relationship.

			// Hide ID's
			dsDataSet.Tables[0].Columns[0].ColumnMapping = MappingType.Hidden; // Hide invoice_id in invoices table
			dsDataSet.Tables[0].Columns[2].ColumnMapping = MappingType.Hidden; // Hide company_id in invoices table
			dsDataSet.Tables[1].Columns[0].ColumnMapping = MappingType.Hidden; // Hide invoice_id in details table
			dsDataSet.Tables[1].Columns[1].ColumnMapping = MappingType.Hidden; // Hide detail_id in details table

			// Bind data to invoiceDataGrid
			invoiceDataGrid.DataSource = dsDataSet.Tables[0];
			addressGridView.DataSource = dsDataSet.Tables[2];
			addressGridView.AutoGenerateColumns = false;

		}

		void dbAddresses_BeforeFetch(object sender, System.Data.SqlClient.SqlCommand cmd, Cancel cancel)
		{
			//cmd.Parameters["@company_id"].Value = this.company_id;
		}

		void dbInvoices_BeforeFetch(object sender, System.Data.SqlClient.SqlCommand cmd, Cancel cancel)
		{
			cmd.Parameters["@company_id"].Value = this.company_id;
		}


	}
}