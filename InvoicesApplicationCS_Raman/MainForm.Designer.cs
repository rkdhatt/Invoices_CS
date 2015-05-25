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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			this.compDataGridView = new System.Windows.Forms.DataGridView();
			this.addCompanyButton = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.companyTitleLabel = new System.Windows.Forms.Label();
			this.mainDataGrid = new System.Windows.Forms.DataGrid();
			((System.ComponentModel.ISupportInitialize)(this.compDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mainDataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// compDataGridView
			// 
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightCyan;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
			this.compDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
			this.compDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.compDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.compDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.compDataGridView.Location = new System.Drawing.Point(210, 35);
			this.compDataGridView.Name = "compDataGridView";
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.compDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.PowderBlue;
			this.compDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle12;
			this.compDataGridView.Size = new System.Drawing.Size(172, 106);
			this.compDataGridView.TabIndex = 0;
			// 
			// addCompanyButton
			// 
			this.addCompanyButton.Location = new System.Drawing.Point(22, 35);
			this.addCompanyButton.Name = "addCompanyButton";
			this.addCompanyButton.Size = new System.Drawing.Size(147, 25);
			this.addCompanyButton.TabIndex = 1;
			this.addCompanyButton.Text = "Add Company";
			this.addCompanyButton.UseVisualStyleBackColor = true;
			this.addCompanyButton.Click += new System.EventHandler(this.addCompanyButton_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(22, 75);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(147, 25);
			this.button2.TabIndex = 2;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(22, 116);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(147, 25);
			this.button3.TabIndex = 3;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// companyTitleLabel
			// 
			this.companyTitleLabel.AutoSize = true;
			this.companyTitleLabel.Location = new System.Drawing.Point(184, 19);
			this.companyTitleLabel.Name = "companyTitleLabel";
			this.companyTitleLabel.Size = new System.Drawing.Size(59, 13);
			this.companyTitleLabel.TabIndex = 4;
			this.companyTitleLabel.Text = "Companies";
			// 
			// mainDataGrid
			// 
			this.mainDataGrid.DataMember = "";
			this.mainDataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.mainDataGrid.Location = new System.Drawing.Point(187, 35);
			this.mainDataGrid.Name = "mainDataGrid";
			this.mainDataGrid.Size = new System.Drawing.Size(478, 116);
			this.mainDataGrid.TabIndex = 5;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(692, 193);
			this.Controls.Add(this.mainDataGrid);
			this.Controls.Add(this.companyTitleLabel);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.addCompanyButton);
			this.Controls.Add(this.compDataGridView);
			this.Name = "MainForm";
			this.Text = "Invoices Application";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.compDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mainDataGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView compDataGridView;
		private System.Windows.Forms.Button addCompanyButton;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label companyTitleLabel;
		private System.Windows.Forms.DataGrid mainDataGrid;

	}
}

