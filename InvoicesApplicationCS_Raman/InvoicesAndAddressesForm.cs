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
	/// <summary>
	/// Shows datagridview for company invoices and company addresses.
	/// </summary>
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
			this.InitializeComponent();

			// Save company_id
			this.company_id = cID;

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
			this.dbvInvoices = new DBView(invoiceDataGridView, this.dbInvoices);
			this.dbvAddresses = new DBView(addressDataGridView, this.dbAddresses);

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
			this.dbInvoices.BeforeFetch += this.dbInvoices_BeforeFetch;
			this.dbAddresses.BeforeFetch += this.dbAddresses_BeforeFetch;
			this.dbInvoices.BeforeInsert += this.dbInvoices_BeforeInsert;
			this.dbInvoices.AfterInsert += this.dbInvoices_AfterInsert;
			this.dbAddresses.AfterInsert += this.dbAddresses_AfterInsert;

			// Format Date column layout
			invoiceDataGridView.Columns["InvoiceDateCol"].DefaultCellStyle.Format = "dd/MMM/yyyy";
			addressDataGridView.Columns["DateModify"].DefaultCellStyle.Format = "dd/MMM/yyyy";

			// Fetch data and save to corresponding tables
			this.dbInvoices.FetchDataTable(this.tableInvoices);
			this.dbAddresses.FetchDataTable(this.tableAddresses);
			addressDataGridView.AutoGenerateColumns = false;
			invoiceDataGridView.AutoGenerateColumns = false;

			// Bind data
			invoiceDataGridView.DataSource = this.tableInvoices;
			addressDataGridView.DataSource = this.tableAddresses;

		}

		// re-fetch addresses
		void dbAddresses_AfterInsert(object sender, System.Data.SqlClient.SqlCommand cmd, DataRow row, Cancel cancel)
		{
			this.dbAddresses.FetchDataTable(this.tableAddresses);
		}

		// Re-fetch invoices
		void dbInvoices_AfterInsert(object sender, System.Data.SqlClient.SqlCommand cmd, DataRow row, Cancel cancel)
		{
			this.dbInvoices.FetchDataTable(this.tableInvoices);
		}

		// Pass company_id for new invoice as a parameter to insert stored procedure
		void dbInvoices_BeforeInsert(object sender, System.Data.SqlClient.SqlCommand cmd, DataRow row, Cancel cancel)
		{
			cmd.Parameters["@company_id"].Value = this.company_id;
		}

		// Fetch addresses based on specified company_id
		void dbAddresses_BeforeFetch(object sender, System.Data.SqlClient.SqlCommand cmd, Cancel cancel)
		{
			cmd.Parameters["@company_id"].Value = this.company_id;
		}

		// Fetch invoices based on company_id
		void dbInvoices_BeforeFetch(object sender, System.Data.SqlClient.SqlCommand cmd, Cancel cancel)
		{
			cmd.Parameters["@company_id"].Value = this.company_id;
		}

		private void InvoicesForm_Load(object sender, EventArgs e)
		{
		}

		// All addresses of a specific company should have the same company_id
		private void addressDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
		{
			// For datagrid views for address, make sure default value for company_id is used, otherwise no updating happens
			e.Row.Cells["companyIDAddCol"].Value = this.company_id;
		}

		// All invoices of a specific company should have the same company_id
		private void invoiceDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
		{
			e.Row.Cells["CompIDInvoiceCol"].Value = this.company_id;
		}

		// Double click on invoice to see more invoice details
		private void invoiceDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int invoice_id = Convert.ToInt32(invoiceDataGridView[0, e.RowIndex].FormattedValue);
			InvoiceDetailsForm frm_details = new InvoiceDetailsForm(invoice_id);
			frm_details.Show();
		}

	}
}