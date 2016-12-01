namespace AntennaServiceInstaller.Forms
{
	partial class ServiceControllerForm
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.serviceStatusLabel = new System.Windows.Forms.Label();
			this.pauseServiceButton = new System.Windows.Forms.Button();
			this.stopServiceButton = new System.Windows.Forms.Button();
			this.startServiceButton = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.startServiceButton);
			this.groupBox1.Controls.Add(this.stopServiceButton);
			this.groupBox1.Controls.Add(this.pauseServiceButton);
			this.groupBox1.Controls.Add(this.serviceStatusLabel);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(12, 14);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(598, 121);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(458, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(122, 18);
			this.label3.TabIndex = 1;
			this.label3.Text = "وضعیت سرویس : ";
			// 
			// serviceStatusLabel
			// 
			this.serviceStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.serviceStatusLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.serviceStatusLabel.Location = new System.Drawing.Point(186, 34);
			this.serviceStatusLabel.Name = "serviceStatusLabel";
			this.serviceStatusLabel.Size = new System.Drawing.Size(266, 18);
			this.serviceStatusLabel.TabIndex = 1;
			this.serviceStatusLabel.Text = "Status";
			this.serviceStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pauseServiceButton
			// 
			this.pauseServiceButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.pauseServiceButton.Location = new System.Drawing.Point(239, 75);
			this.pauseServiceButton.Name = "pauseServiceButton";
			this.pauseServiceButton.Size = new System.Drawing.Size(121, 35);
			this.pauseServiceButton.TabIndex = 1;
			this.pauseServiceButton.Text = "توقف";
			this.pauseServiceButton.UseVisualStyleBackColor = true;
			// 
			// stopServiceButton
			// 
			this.stopServiceButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.stopServiceButton.Location = new System.Drawing.Point(112, 75);
			this.stopServiceButton.Name = "stopServiceButton";
			this.stopServiceButton.Size = new System.Drawing.Size(121, 35);
			this.stopServiceButton.TabIndex = 2;
			this.stopServiceButton.Text = "پایان";
			this.stopServiceButton.UseVisualStyleBackColor = true;
			// 
			// startServiceButton
			// 
			this.startServiceButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.startServiceButton.Location = new System.Drawing.Point(366, 75);
			this.startServiceButton.Name = "startServiceButton";
			this.startServiceButton.Size = new System.Drawing.Size(121, 35);
			this.startServiceButton.TabIndex = 0;
			this.startServiceButton.Text = "اجرا";
			this.startServiceButton.UseVisualStyleBackColor = true;
			// 
			// ServiceControllerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::AntennaServiceInstaller.Properties.Resources.formBK;
			this.ClientSize = new System.Drawing.Size(622, 149);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Tahoma", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "ServiceControllerForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "کنترلگر سرویس آنتن";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button startServiceButton;
		private System.Windows.Forms.Button stopServiceButton;
		private System.Windows.Forms.Button pauseServiceButton;
		private System.Windows.Forms.Label serviceStatusLabel;
		private System.Windows.Forms.Label label3;
	}
}

