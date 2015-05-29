namespace InvoicesApplicationCS_Raman
{
	partial class InvoiceDetailsForm
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
			this.detailsDataGridView = new System.Windows.Forms.DataGridView();
			this.InvoiceIDDetailCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DetailIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DescriptionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.QuantityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CostCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.detailsDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// detailsDataGridView
			// 
			this.detailsDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
			this.detailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.detailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceIDDetailCol,
            this.DetailIDCol,
            this.DescriptionCol,
            this.QuantityCol,
            this.CostCol});
			this.detailsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.detailsDataGridView.Location = new System.Drawing.Point(0, 0);
			this.detailsDataGridView.Name = "detailsDataGridView";
			this.detailsDataGridView.Size = new System.Drawing.Size(545, 201);
			this.detailsDataGridView.TabIndex = 0;
			this.detailsDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.detailsDataGridView_DefaultValuesNeeded);
			// 
			// InvoiceIDDetailCol
			// 
			this.InvoiceIDDetailCol.DataPropertyName = "invoice_id";
			this.InvoiceIDDetailCol.HeaderText = "Invoice ID";
			this.InvoiceIDDetailCol.Name = "InvoiceIDDetailCol";
			this.InvoiceIDDetailCol.Visible = false;
			// 
			// DetailIDCol
			// 
			this.DetailIDCol.DataPropertyName = "detail_id";
			this.DetailIDCol.HeaderText = "Detail ID";
			this.DetailIDCol.Name = "DetailIDCol";
			this.DetailIDCol.Visible = false;
			// 
			// DescriptionCol
			// 
			this.DescriptionCol.DataPropertyName = "description";
			this.DescriptionCol.HeaderText = "Description";
			this.DescriptionCol.Name = "DescriptionCol";
			// 
			// QuantityCol
			// 
			this.QuantityCol.DataPropertyName = "quantity";
			this.QuantityCol.HeaderText = "Quantity";
			this.QuantityCol.Name = "QuantityCol";
			// 
			// CostCol
			// 
			this.CostCol.DataPropertyName = "cost";
			this.CostCol.HeaderText = "Unit Cost";
			this.CostCol.Name = "CostCol";
			// 
			// InvoiceDetailsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(545, 201);
			this.Controls.Add(this.detailsDataGridView);
			this.MaximumSize = new System.Drawing.Size(561, 239);
			this.MinimumSize = new System.Drawing.Size(561, 239);
			this.Name = "InvoiceDetailsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Invoice Details";
			((System.ComponentModel.ISupportInitialize)(this.detailsDataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView detailsDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceIDDetailCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn DetailIDCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn QuantityCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn CostCol;
	}
}