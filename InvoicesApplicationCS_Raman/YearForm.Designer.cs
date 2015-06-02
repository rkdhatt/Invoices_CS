namespace InvoicesApplicationCS_Raman
{
	partial class YearForm
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
			this.yearLabel = new System.Windows.Forms.Label();
			this.yearTextBox = new System.Windows.Forms.TextBox();
			this.okButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// yearLabel
			// 
			this.yearLabel.AutoSize = true;
			this.yearLabel.Location = new System.Drawing.Point(30, 28);
			this.yearLabel.Name = "yearLabel";
			this.yearLabel.Size = new System.Drawing.Size(60, 13);
			this.yearLabel.TabIndex = 0;
			this.yearLabel.Text = "Enter Year:";
			// 
			// yearTextBox
			// 
			this.yearTextBox.Location = new System.Drawing.Point(108, 28);
			this.yearTextBox.Name = "yearTextBox";
			this.yearTextBox.Size = new System.Drawing.Size(100, 20);
			this.yearTextBox.TabIndex = 1;
			// 
			// okButton
			// 
			this.okButton.Location = new System.Drawing.Point(33, 72);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 2;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.OKButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(114, 72);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 3;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// YearForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(260, 109);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.yearTextBox);
			this.Controls.Add(this.yearLabel);
			this.MaximumSize = new System.Drawing.Size(276, 147);
			this.MinimumSize = new System.Drawing.Size(276, 147);
			this.Name = "YearForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Enter Company Year";
			this.Load += new System.EventHandler(this.YearForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label yearLabel;
		private System.Windows.Forms.TextBox yearTextBox;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button cancelButton;
	}
}