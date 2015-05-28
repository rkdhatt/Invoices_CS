namespace InvoicesApplicationCS_Raman
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
			this.components = new System.ComponentModel.Container();
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.invoices_ramanDataSet = new InvoicesApplicationCS_Raman.invoices_ramanDataSet();
			this.detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.detailsTableAdapter = new InvoicesApplicationCS_Raman.invoices_ramanDataSetTableAdapters.detailsTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.invoices_ramanDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// reportViewer1
			// 
			this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			reportDataSource1.Name = "DataSet1";
			reportDataSource1.Value = this.detailsBindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "InvoicesApplicationCS_Raman.TotalReport.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(0, 0);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.Size = new System.Drawing.Size(658, 441);
			this.reportViewer1.TabIndex = 0;
			// 
			// invoices_ramanDataSet
			// 
			this.invoices_ramanDataSet.DataSetName = "invoices_ramanDataSet";
			this.invoices_ramanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// detailsBindingSource
			// 
			this.detailsBindingSource.DataMember = "details";
			this.detailsBindingSource.DataSource = this.invoices_ramanDataSet;
			// 
			// detailsTableAdapter
			// 
			this.detailsTableAdapter.ClearBeforeFill = true;
			// 
			// TotalReportViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(658, 441);
			this.Controls.Add(this.reportViewer1);
			this.Name = "TotalReportViewer";
			this.Text = "TotalReportViewer";
			this.Load += new System.EventHandler(this.TotalReportViewer_Load);
			((System.ComponentModel.ISupportInitialize)(this.invoices_ramanDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.BindingSource detailsBindingSource;
		private invoices_ramanDataSet invoices_ramanDataSet;
		private invoices_ramanDataSetTableAdapters.detailsTableAdapter detailsTableAdapter;
	}
}