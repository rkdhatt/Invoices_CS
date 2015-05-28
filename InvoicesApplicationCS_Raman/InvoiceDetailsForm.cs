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
	public partial class InvoiceDetailsForm : Form
	{
		private DBDataSet dbDetails;
		private DataSet dsDetails;
		private DataTable tableDetails;
		DBView dbvDetails;

		private int invoice_id;


		public InvoiceDetailsForm(int invoiceID)
		{
			InitializeComponent();

			this.invoice_id = invoiceID;

			dbDetails = new DBDataSet();
			dsDetails = new DataSet();
			tableDetails = new DataTable("Details");
			dbvDetails = new DBView(detailsDataGridView, dbDetails);

			dbDetails.FetchStoredProcedure = "fetch_details_by_invoice_ID";
			dbDetails.InsertStoredProcedure = "insert_detail";
			dbDetails.UpdateStoredProcedure = "update_detail";
			dbDetails.DeleteStoredProcedure = "delete_detail";

			dbDetails.DataSet = dsDetails;

			dbDetails.BeforeFetch += dbDetails_BeforeFetch;
			dbDetails.BeforeInsert += dbDetails_BeforeInsert;
			dbDetails.AfterInsert += dbDetails_AfterInsert;

			// Format unit cost 

			detailsDataGridView.Columns["CostCol"].DefaultCellStyle.Format = "c";
			dbDetails.FetchDataTable(tableDetails);
			detailsDataGridView.AutoGenerateColumns = false;
			detailsDataGridView.DataSource = this.tableDetails;
		}

		void dbDetails_AfterInsert(object sender, System.Data.SqlClient.SqlCommand cmd, DataRow row, Cancel cancel)
		{
			dbDetails.FetchDataTable(tableDetails);
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
