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
	// http://blog.csharplearners.com/category/metro-style-apps/
	// https://msdn.microsoft.com/en-us/library/vstudio/y8c0cxey%28v=vs.100%29.aspx
	public partial class MainForm : Form
	{
		private DBDataSet dbCompanies;
		private DBDataSet dbInvoices;
		private DBDataSet dbAddresses;
		private DBDataSet dbDetails;

		//private DataSet dsCompanies;
		//private DataSet dsInvoices;
		//private DataSet dsAddresses;
		//private DataSet dsDetails;

		private DataTable tableCompanies;
		private DataTable tableInvoices;
		private DataTable tableAddresses;
		private DataTable tableDetails;

		DBView dbvCompanies;
		//DBView dbvInvoices;
		DBView dbvAddresses;
		//DBView dbvDetails;

        DataGridView addressDataGridView = new DataGridView();

		public MainForm()
		{
			InitializeComponent();

			// Set up CemDB to use the .udl file
			DBControl.ConnectionFile(Application.StartupPath + "\\newer_invoice.udl");

			// initialize company data variables
			dbCompanies = new DBDataSet();
			dbInvoices = new DBDataSet();
			dbAddresses = new DBDataSet();
			dbDetails = new DBDataSet();

			tableCompanies = new DataTable();
			tableInvoices = new DataTable();
			tableAddresses = new DataTable();
			tableDetails = new DataTable();

			// Initialize stored procedures
			dbCompanies.FetchStoredProcedure = "fetch_companies";
			dbInvoices.FetchStoredProcedure = "fetch_invoices";
			dbAddresses.FetchStoredProcedure = "fetch_addresses";
			dbDetails.FetchStoredProcedure = "fetch_details";

			// Set Datasources
			compDataGridView.DataSource = tableCompanies;
			addressDataGridView.DataSource = tableAddresses;

			dbvCompanies = new DBView(compDataGridView, dbCompanies);
			dbvAddresses = new DBView(addressDataGridView, dbAddresses);

			// Fetch data and save to corresponding table 
			dbCompanies.FetchDataTable(tableCompanies);
			dbAddresses.FetchDataTable(tableAddresses);

			// Hide ID's
			compDataGridView.Columns[0].Visible = false;

			// Add master company and child address tables to dataset
			DataSet dsDataSet = new DataSet();
			dsDataSet.Tables.Add(tableCompanies);
			dsDataSet.Tables.Add(tableAddresses);

			// Define relationship between master and child tables
			DataRelation relation = new DataRelation("Company Addresses",
				dsDataSet.Tables[0].Columns[0], dsDataSet.Tables[1].Columns[0], true);
			dsDataSet.Relations.Add(relation);


		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			// resize master columns to fit newly loaded data
			//compDataGridView.AutoResizeColumns();

			// Child data grid view automatically adjust their widths when the data changes
			//addressDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
		}

		// Add new company using add company form
		private void addCompanyButton_Click(object sender, EventArgs e)
		{
			AddCompanyForm add_company = new AddCompanyForm();
			DialogResult result = add_company.ShowDialog(this);

			if (result == DialogResult.OK)
			{
				//dbCompanies.FetchDataSet();	
			}

		}
	}
}
