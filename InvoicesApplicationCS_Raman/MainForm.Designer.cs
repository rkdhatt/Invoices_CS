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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			this.addCompanyButton = new System.Windows.Forms.Button();
			this.viewInvoicesButton = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.companyTitleLabel = new System.Windows.Forms.Label();
			this.mainDataGrid = new System.Windows.Forms.DataGrid();
			this.compDataGridView = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.mainDataGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.compDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// addCompanyButton
			// 
			this.addCompanyButton.Location = new System.Drawing.Point(22, 85);
			this.addCompanyButton.Name = "addCompanyButton";
			this.addCompanyButton.Size = new System.Drawing.Size(147, 25);
			this.addCompanyButton.TabIndex = 1;
			this.addCompanyButton.Text = "Add Company";
			this.addCompanyButton.UseVisualStyleBackColor = true;
			this.addCompanyButton.Click += new System.EventHandler(this.addCompanyButton_Click);
			// 
			// viewInvoicesButton
			// 
			this.viewInvoicesButton.Location = new System.Drawing.Point(22, 131);
			this.viewInvoicesButton.Name = "viewInvoicesButton";
			this.viewInvoicesButton.Size = new System.Drawing.Size(147, 25);
			this.viewInvoicesButton.TabIndex = 2;
			this.viewInvoicesButton.Text = "View Invoices";
			this.viewInvoicesButton.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(22, 178);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(147, 25);
			this.button3.TabIndex = 3;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// companyTitleLabel
			// 
			this.companyTitleLabel.AutoSize = true;
			this.companyTitleLabel.Location = new System.Drawing.Point(184, 28);
			this.companyTitleLabel.Name = "companyTitleLabel";
			this.companyTitleLabel.Size = new System.Drawing.Size(59, 13);
			this.companyTitleLabel.TabIndex = 4;
			this.companyTitleLabel.Text = "Companies";
			// 
			// mainDataGrid
			// 
			this.mainDataGrid.AllowSorting = false;
			this.mainDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mainDataGrid.CaptionBackColor = System.Drawing.Color.Orange;
			this.mainDataGrid.DataMember = "";
			this.mainDataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.mainDataGrid.LinkColor = System.Drawing.Color.Black;
			this.mainDataGrid.Location = new System.Drawing.Point(187, 44);
			this.mainDataGrid.Name = "mainDataGrid";
			this.mainDataGrid.Size = new System.Drawing.Size(486, 206);
			this.mainDataGrid.TabIndex = 5;
			// 
			// compDataGridView
			// 
			dataGridViewCellStyle13.BackColor = System.Drawing.Color.LightCyan;
			dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
			this.compDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
			this.compDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.compDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.compDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.compDataGridView.Location = new System.Drawing.Point(345, 44);
			this.compDataGridView.Name = "compDataGridView";
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.compDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
			dataGridViewCellStyle15.BackColor = System.Drawing.Color.PowderBlue;
			this.compDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle15;
			this.compDataGridView.Size = new System.Drawing.Size(244, 66);
			this.compDataGridView.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(690, 268);
			this.Controls.Add(this.mainDataGrid);
			this.Controls.Add(this.companyTitleLabel);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.viewInvoicesButton);
			this.Controls.Add(this.addCompanyButton);
			this.Controls.Add(this.compDataGridView);
			this.Name = "MainForm";
			this.Text = "Invoices Application";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.mainDataGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.compDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button addCompanyButton;
		private System.Windows.Forms.Button viewInvoicesButton;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label companyTitleLabel;
		private System.Windows.Forms.DataGrid mainDataGrid;
		private System.Windows.Forms.DataGridView compDataGridView;

	}
}

