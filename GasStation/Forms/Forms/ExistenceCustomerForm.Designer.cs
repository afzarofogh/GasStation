namespace GasStation.Forms.Forms
{
	partial class ExistenceCustomerForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.nameLabel = new System.Windows.Forms.Label();
			this.lastnameLabel = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.getButton = new System.Windows.Forms.Button();
			this.ownerDataGroupBox = new System.Windows.Forms.GroupBox();
			this.ownerDataGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(307, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(25, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "نام";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(244, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 18);
			this.label2.TabIndex = 0;
			this.label2.Text = "نام خانوادگی";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(276, 121);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 18);
			this.label3.TabIndex = 0;
			this.label3.Text = "کد ملی";
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.BackColor = System.Drawing.Color.Transparent;
			this.nameLabel.Location = new System.Drawing.Point(77, 34);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(25, 18);
			this.nameLabel.TabIndex = 1;
			this.nameLabel.Tag = "name";
			this.nameLabel.Text = "نام";
			// 
			// lastnameLabel
			// 
			this.lastnameLabel.AutoSize = true;
			this.lastnameLabel.BackColor = System.Drawing.Color.Transparent;
			this.lastnameLabel.Location = new System.Drawing.Point(42, 72);
			this.lastnameLabel.Name = "lastnameLabel";
			this.lastnameLabel.Size = new System.Drawing.Size(88, 18);
			this.lastnameLabel.TabIndex = 1;
			this.lastnameLabel.Tag = "lastname";
			this.lastnameLabel.Text = "نام خانوادگی";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(77, 121);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(23, 18);
			this.label6.TabIndex = 1;
			this.label6.Tag = "nationalCode";
			this.label6.Text = "کد";
			// 
			// getButton
			// 
			this.getButton.Location = new System.Drawing.Point(17, 336);
			this.getButton.Name = "getButton";
			this.getButton.Size = new System.Drawing.Size(143, 39);
			this.getButton.TabIndex = 2;
			this.getButton.Text = "دریافت اطلاعات";
			this.getButton.UseVisualStyleBackColor = true;
			// 
			// ownerDataGroupBox
			// 
			this.ownerDataGroupBox.BackColor = System.Drawing.Color.Transparent;
			this.ownerDataGroupBox.Controls.Add(this.label1);
			this.ownerDataGroupBox.Controls.Add(this.label2);
			this.ownerDataGroupBox.Controls.Add(this.label6);
			this.ownerDataGroupBox.Controls.Add(this.label3);
			this.ownerDataGroupBox.Controls.Add(this.lastnameLabel);
			this.ownerDataGroupBox.Controls.Add(this.nameLabel);
			this.ownerDataGroupBox.Location = new System.Drawing.Point(12, 12);
			this.ownerDataGroupBox.Name = "ownerDataGroupBox";
			this.ownerDataGroupBox.Size = new System.Drawing.Size(374, 311);
			this.ownerDataGroupBox.TabIndex = 3;
			this.ownerDataGroupBox.TabStop = false;
			this.ownerDataGroupBox.Text = "نمایش اطلاعات راننده";
			// 
			// ExistenceCustomerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(398, 380);
			this.Controls.Add(this.ownerDataGroupBox);
			this.Controls.Add(this.getButton);
			this.Name = "ExistenceCustomerForm";
			this.Text = "مشخصات مشتری";
			this.ownerDataGroupBox.ResumeLayout(false);
			this.ownerDataGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Label lastnameLabel;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button getButton;
		private System.Windows.Forms.GroupBox ownerDataGroupBox;
	}
}