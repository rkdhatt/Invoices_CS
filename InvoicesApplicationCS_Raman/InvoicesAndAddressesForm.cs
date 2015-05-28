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
	// Note to self: DataGrids suck!
	public partial class InvoicesAndAddressesForm : Form
	{
		private DBDataSet dbInvoices;
		private DBDataSet dbAddresses;

		private DataSet dsInvoices;
		private DataSet dsAddresses;

		private DataTable tableInvoices;
		private DataTable tableAddresses;

		DBView dbvInvoices;
		DBView dbvAddresses;

		private int company_id;


		public InvoicesAndAddressesForm(int cID)
		{
			InitializeComponent();

			// Save company_id
			this.company_id = cID;

			// Set up CemDB to use the .udl file
			DBControl.ConnectionFile(Application.StartupPath + "\\newer_invoice.udl");

			// Initialize company data variables
			dbInvoices = new DBDataSet();
			dbAddresses = new DBDataSet();

			dsInvoices = new DataSet();
			dsAddresses = new DataSet();

			tableInvoices = new DataTable("Current Invoice");
			tableAddresses = new DataTable("Addresses");

			// Initialize DBViews
			dbvInvoices = new DBView(invoiceDataGridView, dbInvoices);
			dbvAddresses = new DBView(addressDataGridView, dbAddresses);

			// Initialize stored procedures
			this.dbInvoices.FetchStoredProcedure = "fetch_invoices_by_comp_ID";
			this.dbInvoices.InsertStoredProcedure = "insert_invoice";
			this.dbInvoices.UpdateStoredProcedure = "update_invoice";
			this.dbInvoices.DeleteStoredProcedure = "delete_invoice";

			this.dbAddresses.FetchStoredProcedure = "fetch_addresses_by_comp_ID";
			this.dbAddresses.InsertStoredProcedure = "insert_address";
			this.dbAddresses.UpdateStoredProcedure = "update_address";
			this.dbAddresses.DeleteStoredProcedure = "delete_address";

			// Set to corresponding datasources
			this.dbInvoices.DataSet = dsInvoices;
			this.dbAddresses.DataSet = dsAddresses;

			// Ensure company_id parameter is passed to obtain corresponding invoices
			this.dbInvoices.BeforeFetch += dbInvoices_BeforeFetch;
			this.dbAddresses.BeforeFetch += dbAddresses_BeforeFetch;
			this.dbInvoices.BeforeInsert += dbInvoices_BeforeInsert;
			this.dbInvoices.AfterInsert += dbInvoices_AfterInsert;
			this.dbAddresses.AfterInsert += dbAddresses_AfterInsert;

			// Format Date column
			invoiceDataGridView.Columns["InvoiceDateCol"].DefaultCellStyle.Format = "dd/MMM/yyyy";
			addressDataGridView.Columns["DateModify"].DefaultCellStyle.Format = "dd/MMM/yyyy";
			// Fetch data and save to corresponding tables
			dbInvoices.FetchDataTable(tableInvoices);
			dbAddresses.FetchDataTable(tableAddresses);

			// Add master and child tables to dataset
			// DataSet dsDataSet = new DataSet();
			// dsDataSet.Tables.Add(this.tableInvoices);
			// dsDataSet.Tables.Add(this.tableDetails);

			// Hide ID's
			addressDataGridView.AutoGenerateColumns = false;
			invoiceDataGridView.AutoGenerateColumns = false;
			// dsDataSet.Tables[0].Columns[0].ColumnMapping = MappingType.Hidden; // Hide invoice_id in invoices table
			// dsDataSet.Tables[0].Columns[2].ColumnMapping = MappingType.Hidden; // Hide company_id in invoices table
			// dsDataSet.Tables[1].Columns[0].ColumnMapping = MappingType.Hidden; // Hide invoice_id in details table
			// dsDataSet.Tables[1].Columns[1].ColumnMapping = MappingType.Hidden; // Hide detail_id in details table

			// Modify Column Names in invoices data grid
			// dsDataSet.Tables[0].Columns[1].ColumnName = "Date";
			// dsDataSet.Tables[0].Columns[3].ColumnName = "Terms Of Invoice";
			// dsDataSet.Tables[1].Columns[2].ColumnName = "Description";
			// dsDataSet.Tables[1].Columns[3].ColumnName = "Quantity";
			// dsDataSet.Tables[1].Columns[4].ColumnName = "Unit Cost";

			// Bind data
			// invoiceDataGrid.DataSource = dsDataSet.Tables[0];
			invoiceDataGridView.DataSource = this.tableInvoices;
			addressDataGridView.DataSource = this.tableAddresses;

			// Define relationship between master and child tables
			// dsDataSet.Relations.Add("More Invoice Details",
			//		dsDataSet.Tables[0].Columns["invoice_id"],
			//		dsDataSet.Tables[1].Columns["invoice_id"], false); // must be set to false: don't want to enforce relationship.



		}

		void dbAddresses_AfterInsert(object sender, System.Data.SqlClient.SqlCommand cmd, DataRow row, Cancel cancel)
		{
			dbAddresses.FetchDataTable(tableAddresses);
		}

		void dbInvoices_AfterInsert(object sender, System.Data.SqlClient.SqlCommand cmd, DataRow row, Cancel cancel)
		{
			dbInvoices.FetchDataTable(tableInvoices);
		}

		void dbInvoices_BeforeInsert(object sender, System.Data.SqlClient.SqlCommand cmd, DataRow row, Cancel cancel)
		{
			cmd.Parameters["@company_id"].Value = this.company_id;
		}

		void dbAddresses_BeforeFetch(object sender, System.Data.SqlClient.SqlCommand cmd, Cancel cancel)
		{
			cmd.Parameters["@company_id"].Value = this.company_id;
		}

		void dbInvoices_BeforeFetch(object sender, System.Data.SqlClient.SqlCommand cmd, Cancel cancel)
		{
			cmd.Parameters["@company_id"].Value = this.company_id;
		}

		private void InvoicesForm_Load(object sender, EventArgs e)
		{

		}

		private void addressDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
		{
			// For datagrid views for address, make sure default value for company_id is used, otherwise no updating happens
			e.Row.Cells["companyIDAddCol"].Value = this.company_id;
		}

		private void invoiceDataGrid_Navigate(object sender, NavigateEventArgs ne)
		{

		}

		private void invoiceDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
		{
			e.Row.Cells["CompIDInvoiceCol"].Value = this.company_id;
		}

		private void invoiceDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int invoice_id = Convert.ToInt32(invoiceDataGridView[0, e.RowIndex].FormattedValue);
			Console.WriteLine("Invoice Column: {0}, row: {1}, invoice id: {2}", e.ColumnIndex, e.RowIndex, invoice_id);
			InvoiceDetailsForm frm_details = new InvoiceDetailsForm(invoice_id);
			frm_details.Show();
		}

	}
}