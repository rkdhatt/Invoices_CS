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
	/// Displays datagridview of invoice details
	/// </summary>
	public partial class InvoiceDetailsForm : Form
	{
		private DBDataSet dbDetails;
		private DataSet dsDetails;
		private DataTable tableDetails;
		DBView dbvDetails;

		private int invoice_id;

		public InvoiceDetailsForm(int invoiceID)
		{
			this.InitializeComponent();

			this.invoice_id = invoiceID;

			this.dbDetails = new DBDataSet();
			this.dsDetails = new DataSet();
			this.tableDetails = new DataTable("Details");
			this.dbvDetails = new DBView(detailsDataGridView, this.dbDetails);

			this.dbDetails.FetchStoredProcedure = "fetch_details_by_invoice_ID";
			this.dbDetails.InsertStoredProcedure = "insert_detail";
			this.dbDetails.UpdateStoredProcedure = "update_detail";
			this.dbDetails.DeleteStoredProcedure = "delete_detail";

			this.dbDetails.DataSet = this.dsDetails;

			this.dbDetails.BeforeFetch += this.dbDetails_BeforeFetch;
			this.dbDetails.BeforeInsert += this.dbDetails_BeforeInsert;
			this.dbDetails.AfterInsert += this.dbDetails_AfterInsert;

			// Format unit cost 
			detailsDataGridView.Columns["CostCol"].DefaultCellStyle.Format = "c";
			this.dbDetails.FetchDataTable(this.tableDetails);
			detailsDataGridView.AutoGenerateColumns = false;
			detailsDataGridView.DataSource = this.tableDetails;
		}

		void dbDetails_AfterInsert(object sender, System.Data.SqlClient.SqlCommand cmd, DataRow row, Cancel cancel)
		{
			this.dbDetails.FetchDataTable(this.tableDetails);
		}

		void dbDetails_BeforeFetch(object sender, System.Data.SqlClient.SqlCommand cmd, Cancel cancel)
		{
			cmd.Parameters["@invoice_id"].Value = this.invoice_id;
		}

		void dbDetails_BeforeInsert(object sender, System.Data.SqlClient.SqlCommand cmd, DataRow row, Cancel cancel)
		{
			cmd.Parameters["@invoice_id"].Value = this.invoice_id;
		}

		private void detailsDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
		{
			e.Row.Cells["InvoiceIDDetailCol"].Value = this.invoice_id;
		}
	}
}