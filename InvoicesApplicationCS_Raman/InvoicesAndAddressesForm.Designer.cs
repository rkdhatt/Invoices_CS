﻿namespace InvoicesApplicationCS_Raman
{
	partial class InvoicesAndAddressesForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.invoiceDataGridView = new System.Windows.Forms.DataGridView();
			this.InvoiceIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.InvoiceDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CompIDInvoiceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TermsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.invoiceDataGrid = new System.Windows.Forms.DataGrid();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.addressDataGridView = new System.Windows.Forms.DataGridView();
			this.companyIDAddCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AddressID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Addresses = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DateModify = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.invoiceInfoLabel = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.invoiceDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.invoiceDataGrid)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.addressDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 31);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(476, 224);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.invoiceDataGridView);
			this.tabPage1.Controls.Add(this.invoiceDataGrid);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(468, 198);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Company Invoices";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// invoiceDataGridView
			// 
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.invoiceDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
			this.invoiceDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
			this.invoiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.invoiceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceIDCol,
            this.InvoiceDateCol,
            this.CompIDInvoiceCol,
            this.TermsCol});
			this.invoiceDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.invoiceDataGridView.Location = new System.Drawing.Point(3, 3);
			this.invoiceDataGridView.Name = "invoiceDataGridView";
			this.invoiceDataGridView.Size = new System.Drawing.Size(462, 192);
			this.invoiceDataGridView.TabIndex = 2;
			this.invoiceDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoiceDataGridView_CellDoubleClick);
			this.invoiceDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.invoiceDataGridView_DefaultValuesNeeded);
			// 
			// InvoiceIDCol
			// 
			this.InvoiceIDCol.DataPropertyName = "invoice_id";
			this.InvoiceIDCol.HeaderText = "Invoice ID";
			this.InvoiceIDCol.Name = "InvoiceIDCol";
			this.InvoiceIDCol.Visible = false;
			// 
			// InvoiceDateCol
			// 
			this.InvoiceDateCol.DataPropertyName = "date";
			this.InvoiceDateCol.HeaderText = "Invoice Date";
			this.InvoiceDateCol.Name = "InvoiceDateCol";
			// 
			// CompIDInvoiceCol
			// 
			this.CompIDInvoiceCol.DataPropertyName = "company_id";
			this.CompIDInvoiceCol.HeaderText = "Company ID";
			this.CompIDInvoiceCol.Name = "CompIDInvoiceCol";
			this.CompIDInvoiceCol.Visible = false;
			// 
			// TermsCol
			// 
			this.TermsCol.DataPropertyName = "terms";
			this.TermsCol.HeaderText = "Terms";
			this.TermsCol.Name = "TermsCol";
			// 
			// invoiceDataGrid
			// 
			this.invoiceDataGrid.AlternatingBackColor = System.Drawing.SystemColors.InactiveCaption;
			this.invoiceDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
			this.invoiceDataGrid.CaptionBackColor = System.Drawing.SystemColors.Control;
			this.invoiceDataGrid.DataMember = "";
			this.invoiceDataGrid.GridLineColor = System.Drawing.SystemColors.AppWorkspace;
			this.invoiceDataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.invoiceDataGrid.Location = new System.Drawing.Point(297, 26);
			this.invoiceDataGrid.Name = "invoiceDataGrid";
			this.invoiceDataGrid.Size = new System.Drawing.Size(230, 171);
			this.invoiceDataGrid.TabIndex = 1;
			this.invoiceDataGrid.Visible = false;
			this.invoiceDataGrid.Navigate += new System.Windows.Forms.NavigateEventHandler(this.invoiceDataGrid_Navigate);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.addressDataGridView);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(468, 198);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Company Addresses";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// addressDataGridView
			// 
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.addressDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.addressDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
			this.addressDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.addressDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyIDAddCol,
            this.AddressID,
            this.Addresses,
            this.Phone,
            this.DateModify});
			this.addressDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.addressDataGridView.Location = new System.Drawing.Point(3, 3);
			this.addressDataGridView.Name = "addressDataGridView";
			this.addressDataGridView.Size = new System.Drawing.Size(462, 192);
			this.addressDataGridView.TabIndex = 0;
			this.addressDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.addressDataGridView_DefaultValuesNeeded);
			// 
			// companyIDAddCol
			// 
			this.companyIDAddCol.DataPropertyName = "company_id";
			this.companyIDAddCol.HeaderText = "Company ID";
			this.companyIDAddCol.Name = "companyIDAddCol";
			this.companyIDAddCol.Visible = false;
			// 
			// AddressID
			// 
			this.AddressID.DataPropertyName = "address_id";
			this.AddressID.HeaderText = "Address ID";
			this.AddressID.Name = "AddressID";
			this.AddressID.Visible = false;
			// 
			// Addresses
			// 
			this.Addresses.DataPropertyName = "addresses";
			this.Addresses.HeaderText = "Addresses";
			this.Addresses.Name = "Addresses";
			// 
			// Phone
			// 
			this.Phone.DataPropertyName = "phone";
			this.Phone.HeaderText = "Phone";
			this.Phone.Name = "Phone";
			// 
			// DateModify
			// 
			this.DateModify.DataPropertyName = "date_modify";
			this.DateModify.HeaderText = "Date Modified";
			this.DateModify.Name = "DateModify";
			// 
			// invoiceInfoLabel
			// 
			this.invoiceInfoLabel.AutoSize = true;
			this.invoiceInfoLabel.Location = new System.Drawing.Point(16, 9);
			this.invoiceInfoLabel.Name = "invoiceInfoLabel";
			this.invoiceInfoLabel.Size = new System.Drawing.Size(210, 13);
			this.invoiceInfoLabel.TabIndex = 1;
			this.invoiceInfoLabel.Text = "Double-click on an invoice for more details:";
			// 
			// InvoicesAndAddressesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(509, 265);
			this.Controls.Add(this.invoiceInfoLabel);
			this.Controls.Add(this.tabControl1);
			this.MaximumSize = new System.Drawing.Size(525, 303);
			this.MinimumSize = new System.Drawing.Size(525, 303);
			this.Name = "InvoicesAndAddressesForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Selected Company\'s Invoices and Addresses";
			this.Load += new System.EventHandler(this.InvoicesForm_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.invoiceDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.invoiceDataGrid)).EndInit();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.addressDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGrid invoiceDataGrid;
		private System.Windows.Forms.DataGridView addressDataGridView;
		private System.Windows.Forms.DataGridView invoiceDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceIDCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceDateCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn CompIDInvoiceCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn TermsCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn companyIDAddCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn AddressID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Addresses;
		private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
		private System.Windows.Forms.DataGridViewTextBoxColumn DateModify;
		private System.Windows.Forms.Label invoiceInfoLabel;

	}
}