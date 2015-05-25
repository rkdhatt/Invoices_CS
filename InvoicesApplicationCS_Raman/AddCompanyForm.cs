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
	public partial class AddCompanyForm : Form
	{


		public AddCompanyForm()
		{
			InitializeComponent();
		}

		private void AddCompanyForm_Load(object sender, EventArgs e)
		{
			this.CancelButton = addCompanyCancelButton;
		}

		private void addCompanyOKButton_Click(object sender, EventArgs e)
		{
			if (addCompanyTextBox.Text.Trim().Length == 0)
			{
				MessageBox.Show("Cannot enter blank company name.", "Company Name Error", MessageBoxButtons.OK);
				return;
			}
				
			//Create sql to add new company
			System.Data.SqlClient.SqlCommand cmd = DBControl.GetStoredProcCmd("add_company");

			//Grab name from addCompanyTextBox to be added and execute add_company stored procedure
			cmd.Parameters["@name"].Value = addCompanyTextBox.Text;
			DBControl.ExecuteCommand(cmd);

			// Set result = OK and return
			this.DialogResult = DialogResult.OK;

		}

		private void addCompanyCancelButton_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Hide();
		}

	}
}
