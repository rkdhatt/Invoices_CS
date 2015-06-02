namespace InvoicesApplicationCS_Raman
{
	partial class SelectedCompanyReportViewer
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
			this.selectedCompReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
			this.SuspendLayout();
			// 
			// selectedCompReportViewer
			// 
			this.selectedCompReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.selectedCompReportViewer.Location = new System.Drawing.Point(0, 0);
			this.selectedCompReportViewer.Name = "selectedCompReportViewer";
			this.selectedCompReportViewer.Size = new System.Drawing.Size(795, 563);
			this.selectedCompReportViewer.TabIndex = 0;
			// 
			// SelectedCompanyReportViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(795, 563);
			this.Controls.Add(this.selectedCompReportViewer);
			this.MinimumSize = new System.Drawing.Size(811, 547);
			this.Name = "SelectedCompanyReportViewer";
			this.Text = "SelectedCompanyReportViewer";
			this.Load += new System.EventHandler(this.SelectedCompanyReportViewer_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer selectedCompReportViewer;
	}
}