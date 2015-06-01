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
	/// Displays data grid view of invoice details
	/// </summary>
	public partial class InvoiceDetailsForm : Form
	{
		private DBDataSet dbDetails;
		private DataSet dsDetails;
		private DataTable tableDetails;
		private DBView dbvDetails;

		private int invoiceId;

		/// <summary>
		/// Initializes a new instance of the <see cref="InvoiceDetailsForm"/> class. 
		/// Invoice Details Form constructor
		/// </summary>
		/// <param name="iID">Invoice ID</param>
		public InvoiceDetailsForm(int iID)
		{
			this.InitializeComponent();

			this.invoiceId = iID;

			this.dbDetails = new DBDataSet();
			this.dsDetails = new DataSet();
			this.tableDetails = new DataTable("Details");
			this.dbvDetails = new DBView(DetailsDataGridView, this.dbDetails);

			this.dbDetails.FetchStoredProcedure = "fetch_details_by_invoice_ID";
			this.dbDetails.InsertStoredProcedure = "insert_detail";
			this.dbDetails.UpdateStoredProcedure = "update_detail";
			this.dbDetails.DeleteStoredProcedure = "delete_detail";

			this.dbDetails.DataSet = this.dsDetails;

			this.dbDetails.BeforeFetch += this.DBDetails_BeforeFetch;
			this.dbDetails.BeforeInsert += this.DBDetails_BeforeInsert;
			this.dbDetails.AfterInsert += this.DBDetails_AfterInsert;

			// Format unit cost 
			DetailsDataGridView.Columns["CostCol"].DefaultCellStyle.Format = "c";
			this.dbDetails.FetchDataTable(this.tableDetails);
			DetailsDataGridView.AutoGenerateColumns = false;
			DetailsDataGridView.DataSource = this.tableDetails;
		}

		private void DBDetails_AfterInsert(object sender, System.Data.SqlClient.SqlCommand cmd, DataRow row, Cancel cancel)
		{
			this.dbDetails.FetchDataTable(this.tableDetails);
		}

		private void DBDetails_BeforeFetch(object sender, System.Data.SqlClient.SqlCommand cmd, Cancel cancel)
		{
			cmd.Parameters["@invoice_id"].Value = this.invoiceId;
		}

		private void DBDetails_BeforeInsert(object sender, System.Data.SqlClient.SqlCommand cmd, DataRow row, Cancel cancel)
		{
			cmd.Parameters["@invoice_id"].Value = this.invoiceId;
		}

		private void DetailsDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
		{
			e.Row.Cells["InvoiceIDDetailCol"].Value = this.invoiceId;
		}
	}
}