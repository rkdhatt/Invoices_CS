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

		private DataSet dsInvoices;
		private DataSet dsDetails;

		private DataTable tableInvoices;
		private DataTable tableDetails;

		DataGridView invoiceGridView;
		DataGridView detailGridView;

		DBView dbvInvoices;
		DBView dbvDetails;

		public InvoicesForm(int company_id)
		{
			InitializeComponent();

			// Set up CemDB to use the .udl file
			DBControl.ConnectionFile(Application.StartupPath + "\\newer_invoice.udl");

			// Initialize company data variables
			dbInvoices = new DBDataSet();
			dbDetails = new DBDataSet();

			dsInvoices = new DataSet();
			dsDetails = new DataSet();

			tableInvoices = new DataTable("Invoices");
			tableDetails = new DataTable("Details");

			dbvInvoices = new DBView(invoiceGridView, dbInvoices);
			dbvDetails = new DBView(detailGridView, dbDetails);

			// Initialize stored procedures
			dbInvoices.FetchStoredProcedure = "fetch_invoices_by_comp_ID";
			dbDetails.FetchStoredProcedure = "fetch_details";

			invoiceGridView = new DataGridView() { DataSource = tableInvoices };
			detailGridView = new DataGridView() { DataSource = tableDetails };

			dbInvoices.FetchDataTable(tableInvoices);
			dbDetails.FetchDataTable(tableDetails);
			
			DataSet dsDataSet = new DataSet();
			dsDataSet.Tables.Add(this.tableInvoices);
			dsDataSet.Tables.Add(this.tableDetails);

			// Define relationship between master and child tables
			dsDataSet.Relations.Add("Details of Invoice",
					dsDataSet.Tables[0].Columns["invoice_id"],
					dsDataSet.Tables[1].Columns["invoice_id"], true);

			invoiceDataGrid.DataSource = dsDataSet.Tables[0];
		}


	}
}