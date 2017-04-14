namespace GasStation.Forms.Reports
{
	partial class ReportTrafficForm
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.stateTabPage = new System.Windows.Forms.TabPage();
			this.countTabPage = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.typeComboBox = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.printButton = new System.Windows.Forms.Button();
			this.showButton = new System.Windows.Forms.Button();
			this.dateEndMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.dateStartMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.plateDataGroupBox = new System.Windows.Forms.GroupBox();
			this.nationalCodeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.mainPlatePanel = new System.Windows.Forms.Panel();
			this.code1Numeric = new System.Windows.Forms.DomainUpDown();
			this.part2MainTextBox = new System.Windows.Forms.TextBox();
			this.characterDomainUpDown = new System.Windows.Forms.DomainUpDown();
			this.part1MainTextBox = new System.Windows.Forms.TextBox();
			this.plateTypeComboBox = new System.Windows.Forms.ComboBox();
			this.motorPlatePanel = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.part2MotorTextBox = new System.Windows.Forms.TextBox();
			this.part1MotorTextBox = new System.Windows.Forms.TextBox();
			this.malulinPlatePanel = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.code2Numeric = new System.Windows.Forms.DomainUpDown();
			this.part2MaluinTextBox = new System.Windows.Forms.TextBox();
			this.part1MalulinTextBox = new System.Windows.Forms.TextBox();
			this.tabControl1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.plateDataGroupBox.SuspendLayout();
			this.mainPlatePanel.SuspendLayout();
			this.motorPlatePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.malulinPlatePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.stateTabPage);
			this.tabControl1.Controls.Add(this.countTabPage);
			this.tabControl1.Location = new System.Drawing.Point(12, 246);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.RightToLeftLayout = true;
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(751, 382);
			this.tabControl1.TabIndex = 7;
			// 
			// stateTabPage
			// 
			this.stateTabPage.Location = new System.Drawing.Point(4, 27);
			this.stateTabPage.Name = "stateTabPage";
			this.stateTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.stateTabPage.Size = new System.Drawing.Size(743, 351);
			this.stateTabPage.TabIndex = 0;
			this.stateTabPage.Text = "وضعیت تردد";
			this.stateTabPage.UseVisualStyleBackColor = true;
			// 
			// countTabPage
			// 
			this.countTabPage.Location = new System.Drawing.Point(4, 27);
			this.countTabPage.Name = "countTabPage";
			this.countTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.countTabPage.Size = new System.Drawing.Size(743, 351);
			this.countTabPage.TabIndex = 1;
			this.countTabPage.Text = "تعداد تردد";
			this.countTabPage.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.nationalCodeMaskedTextBox);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.typeComboBox);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.printButton);
			this.groupBox1.Controls.Add(this.showButton);
			this.groupBox1.Controls.Add(this.dateEndMaskedTextBox);
			this.groupBox1.Controls.Add(this.dateStartMaskedTextBox);
			this.groupBox1.Controls.Add(this.plateDataGroupBox);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(751, 228);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "گزارش گیری براساس";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(644, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 18);
			this.label3.TabIndex = 10;
			this.label3.Text = "براساس:";
			// 
			// typeComboBox
			// 
			this.typeComboBox.FormattingEnabled = true;
			this.typeComboBox.Items.AddRange(new object[] {
            "انتخاب کنید...",
            "کد ملی",
            "پلاک خودرو"});
			this.typeComboBox.Location = new System.Drawing.Point(428, 73);
			this.typeComboBox.Name = "typeComboBox";
			this.typeComboBox.Size = new System.Drawing.Size(186, 26);
			this.typeComboBox.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(341, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 18);
			this.label2.TabIndex = 3;
			this.label2.Text = "تا تاریخ:";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(651, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 18);
			this.label1.TabIndex = 3;
			this.label1.Text = "از تاریخ:";
			// 
			// printButton
			// 
			this.printButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.printButton.Location = new System.Drawing.Point(18, 189);
			this.printButton.Name = "printButton";
			this.printButton.Size = new System.Drawing.Size(133, 27);
			this.printButton.TabIndex = 2;
			this.printButton.Text = "چاپ";
			this.printButton.UseVisualStyleBackColor = true;
			// 
			// showButton
			// 
			this.showButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.showButton.Location = new System.Drawing.Point(17, 156);
			this.showButton.Name = "showButton";
			this.showButton.Size = new System.Drawing.Size(133, 27);
			this.showButton.TabIndex = 2;
			this.showButton.Text = "نمایش";
			this.showButton.UseVisualStyleBackColor = true;
			// 
			// dateEndMaskedTextBox
			// 
			this.dateEndMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dateEndMaskedTextBox.Location = new System.Drawing.Point(116, 24);
			this.dateEndMaskedTextBox.Mask = "0000/00/00";
			this.dateEndMaskedTextBox.Name = "dateEndMaskedTextBox";
			this.dateEndMaskedTextBox.Size = new System.Drawing.Size(186, 26);
			this.dateEndMaskedTextBox.TabIndex = 1;
			this.dateEndMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// dateStartMaskedTextBox
			// 
			this.dateStartMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dateStartMaskedTextBox.Location = new System.Drawing.Point(428, 27);
			this.dateStartMaskedTextBox.Mask = "0000/00/00";
			this.dateStartMaskedTextBox.Name = "dateStartMaskedTextBox";
			this.dateStartMaskedTextBox.Size = new System.Drawing.Size(186, 26);
			this.dateStartMaskedTextBox.TabIndex = 0;
			this.dateStartMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// plateDataGroupBox
			// 
			this.plateDataGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.plateDataGroupBox.Controls.Add(this.mainPlatePanel);
			this.plateDataGroupBox.Controls.Add(this.plateTypeComboBox);
			this.plateDataGroupBox.Controls.Add(this.motorPlatePanel);
			this.plateDataGroupBox.Controls.Add(this.malulinPlatePanel);
			this.plateDataGroupBox.Location = new System.Drawing.Point(389, 99);
			this.plateDataGroupBox.Name = "plateDataGroupBox";
			this.plateDataGroupBox.Size = new System.Drawing.Size(329, 117);
			this.plateDataGroupBox.TabIndex = 8;
			this.plateDataGroupBox.TabStop = false;
			this.plateDataGroupBox.Visible = false;
			// 
			// nationalCodeMaskedTextBox
			// 
			this.nationalCodeMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.nationalCodeMaskedTextBox.Location = new System.Drawing.Point(206, 73);
			this.nationalCodeMaskedTextBox.Mask = "0000000000";
			this.nationalCodeMaskedTextBox.Name = "nationalCodeMaskedTextBox";
			this.nationalCodeMaskedTextBox.Size = new System.Drawing.Size(186, 26);
			this.nationalCodeMaskedTextBox.TabIndex = 6;
			this.nationalCodeMaskedTextBox.Tag = "nationalCode";
			this.nationalCodeMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nationalCodeMaskedTextBox.Visible = false;
			// 
			// mainPlatePanel
			// 
			this.mainPlatePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mainPlatePanel.Controls.Add(this.code1Numeric);
			this.mainPlatePanel.Controls.Add(this.part2MainTextBox);
			this.mainPlatePanel.Controls.Add(this.characterDomainUpDown);
			this.mainPlatePanel.Controls.Add(this.part1MainTextBox);
			this.mainPlatePanel.Location = new System.Drawing.Point(21, 61);
			this.mainPlatePanel.Name = "mainPlatePanel";
			this.mainPlatePanel.Size = new System.Drawing.Size(295, 47);
			this.mainPlatePanel.TabIndex = 4;
			// 
			// code1Numeric
			// 
			this.code1Numeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.code1Numeric.Location = new System.Drawing.Point(243, 7);
			this.code1Numeric.Name = "code1Numeric";
			this.code1Numeric.Size = new System.Drawing.Size(49, 26);
			this.code1Numeric.TabIndex = 3;
			this.code1Numeric.Tag = "plateCityId";
			this.code1Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// part2MainTextBox
			// 
			this.part2MainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.part2MainTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
			this.part2MainTextBox.Location = new System.Drawing.Point(171, 7);
			this.part2MainTextBox.MaxLength = 3;
			this.part2MainTextBox.Name = "part2MainTextBox";
			this.part2MainTextBox.Size = new System.Drawing.Size(67, 26);
			this.part2MainTextBox.TabIndex = 2;
			this.part2MainTextBox.Tag = "";
			this.part2MainTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// characterDomainUpDown
			// 
			this.characterDomainUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.characterDomainUpDown.Items.Add("الف");
			this.characterDomainUpDown.Items.Add("ب");
			this.characterDomainUpDown.Items.Add("پ");
			this.characterDomainUpDown.Items.Add("ی");
			this.characterDomainUpDown.Location = new System.Drawing.Point(108, 7);
			this.characterDomainUpDown.Name = "characterDomainUpDown";
			this.characterDomainUpDown.Size = new System.Drawing.Size(58, 26);
			this.characterDomainUpDown.TabIndex = 1;
			this.characterDomainUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// part1MainTextBox
			// 
			this.part1MainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.part1MainTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
			this.part1MainTextBox.Location = new System.Drawing.Point(36, 7);
			this.part1MainTextBox.MaxLength = 2;
			this.part1MainTextBox.Name = "part1MainTextBox";
			this.part1MainTextBox.Size = new System.Drawing.Size(67, 26);
			this.part1MainTextBox.TabIndex = 0;
			this.part1MainTextBox.Tag = "";
			this.part1MainTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// plateTypeComboBox
			// 
			this.plateTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.plateTypeComboBox.FormattingEnabled = true;
			this.plateTypeComboBox.Location = new System.Drawing.Point(21, 24);
			this.plateTypeComboBox.Name = "plateTypeComboBox";
			this.plateTypeComboBox.Size = new System.Drawing.Size(295, 26);
			this.plateTypeComboBox.TabIndex = 5;
			this.plateTypeComboBox.Tag = "plateTypeId";
			// 
			// motorPlatePanel
			// 
			this.motorPlatePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.motorPlatePanel.Controls.Add(this.pictureBox2);
			this.motorPlatePanel.Controls.Add(this.part2MotorTextBox);
			this.motorPlatePanel.Controls.Add(this.part1MotorTextBox);
			this.motorPlatePanel.Location = new System.Drawing.Point(21, 64);
			this.motorPlatePanel.Name = "motorPlatePanel";
			this.motorPlatePanel.Size = new System.Drawing.Size(295, 42);
			this.motorPlatePanel.TabIndex = 2;
			this.motorPlatePanel.Visible = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImage = global::GasStation.Properties.Resources.motor;
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox2.Location = new System.Drawing.Point(114, 3);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(49, 32);
			this.pictureBox2.TabIndex = 12;
			this.pictureBox2.TabStop = false;
			// 
			// part2MotorTextBox
			// 
			this.part2MotorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.part2MotorTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
			this.part2MotorTextBox.Location = new System.Drawing.Point(169, 6);
			this.part2MotorTextBox.MaxLength = 6;
			this.part2MotorTextBox.Name = "part2MotorTextBox";
			this.part2MotorTextBox.Size = new System.Drawing.Size(67, 26);
			this.part2MotorTextBox.TabIndex = 1;
			this.part2MotorTextBox.Tag = "";
			this.part2MotorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// part1MotorTextBox
			// 
			this.part1MotorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.part1MotorTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
			this.part1MotorTextBox.Location = new System.Drawing.Point(34, 6);
			this.part1MotorTextBox.MaxLength = 6;
			this.part1MotorTextBox.Name = "part1MotorTextBox";
			this.part1MotorTextBox.Size = new System.Drawing.Size(67, 26);
			this.part1MotorTextBox.TabIndex = 0;
			this.part1MotorTextBox.Tag = "";
			this.part1MotorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// malulinPlatePanel
			// 
			this.malulinPlatePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.malulinPlatePanel.Controls.Add(this.pictureBox1);
			this.malulinPlatePanel.Controls.Add(this.code2Numeric);
			this.malulinPlatePanel.Controls.Add(this.part2MaluinTextBox);
			this.malulinPlatePanel.Controls.Add(this.part1MalulinTextBox);
			this.malulinPlatePanel.Location = new System.Drawing.Point(21, 62);
			this.malulinPlatePanel.Name = "malulinPlatePanel";
			this.malulinPlatePanel.Size = new System.Drawing.Size(295, 46);
			this.malulinPlatePanel.TabIndex = 3;
			this.malulinPlatePanel.Visible = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackgroundImage = global::GasStation.Properties.Resources.malulin_;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(114, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(45, 35);
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			// 
			// code2Numeric
			// 
			this.code2Numeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.code2Numeric.Items.Add("79");
			this.code2Numeric.Location = new System.Drawing.Point(241, 5);
			this.code2Numeric.Name = "code2Numeric";
			this.code2Numeric.Size = new System.Drawing.Size(49, 26);
			this.code2Numeric.TabIndex = 2;
			this.code2Numeric.Tag = "plateCityId";
			this.code2Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// part2MaluinTextBox
			// 
			this.part2MaluinTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.part2MaluinTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
			this.part2MaluinTextBox.Location = new System.Drawing.Point(169, 5);
			this.part2MaluinTextBox.MaxLength = 3;
			this.part2MaluinTextBox.Name = "part2MaluinTextBox";
			this.part2MaluinTextBox.Size = new System.Drawing.Size(67, 26);
			this.part2MaluinTextBox.TabIndex = 1;
			this.part2MaluinTextBox.Tag = "";
			this.part2MaluinTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// part1MalulinTextBox
			// 
			this.part1MalulinTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.part1MalulinTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
			this.part1MalulinTextBox.Location = new System.Drawing.Point(34, 5);
			this.part1MalulinTextBox.MaxLength = 2;
			this.part1MalulinTextBox.Name = "part1MalulinTextBox";
			this.part1MalulinTextBox.Size = new System.Drawing.Size(67, 26);
			this.part1MalulinTextBox.TabIndex = 0;
			this.part1MalulinTextBox.Tag = "";
			this.part1MalulinTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ReportTrafficForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(775, 640);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.groupBox1);
			this.Name = "ReportTrafficForm";
			this.Text = "TrafficForm";
			this.tabControl1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.plateDataGroupBox.ResumeLayout(false);
			this.mainPlatePanel.ResumeLayout(false);
			this.mainPlatePanel.PerformLayout();
			this.motorPlatePanel.ResumeLayout(false);
			this.motorPlatePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.malulinPlatePanel.ResumeLayout(false);
			this.malulinPlatePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.MaskedTextBox dateStartMaskedTextBox;
		private System.Windows.Forms.MaskedTextBox dateEndMaskedTextBox;
		private System.Windows.Forms.Button printButton;
		private System.Windows.Forms.Button showButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage stateTabPage;
		private System.Windows.Forms.TabPage countTabPage;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox typeComboBox;
		private System.Windows.Forms.GroupBox plateDataGroupBox;
		private System.Windows.Forms.MaskedTextBox nationalCodeMaskedTextBox;
		private System.Windows.Forms.Panel mainPlatePanel;
		private System.Windows.Forms.DomainUpDown code1Numeric;
		private System.Windows.Forms.TextBox part2MainTextBox;
		private System.Windows.Forms.DomainUpDown characterDomainUpDown;
		private System.Windows.Forms.TextBox part1MainTextBox;
		private System.Windows.Forms.ComboBox plateTypeComboBox;
		private System.Windows.Forms.Panel motorPlatePanel;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.TextBox part2MotorTextBox;
		private System.Windows.Forms.TextBox part1MotorTextBox;
		private System.Windows.Forms.Panel malulinPlatePanel;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DomainUpDown code2Numeric;
		private System.Windows.Forms.TextBox part2MaluinTextBox;
		private System.Windows.Forms.TextBox part1MalulinTextBox;
	}
}