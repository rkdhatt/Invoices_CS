namespace InvoicesApplicationCS_Raman
{
	partial class AddCompanyForm
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
			this.companyNameLabel = new System.Windows.Forms.Label();
			this.addCompanyTextBox = new System.Windows.Forms.TextBox();
			this.addCompanyOKButton = new System.Windows.Forms.Button();
			this.addCompanyCancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// companyNameLabel
			// 
			this.companyNameLabel.AutoSize = true;
			this.companyNameLabel.Location = new System.Drawing.Point(26, 25);
			this.companyNameLabel.Name = "companyNameLabel";
			this.companyNameLabel.Size = new System.Drawing.Size(82, 13);
			this.companyNameLabel.TabIndex = 0;
			this.companyNameLabel.Text = "Company Name";
			// 
			// addCompanyTextBox
			// 
			this.addCompanyTextBox.Location = new System.Drawing.Point(142, 22);
			this.addCompanyTextBox.Name = "addCompanyTextBox";
			this.addCompanyTextBox.Size = new System.Drawing.Size(100, 20);
			this.addCompanyTextBox.TabIndex = 1;
			// 
			// addCompanyOKButton
			// 
			this.addCompanyOKButton.Location = new System.Drawing.Point(43, 66);
			this.addCompanyOKButton.Name = "addCompanyOKButton";
			this.addCompanyOKButton.Size = new System.Drawing.Size(100, 23);
			this.addCompanyOKButton.TabIndex = 2;
			this.addCompanyOKButton.Text = "OK";
			this.addCompanyOKButton.UseVisualStyleBackColor = true;
			this.addCompanyOKButton.Click += new System.EventHandler(this.addCompanyOKButton_Click);
			// 
			// addCompanyCancelButton
			// 
			this.addCompanyCancelButton.Location = new System.Drawing.Point(149, 66);
			this.addCompanyCancelButton.Name = "addCompanyCancelButton";
			this.addCompanyCancelButton.Size = new System.Drawing.Size(93, 23);
			this.addCompanyCancelButton.TabIndex = 3;
			this.addCompanyCancelButton.Text = "Cancel";
			this.addCompanyCancelButton.UseVisualStyleBackColor = true;
			this.addCompanyCancelButton.Click += new System.EventHandler(this.addCompanyCancelButton_Click);
			// 
			// AddCompanyForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(300, 118);
			this.Controls.Add(this.addCompanyCancelButton);
			this.Controls.Add(this.addCompanyOKButton);
			this.Controls.Add(this.addCompanyTextBox);
			this.Controls.Add(this.companyNameLabel);
			this.Name = "AddCompanyForm";
			this.Text = "Add New Company";
			this.Load += new System.EventHandler(this.AddCompanyForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label companyNameLabel;
		private System.Windows.Forms.TextBox addCompanyTextBox;
		private System.Windows.Forms.Button addCompanyOKButton;
		private System.Windows.Forms.Button addCompanyCancelButton;
	}
}