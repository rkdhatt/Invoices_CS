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
	public partial class YearForm : Form
	{
		private int year;

		public YearForm()
		{
			this.InitializeComponent();
		}

		private void YearForm_Load(object sender, EventArgs e)
		{
			this.CancelButton = cancelButton;
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			try
			{
				this.year = Convert.ToInt32(yearTextBox.Text.Trim());
				if (this.year < 1900 || this.year > 2015)
				{
					MessageBox.Show("Must enter appropriate year.", "Year Entry Error", MessageBoxButtons.OK);
					return;
				}

				this.DialogResult = DialogResult.OK;
			}
			catch
			{
				MessageBox.Show("Must enter appropriate year.", "Year Entry Error", MessageBoxButtons.OK);
				return;
			}
		}

		public int getYear()
		{
			return this.year;
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Hide();
		}
	}
}
