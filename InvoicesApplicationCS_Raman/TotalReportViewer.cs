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
	public partial class TotalReportViewer : Form
	{
		public TotalReportViewer()
		{
			InitializeComponent();
		}

		private void TotalReportViewer_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'invoices_ramanDataSet.details' table. You can move, or remove it, as needed.
			this.detailsTableAdapter.Fill(this.invoices_ramanDataSet.details);

			this.reportViewer1.RefreshReport();
		}
	}
}
