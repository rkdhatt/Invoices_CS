namespace InvoicesApplicationCS_Raman
{
	partial class TotalCompInvoicesReportViewer
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
			this.compInvReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
			this.SuspendLayout();
			// 
			// compInvReportViewer
			// 
			this.compInvReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.compInvReportViewer.Location = new System.Drawing.Point(0, 0);
			this.compInvReportViewer.Name = "compInvReportViewer";
			this.compInvReportViewer.Size = new System.Drawing.Size(664, 576);
			this.compInvReportViewer.TabIndex = 0;
			// 
			// TotalCompInvoicesReportViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(664, 576);
			this.Controls.Add(this.compInvReportViewer);
			this.MaximumSize = new System.Drawing.Size(680, 614);
			this.MinimumSize = new System.Drawing.Size(680, 614);
			this.Name = "TotalCompInvoicesReportViewer";
			this.Text = "Summary Report of Companies and their Invoices";
			this.Load += new System.EventHandler(this.TotalReportViewer_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer compInvReportViewer;
	}
}