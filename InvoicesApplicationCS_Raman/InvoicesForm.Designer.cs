namespace InvoicesApplicationCS_Raman
{
	partial class InvoicesForm
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.invoiceDataGrid = new System.Windows.Forms.DataGrid();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.addressDataGridView = new System.Windows.Forms.DataGridView();
			this.CompanyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AddressID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DateModify = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.invoiceDataGrid)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.addressDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(-1, -3);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(516, 204);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.invoiceDataGrid);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(508, 178);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Invoices";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// invoiceDataGrid
			// 
			this.invoiceDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
			this.invoiceDataGrid.DataMember = "";
			this.invoiceDataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.invoiceDataGrid.Location = new System.Drawing.Point(5, 7);
			this.invoiceDataGrid.Name = "invoiceDataGrid";
			this.invoiceDataGrid.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
			this.invoiceDataGrid.Size = new System.Drawing.Size(499, 164);
			this.invoiceDataGrid.TabIndex = 1;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.addressDataGridView);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(508, 178);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Addresses";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// addressDataGridView
			// 
			this.addressDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.addressDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompanyID,
            this.AddressID,
            this.Phone,
            this.DateModify});
			this.addressDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.addressDataGridView.Location = new System.Drawing.Point(3, 3);
			this.addressDataGridView.Name = "addressDataGridView";
			this.addressDataGridView.Size = new System.Drawing.Size(502, 172);
			this.addressDataGridView.TabIndex = 0;
			// 
			// CompanyID
			// 
			this.CompanyID.DataPropertyName = "company_id";
			this.CompanyID.HeaderText = "Company ID";
			this.CompanyID.Name = "CompanyID";
			// 
			// AddressID
			// 
			this.AddressID.DataPropertyName = "address_id";
			this.AddressID.HeaderText = "Address ID";
			this.AddressID.Name = "AddressID";
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
			// InvoicesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(514, 198);
			this.Controls.Add(this.tabControl1);
			this.Name = "InvoicesForm";
			this.Text = "Invoices and Details";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.invoiceDataGrid)).EndInit();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.addressDataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGrid invoiceDataGrid;
		private System.Windows.Forms.DataGridView addressDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn CompanyID;
		private System.Windows.Forms.DataGridViewTextBoxColumn AddressID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
		private System.Windows.Forms.DataGridViewTextBoxColumn DateModify;

	}
}