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
	/// Shows data grid view for company invoices and company addresses.
	/// </summary>
	public partial class InvoicesAndAddressesForm : Form
	{
		private DBDataSet dbInvoices;
		private DBDataSet dbAddresses;

		private DataSet dsInvoices;
		private DataSet dsAddresses;

		private DataTable tableInvoices;
		private DataTable tableAddresses;

		private DBView dbvInvoices;
		private DBView dbvAddresses;

		private int companyID;

		/// <summary>
		/// Initializes a new instance of the <see cref="InvoicesAndAddressesForm"/> class.
		/// Invoices and Addresses Form constructor
		/// </summary>
		/// <param name="cID">Company ID</param>
		public InvoicesAndAddressesForm(int cID)
		{
			this.InitializeComponent();

			// Save company_id
			this.companyID = cID;

			// Set up CemDB to use the .udl file
			DBControl.ConnectionFile(Application.StartupPath + "\\newer_invoice.udl");

			// Initialize company data variables
			this.dbInvoices = new DBDataSet();
			this.dbAddresses = new DBDataSet();

			this.dsInvoices = new DataSet();
			this.dsAddresses = new DataSet();

			this.tableInvoices = new DataTable("Current Invoice");
			this.tableAddresses = new DataTable("Addresses");

			// Initialize DBViews
			this.dbvInvoices = new DBView(InvoiceDataGridView, this.dbInvoices);
			this.dbvAddresses = new DBView(AddressDataGridView, this.dbAddresses);

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
			this.dbInvoices.DataSet = this.dsInvoices;
			this.dbAddresses.DataSet = this.dsAddresses;

			// Ensure company_id parameter is passed to obtain corresponding invoices
			this.dbInvoices.BeforeFetch += this.DBInvoices_BeforeFetch;
			this.dbAddresses.BeforeFetch += this.DBAddresses_BeforeFetch;
			this.dbInvoices.BeforeInsert += this.DBInvoices_BeforeInsert;
			this.dbInvoices.AfterInsert += this.DBInvoices_AfterInsert;
			this.dbAddresses.AfterInsert += this.DBAddresses_AfterInsert;

			// Format Date column layout
			InvoiceDataGridView.Columns["InvoiceDateCol"].DefaultCellStyle.Format = "dd/MMM/yyyy";
			AddressDataGridView.Columns["DateModify"].DefaultCellStyle.Format = "dd/MMM/yyyy";
			InvoiceDataGridView.ShowCellToolTips = true;

			// Fetch data and save to corresponding tables
			this.dbInvoices.FetchDataTable(this.tableInvoices);
			this.dbAddresses.FetchDataTable(this.tableAddresses);
			AddressDataGridView.AutoGenerateColumns = false;
			InvoiceDataGridView.AutoGenerateColumns = false;

			// Bind data
			InvoiceDataGridView.DataSource = this.tableInvoices;
			AddressDataGridView.DataSource = this.tableAddresses;
		}

		// re-fetch addresses
		private void DBAddresses_AfterInsert(object sender, System.Data.SqlClient.SqlCommand cmd, DataRow row, Cancel cancel)
		{
			this.dbAddresses.FetchDataTable(this.tableAddresses);
		}

		// Re-fetch invoices
		private void DBInvoices_AfterInsert(object sender, System.Data.SqlClient.SqlCommand cmd, DataRow row, Cancel cancel)
		{
			this.dbInvoices.FetchDataTable(this.tableInvoices);
		}

		// Pass company_id for new invoice as a parameter to insert stored procedure
		private void DBInvoices_BeforeInsert(object sender, System.Data.SqlClient.SqlCommand cmd, DataRow row, Cancel cancel)
		{
			cmd.Parameters["@company_id"].Value = this.companyID;
		}

		// Fetch addresses based on specified company_id
		private void DBAddresses_BeforeFetch(object sender, System.Data.SqlClient.SqlCommand cmd, Cancel cancel)
		{
			cmd.Parameters["@company_id"].Value = this.companyID;
		}

		// Fetch invoices based on company_id
		private void DBInvoices_BeforeFetch(object sender, System.Data.SqlClient.SqlCommand cmd, Cancel cancel)
		{
			cmd.Parameters["@company_id"].Value = this.companyID;
		}

		private void InvoicesForm_Load(object sender, EventArgs e)
		{
		}

		// All addresses of a specific company should have the same company_id
		private void AddressDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
		{
			// For datagrid views for address, make sure default value for company_id is used, otherwise no updating happens
			e.Row.Cells["companyIDAddCol"].Value = this.companyID;
		}

		// All invoices of a specific company should have the same company_id
		private void InvoiceDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
		{
			e.Row.Cells["CompIDInvoiceCol"].Value = this.companyID;
		}

		// Double click on invoice to see more invoice details
		private void InvoiceDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int invoice_id = Convert.ToInt32(InvoiceDataGridView[0, e.RowIndex].FormattedValue);
			InvoiceDetailsForm frm_details = new InvoiceDetailsForm(invoice_id);
			frm_details.Show();
		}
	}
}