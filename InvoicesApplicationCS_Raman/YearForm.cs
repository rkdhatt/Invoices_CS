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
	/// Allows user to enter the year to see total 
	/// costs for that year for a specific company
	/// </summary>
	public partial class YearForm : Form
	{
		private int year;

		/// <summary>
		/// Initializes a new instance of the <see cref="YearForm"/> class.
		/// </summary>
		public YearForm()
		{
			this.InitializeComponent();
		}

		/// <summary>
		/// public method that returns the year
		/// </summary>
		/// <returns> year entered by user </returns>
		public int GetYear()
		{
			return this.year;
		}

		private void YearForm_Load(object sender, EventArgs e)
		{
			this.CancelButton = this.cancelButton;
		}

		// Checks if user entered appropriate year
		private void OKButton_Click(object sender, EventArgs e)
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

		private void CancelButton_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Hide();
		}
	}
}