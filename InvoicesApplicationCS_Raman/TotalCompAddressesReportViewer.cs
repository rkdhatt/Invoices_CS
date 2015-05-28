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
	public partial class TotalCompAddressesReportViewer : Form
	{
		public TotalCompAddressesReportViewer()
		{
			InitializeComponent();
		}

		private void TotalCompAddressesReportViewer_Load(object sender, EventArgs e)
		{

			this.compAddReportViewer.RefreshReport();
		}
	}
}