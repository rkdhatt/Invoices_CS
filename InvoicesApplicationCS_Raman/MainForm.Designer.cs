﻿namespace InvoicesApplicationCS_Raman
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
			this.compDataGridView = new System.Windows.Forms.DataGridView();
			this.companyIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.companyNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reportAllCompaniesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reportSelectedCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.compDataGridView)).BeginInit();
			this.mainMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// compDataGridView
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			this.compDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.compDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.compDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.compDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
			this.compDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.compDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyIDCol,
            this.companyNameCol});
			this.compDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
			this.compDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.compDataGridView.Location = new System.Drawing.Point(0, 24);
			this.compDataGridView.MaximumSize = new System.Drawing.Size(228, 235);
			this.compDataGridView.MinimumSize = new System.Drawing.Size(228, 235);
			this.compDataGridView.Name = "compDataGridView";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.compDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			this.compDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.compDataGridView.Size = new System.Drawing.Size(228, 235);
			this.compDataGridView.TabIndex = 0;
			this.compDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.compDataGridView_CellContentDoubleClick);
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
            this.helpToolStripMenuItem});
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.mainMenuStrip.Size = new System.Drawing.Size(229, 24);
			this.mainMenuStrip.TabIndex = 6;
			this.mainMenuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
			this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.newToolStripMenuItem.Text = "&New";
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(138, 6);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
			// 
			// printToolStripMenuItem
			// 
			this.printToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportAllCompaniesToolStripMenuItem,
            this.reportSelectedCompanyToolStripMenuItem});
			this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
			this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.printToolStripMenuItem.Name = "printToolStripMenuItem";
			this.printToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.printToolStripMenuItem.Text = "&Print";
			// 
			// reportAllCompaniesToolStripMenuItem
			// 
			this.reportAllCompaniesToolStripMenuItem.Name = "reportAllCompaniesToolStripMenuItem";
			this.reportAllCompaniesToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
			this.reportAllCompaniesToolStripMenuItem.Text = "Report - All Companies";
			// 
			// reportSelectedCompanyToolStripMenuItem
			// 
			this.reportSelectedCompanyToolStripMenuItem.Name = "reportSelectedCompanyToolStripMenuItem";
			this.reportSelectedCompanyToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
			this.reportSelectedCompanyToolStripMenuItem.Text = "Report - Selected Company";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(138, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// searchToolStripMenuItem
			// 
			this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
			this.searchToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.searchToolStripMenuItem.Text = "&Search";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(113, 6);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.aboutToolStripMenuItem.Text = "&About...";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(229, 260);
			this.Controls.Add(this.compDataGridView);
			this.Controls.Add(this.mainMenuStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MainMenuStrip = this.mainMenuStrip;
			this.Name = "MainForm";
			this.Text = "Companies";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.compDataGridView)).EndInit();
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView compDataGridView;
		private System.Windows.Forms.MenuStrip mainMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reportAllCompaniesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reportSelectedCompanyToolStripMenuItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn companyIDCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn companyNameCol;

	}
}

