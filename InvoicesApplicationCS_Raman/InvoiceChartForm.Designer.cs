namespace InvoicesApplicationCS_Raman
{
	partial class InvoiceChartForm
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
			this.invoiceChartReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
			this.SuspendLayout();
			// 
			// invoiceChartReportViewer
			// 
			this.invoiceChartReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.invoiceChartReportViewer.Location = new System.Drawing.Point(0, 0);
			this.invoiceChartReportViewer.Name = "invoiceChartReportViewer";
			this.invoiceChartReportViewer.Size = new System.Drawing.Size(610, 424);
			this.invoiceChartReportViewer.TabIndex = 0;
			// 
			// InvoiceChartForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(610, 424);
			this.Controls.Add(this.invoiceChartReportViewer);
			this.Name = "InvoiceChartForm";
			this.Text = "Total Invoice Costs Over Time Per Company";
			this.Load += new System.EventHandler(this.InvoiceChartForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer invoiceChartReportViewer;

	}
}