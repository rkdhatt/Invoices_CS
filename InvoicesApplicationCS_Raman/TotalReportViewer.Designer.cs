﻿namespace InvoicesApplicationCS_Raman
{
	partial class TotalReportViewer
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
			this.mainReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
			this.SuspendLayout();
			// 
			// mainReportViewer
			// 
			this.mainReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainReportViewer.Location = new System.Drawing.Point(0, 0);
			this.mainReportViewer.Name = "mainReportViewer";
			this.mainReportViewer.Size = new System.Drawing.Size(541, 543);
			this.mainReportViewer.TabIndex = 0;
			this.mainReportViewer.Load += new System.EventHandler(this.reportViewer1_Load);
			// 
			// TotalReportViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(541, 543);
			this.Controls.Add(this.mainReportViewer);
			this.Name = "TotalReportViewer";
			this.Text = "TotalReportViewer";
			this.Load += new System.EventHandler(this.TotalReportViewer_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer mainReportViewer;
	}
}