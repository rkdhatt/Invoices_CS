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
			this.components = new System.ComponentModel.Container();
			this.StoredProceduresDataSet = new InvoicesApplicationCS_Raman.StoredProceduresDataSet();
			this.fetch_invoice_costs_chart_by_compIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.fetch_invoice_costs_chart_by_compIDTableAdapter = new InvoicesApplicationCS_Raman.StoredProceduresDataSetTableAdapters.fetch_invoice_costs_chart_by_compIDTableAdapter();
			this.selectedCompInvoiceCostsReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
			((System.ComponentModel.ISupportInitialize)(this.StoredProceduresDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fetch_invoice_costs_chart_by_compIDBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// StoredProceduresDataSet
			// 
			this.StoredProceduresDataSet.DataSetName = "StoredProceduresDataSet";
			this.StoredProceduresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// fetch_invoice_costs_chart_by_compIDBindingSource
			// 
			this.fetch_invoice_costs_chart_by_compIDBindingSource.DataMember = "fetch_invoice_costs_chart_by_compID";
			this.fetch_invoice_costs_chart_by_compIDBindingSource.DataSource = this.StoredProceduresDataSet;
			// 
			// fetch_invoice_costs_chart_by_compIDTableAdapter
			// 
			this.fetch_invoice_costs_chart_by_compIDTableAdapter.ClearBeforeFill = true;
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
			this.MinimumSize = new System.Drawing.Size(811, 547);
			this.Name = "SelectedCompanyInvoiceCostsChartForm";
			this.Text = "SelectedCompanyInvoiceCostsChartForm";
			this.Load += new System.EventHandler(this.SelectedCompanyInvoiceCostsChartForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.StoredProceduresDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fetch_invoice_costs_chart_by_compIDBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.BindingSource fetch_invoice_costs_chart_by_compIDBindingSource;
		private StoredProceduresDataSet StoredProceduresDataSet;
		private StoredProceduresDataSetTableAdapters.fetch_invoice_costs_chart_by_compIDTableAdapter fetch_invoice_costs_chart_by_compIDTableAdapter;
		private Microsoft.Reporting.WinForms.ReportViewer selectedCompInvoiceCostsReportViewer;
	}
}