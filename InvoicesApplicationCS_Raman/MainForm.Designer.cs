namespace InvoicesApplicationCS_Raman
{
	partial class MainForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.CompDataGridView = new System.Windows.Forms.DataGridView();
			this.companyIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.companyNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reportAllInvoices = new System.Windows.Forms.ToolStripMenuItem();
			this.reportAllCompaniesWithAddresses = new System.Windows.Forms.ToolStripMenuItem();
			this.selectedCompanyInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.invoicesCostChart = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CompanyInfoLabel = new System.Windows.Forms.Label();
			this.selectedCompanyInvoiceCosts = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.CompDataGridView)).BeginInit();
			this.mainMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// CompDataGridView
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			this.CompDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.CompDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.CompDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.CompDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
			this.CompDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.CompDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyIDCol,
            this.companyNameCol});
			this.CompDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
			this.CompDataGridView.Location = new System.Drawing.Point(15, 46);
			this.CompDataGridView.MaximumSize = new System.Drawing.Size(228, 235);
			this.CompDataGridView.MinimumSize = new System.Drawing.Size(228, 235);
			this.CompDataGridView.Name = "CompDataGridView";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.CompDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			this.CompDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.CompDataGridView.Size = new System.Drawing.Size(228, 235);
			this.CompDataGridView.TabIndex = 0;
			this.CompDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CompDataGridView_CellContentDoubleClick);
			// 
			// companyIDCol
			// 
			this.companyIDCol.DataPropertyName = "company_id";
			this.companyIDCol.HeaderText = "Company ID";
			this.companyIDCol.Name = "companyIDCol";
			this.companyIDCol.ReadOnly = true;
			this.companyIDCol.Visible = false;
			this.companyIDCol.Width = 90;
			// 
			// companyNameCol
			// 
			this.companyNameCol.DataPropertyName = "name";
			this.companyNameCol.HeaderText = "Company Name";
			this.companyNameCol.Name = "companyNameCol";
			this.companyNameCol.Width = 98;
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.mainMenuStrip.Size = new System.Drawing.Size(286, 24);
			this.mainMenuStrip.TabIndex = 6;
			this.mainMenuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.toolStripSeparator2,
            this.ExitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// printToolStripMenuItem
			// 
			this.printToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportAllInvoices,
            this.reportAllCompaniesWithAddresses,
            this.selectedCompanyInformationToolStripMenuItem,
            this.invoicesCostChart,
            this.selectedCompanyInvoiceCosts});
			this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
			this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.printToolStripMenuItem.Name = "printToolStripMenuItem";
			this.printToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.printToolStripMenuItem.Text = "&Print Report";
			// 
			// reportAllInvoices
			// 
			this.reportAllInvoices.Name = "reportAllInvoices";
			this.reportAllInvoices.Size = new System.Drawing.Size(276, 22);
			this.reportAllInvoices.Text = "Company Invoices";
			this.reportAllInvoices.Click += new System.EventHandler(this.ReportAllCompaniesWithInvoices_Click);
			// 
			// reportAllCompaniesWithAddresses
			// 
			this.reportAllCompaniesWithAddresses.Name = "reportAllCompaniesWithAddresses";
			this.reportAllCompaniesWithAddresses.Size = new System.Drawing.Size(276, 22);
			this.reportAllCompaniesWithAddresses.Text = "Company Addresses";
			this.reportAllCompaniesWithAddresses.Click += new System.EventHandler(this.ReportAllCompaniesWithAddresses_Click);
			// 
			// selectedCompanyInformationToolStripMenuItem
			// 
			this.selectedCompanyInformationToolStripMenuItem.Name = "selectedCompanyInformationToolStripMenuItem";
			this.selectedCompanyInformationToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
			this.selectedCompanyInformationToolStripMenuItem.Text = "Selected Company Information";
			this.selectedCompanyInformationToolStripMenuItem.Click += new System.EventHandler(this.SelectedCompanyInformation_Click);
			// 
			// invoicesCostChart
			// 
			this.invoicesCostChart.Name = "invoicesCostChart";
			this.invoicesCostChart.Size = new System.Drawing.Size(276, 22);
			this.invoicesCostChart.Text = "Total Invoice Costs Over Time";
			this.invoicesCostChart.Click += new System.EventHandler(this.InvoicesCostChart_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
			// 
			// ExitToolStripMenuItem
			// 
			this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
			this.ExitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.ExitToolStripMenuItem.Text = "E&xit";
			this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuClick);
			// 
			// CompanyInfoLabel
			// 
			this.CompanyInfoLabel.AutoSize = true;
			this.CompanyInfoLabel.Location = new System.Drawing.Point(12, 30);
			this.CompanyInfoLabel.Name = "CompanyInfoLabel";
			this.CompanyInfoLabel.Size = new System.Drawing.Size(242, 13);
			this.CompanyInfoLabel.TabIndex = 7;
			this.CompanyInfoLabel.Text = "Double-click on a company name for more details:";
			// 
			// selectedCompanyInvoiceCosts
			// 
			this.selectedCompanyInvoiceCosts.Name = "selectedCompanyInvoiceCosts";
			this.selectedCompanyInvoiceCosts.Size = new System.Drawing.Size(276, 22);
			this.selectedCompanyInvoiceCosts.Text = "Selected Company Total Invoice Costs";
			this.selectedCompanyInvoiceCosts.Click += new System.EventHandler(this.selectedCompanyYearlyInvoiceCosts_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(286, 293);
			this.Controls.Add(this.CompanyInfoLabel);
			this.Controls.Add(this.CompDataGridView);
			this.Controls.Add(this.mainMenuStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MainMenuStrip = this.mainMenuStrip;
			this.MaximumSize = new System.Drawing.Size(306, 335);
			this.MinimumSize = new System.Drawing.Size(306, 335);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Companies";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.CompDataGridView)).EndInit();
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView CompDataGridView;
		private System.Windows.Forms.MenuStrip mainMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reportAllInvoices;
		private System.Windows.Forms.ToolStripMenuItem reportAllCompaniesWithAddresses;
		private System.Windows.Forms.DataGridViewTextBoxColumn companyIDCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn companyNameCol;
		private System.Windows.Forms.Label CompanyInfoLabel;
		private System.Windows.Forms.ToolStripMenuItem selectedCompanyInformationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem invoicesCostChart;
		private System.Windows.Forms.ToolStripMenuItem selectedCompanyInvoiceCosts;

	}
}

