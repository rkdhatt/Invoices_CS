namespace InvoicesApplicationCS_Raman
{
	partial class TotalCompAddressesReportViewer
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
			this.compAddReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
			this.SuspendLayout();
			// 
			// compAddReportViewer
			// 
			this.compAddReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.compAddReportViewer.Location = new System.Drawing.Point(0, 0);
			this.compAddReportViewer.Name = "compAddReportViewer";
			this.compAddReportViewer.Size = new System.Drawing.Size(795, 578);
			this.compAddReportViewer.TabIndex = 0;
			// 
			// TotalCompAddressesReportViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(795, 578);
			this.Controls.Add(this.compAddReportViewer);
			this.MinimumSize = new System.Drawing.Size(811, 547);
			this.Name = "TotalCompAddressesReportViewer";
			this.Text = "TotalCompAddressesReportViewer";
			this.Load += new System.EventHandler(this.TotalCompAddressesReportViewer_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer compAddReportViewer;
	}
}