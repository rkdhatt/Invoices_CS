namespace InvoicesApplicationCS_Raman
{
	partial class SelectedCompanyInvoiceCostsChartForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.selectedCompInvoiceCostsReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
			this.SuspendLayout();
			// 
			// selectedCompInvoiceCostsReportViewer
			// 
			this.selectedCompInvoiceCostsReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.selectedCompInvoiceCostsReportViewer.Location = new System.Drawing.Point(0, 0);
			this.selectedCompInvoiceCostsReportViewer.Name = "selectedCompInvoiceCostsReportViewer";
			this.selectedCompInvoiceCostsReportViewer.Size = new System.Drawing.Size(795, 509);
			this.selectedCompInvoiceCostsReportViewer.TabIndex = 0;
			// 
			// SelectedCompanyInvoiceCostsChartForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(795, 509);
			this.Controls.Add(this.selectedCompInvoiceCostsReportViewer);
			this.Name = "SelectedCompanyInvoiceCostsChartForm";
			this.Text = "SelectedCompanyInvoiceCostsChartForm";
			this.Load += new System.EventHandler(this.SelectedCompanyInvoiceCostsChartForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer selectedCompInvoiceCostsReportViewer;
	}
}