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
			((System.ComponentModel.ISupportInitialize)(this.detailsDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// detailsDataGridView
			// 
			this.detailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.detailsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.detailsDataGridView.Location = new System.Drawing.Point(0, 0);
			this.detailsDataGridView.Name = "detailsDataGridView";
			this.detailsDataGridView.Size = new System.Drawing.Size(441, 209);
			this.detailsDataGridView.TabIndex = 0;
			// 
			// InvoiceDetailsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 209);
			this.Controls.Add(this.detailsDataGridView);
			this.Name = "InvoiceDetailsForm";
			this.Text = "InvoiceDetailsForm";
			((System.ComponentModel.ISupportInitialize)(this.detailsDataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView detailsDataGridView;
	}
}