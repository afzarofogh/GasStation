namespace GasStation.Forms.Base
{
	partial class PlateCityEntryForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose ();
			}
			base.Dispose (disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
		{
			this.saveButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.dataGroupBox = new System.Windows.Forms.GroupBox();
			this.cityTextBox = new System.Windows.Forms.TextBox();
			this.namelabel = new System.Windows.Forms.Label();
			this.dataGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// saveButton
			// 
			this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.saveButton.Location = new System.Drawing.Point(135, 123);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(117, 33);
			this.saveButton.TabIndex = 1;
			this.saveButton.Text = "ثبت";
			this.saveButton.UseVisualStyleBackColor = true;
			// 
			// exitButton
			// 
			this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.exitButton.Location = new System.Drawing.Point(12, 123);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(117, 33);
			this.exitButton.TabIndex = 2;
			this.exitButton.Text = "خروج";
			this.exitButton.UseVisualStyleBackColor = true;
			// 
			// dataGroupBox
			// 
			this.dataGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGroupBox.Controls.Add(this.cityTextBox);
			this.dataGroupBox.Controls.Add(this.namelabel);
			this.dataGroupBox.Location = new System.Drawing.Point(12, 12);
			this.dataGroupBox.Name = "dataGroupBox";
			this.dataGroupBox.Size = new System.Drawing.Size(362, 105);
			this.dataGroupBox.TabIndex = 0;
			this.dataGroupBox.TabStop = false;
			this.dataGroupBox.Text = "اطلاعات پایه";
			// 
			// cityTextBox
			// 
			this.cityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cityTextBox.Location = new System.Drawing.Point(29, 58);
			this.cityTextBox.MaxLength = 50;
			this.cityTextBox.Name = "cityTextBox";
			this.cityTextBox.Size = new System.Drawing.Size(298, 26);
			this.cityTextBox.TabIndex = 0;
			this.cityTextBox.Tag = "city";
			// 
			// namelabel
			// 
			this.namelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.namelabel.AutoSize = true;
			this.namelabel.Location = new System.Drawing.Point(293, 31);
			this.namelabel.Name = "namelabel";
			this.namelabel.Size = new System.Drawing.Size(37, 18);
			this.namelabel.TabIndex = 1;
			this.namelabel.Text = "شهر";
			// 
			// PlateCityEntryForm
			// 
			this.AcceptButton = this.saveButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.exitButton;
			this.ClientSize = new System.Drawing.Size(386, 168);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.dataGroupBox);
			this.Name = "PlateCityEntryForm";
			this.Text = "ثبت اطلاعات / شهر";
			this.dataGroupBox.ResumeLayout(false);
			this.dataGroupBox.PerformLayout();
			this.ResumeLayout(false);
		}
		#endregion

		private System.Windows.Forms.GroupBox dataGroupBox;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.TextBox cityTextBox;
		private System.Windows.Forms.Label namelabel;
	}
}