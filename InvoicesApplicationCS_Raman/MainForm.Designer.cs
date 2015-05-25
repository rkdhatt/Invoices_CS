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
			this.compDataGridView = new System.Windows.Forms.DataGridView();
			this.addCompanyButton = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.companyTitleLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.compDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// compDataGridView
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			this.compDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.compDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.compDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.compDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.compDataGridView.Location = new System.Drawing.Point(210, 35);
			this.compDataGridView.Name = "compDataGridView";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.compDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.PowderBlue;
			this.compDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
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
			this.companyTitleLabel.Location = new System.Drawing.Point(207, 19);
			this.companyTitleLabel.Name = "companyTitleLabel";
			this.companyTitleLabel.Size = new System.Drawing.Size(59, 13);
			this.companyTitleLabel.TabIndex = 4;
			this.companyTitleLabel.Text = "Companies";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(417, 175);
			this.Controls.Add(this.companyTitleLabel);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.addCompanyButton);
			this.Controls.Add(this.compDataGridView);
			this.Name = "MainForm";
			this.Text = "Invoices Application";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.compDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView compDataGridView;
		private System.Windows.Forms.Button addCompanyButton;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label companyTitleLabel;

	}
}

