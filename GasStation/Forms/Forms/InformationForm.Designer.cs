namespace GasStation.Forms.Forms
{
	partial class InformationForm
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
			this.ownerTabControl = new System.Windows.Forms.TabControl();
			this.ownerTabPage = new System.Windows.Forms.TabPage();
			this.nextOwnerButton = new System.Windows.Forms.Button();
			this.ownerDataGroupBox = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.birthdateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.genComboBox = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.addressTextBox = new System.Windows.Forms.TextBox();
			this.mobileTextBox = new System.Windows.Forms.TextBox();
			this.phoneTextBox = new System.Windows.Forms.TextBox();
			this.birthdatelocalTextBox = new System.Windows.Forms.TextBox();
			this.nationalCodeTextBox = new System.Windows.Forms.TextBox();
			this.lastnameTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.carTabPage = new System.Windows.Forms.TabPage();
			this.button9 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.carDataGroupBox = new System.Windows.Forms.GroupBox();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.carFuelButton = new System.Windows.Forms.Button();
			this.carSystemButton = new System.Windows.Forms.Button();
			this.carLevelButton = new System.Windows.Forms.Button();
			this.carTypeButton = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.carLevelComboBox = new System.Windows.Forms.ComboBox();
			this.carSystemComboBox = new System.Windows.Forms.ComboBox();
			this.carTypeComboBox = new System.Windows.Forms.ComboBox();
			this.carFuelComboBox = new System.Windows.Forms.ComboBox();
			this.carColorComboBox = new System.Windows.Forms.ComboBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.chasisCodeTextBox = new System.Windows.Forms.TextBox();
			this.engineCodeTextBox = new System.Windows.Forms.TextBox();
			this.capacityTextBox = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.plateTabPage = new System.Windows.Forms.TabPage();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.plateDataGroupBox = new System.Windows.Forms.GroupBox();
			this.domainUpDown3 = new System.Windows.Forms.DomainUpDown();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
			this.button10 = new System.Windows.Forms.Button();
			this.label20 = new System.Windows.Forms.Label();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label27 = new System.Windows.Forms.Label();
			this.ownerTypeTabPage = new System.Windows.Forms.TabPage();
			this.button8 = new System.Windows.Forms.Button();
			this.ownerTypeDataGroupBox = new System.Windows.Forms.GroupBox();
			this.legalOwnerGroupBox = new System.Windows.Forms.GroupBox();
			this.orgNameTextBox = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.OrganizationCodeTextBox = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.legalRadioButton = new System.Windows.Forms.RadioButton();
			this.realRadioButton = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.ownerTabControl.SuspendLayout();
			this.ownerTabPage.SuspendLayout();
			this.ownerDataGroupBox.SuspendLayout();
			this.carTabPage.SuspendLayout();
			this.carDataGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.plateTabPage.SuspendLayout();
			this.plateDataGroupBox.SuspendLayout();
			this.ownerTypeTabPage.SuspendLayout();
			this.ownerTypeDataGroupBox.SuspendLayout();
			this.legalOwnerGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.BackgroundImage = global::GasStation.Properties.Resources.formBK;
			this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.groupBox1.Controls.Add(this.ownerTabControl);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(724, 568);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "ثبت اطلاعات";
			// 
			// ownerTabControl
			// 
			this.ownerTabControl.Controls.Add(this.ownerTabPage);
			this.ownerTabControl.Controls.Add(this.carTabPage);
			this.ownerTabControl.Controls.Add(this.plateTabPage);
			this.ownerTabControl.Controls.Add(this.ownerTypeTabPage);
			this.ownerTabControl.Location = new System.Drawing.Point(14, 27);
			this.ownerTabControl.Name = "ownerTabControl";
			this.ownerTabControl.RightToLeftLayout = true;
			this.ownerTabControl.SelectedIndex = 0;
			this.ownerTabControl.Size = new System.Drawing.Size(700, 528);
			this.ownerTabControl.TabIndex = 0;
			// 
			// ownerTabPage
			// 
			this.ownerTabPage.BackgroundImage = global::GasStation.Properties.Resources.formBK;
			this.ownerTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ownerTabPage.Controls.Add(this.nextOwnerButton);
			this.ownerTabPage.Controls.Add(this.ownerDataGroupBox);
			this.ownerTabPage.Location = new System.Drawing.Point(4, 27);
			this.ownerTabPage.Name = "ownerTabPage";
			this.ownerTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.ownerTabPage.Size = new System.Drawing.Size(692, 497);
			this.ownerTabPage.TabIndex = 0;
			this.ownerTabPage.Text = "راننده";
			this.ownerTabPage.UseVisualStyleBackColor = true;
			// 
			// nextOwnerButton
			// 
			this.nextOwnerButton.BackgroundImage = global::GasStation.Properties.Resources.previous;
			this.nextOwnerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.nextOwnerButton.Location = new System.Drawing.Point(16, 412);
			this.nextOwnerButton.Name = "nextOwnerButton";
			this.nextOwnerButton.Size = new System.Drawing.Size(82, 72);
			this.nextOwnerButton.TabIndex = 1;
			this.nextOwnerButton.UseVisualStyleBackColor = true;
			// 
			// ownerDataGroupBox
			// 
			this.ownerDataGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ownerDataGroupBox.BackColor = System.Drawing.Color.Transparent;
			this.ownerDataGroupBox.Controls.Add(this.label9);
			this.ownerDataGroupBox.Controls.Add(this.birthdateMaskedTextBox);
			this.ownerDataGroupBox.Controls.Add(this.label8);
			this.ownerDataGroupBox.Controls.Add(this.label7);
			this.ownerDataGroupBox.Controls.Add(this.label6);
			this.ownerDataGroupBox.Controls.Add(this.genComboBox);
			this.ownerDataGroupBox.Controls.Add(this.label5);
			this.ownerDataGroupBox.Controls.Add(this.label4);
			this.ownerDataGroupBox.Controls.Add(this.label3);
			this.ownerDataGroupBox.Controls.Add(this.addressTextBox);
			this.ownerDataGroupBox.Controls.Add(this.mobileTextBox);
			this.ownerDataGroupBox.Controls.Add(this.phoneTextBox);
			this.ownerDataGroupBox.Controls.Add(this.birthdatelocalTextBox);
			this.ownerDataGroupBox.Controls.Add(this.nationalCodeTextBox);
			this.ownerDataGroupBox.Controls.Add(this.lastnameTextBox);
			this.ownerDataGroupBox.Controls.Add(this.label2);
			this.ownerDataGroupBox.Controls.Add(this.nameTextBox);
			this.ownerDataGroupBox.Controls.Add(this.label1);
			this.ownerDataGroupBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
			this.ownerDataGroupBox.Location = new System.Drawing.Point(16, 20);
			this.ownerDataGroupBox.Name = "ownerDataGroupBox";
			this.ownerDataGroupBox.Size = new System.Drawing.Size(658, 384);
			this.ownerDataGroupBox.TabIndex = 0;
			this.ownerDataGroupBox.TabStop = false;
			this.ownerDataGroupBox.Text = "اطلاعات راننده";
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.AutoSize = true;
			this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label9.Location = new System.Drawing.Point(482, 323);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(42, 18);
			this.label9.TabIndex = 6;
			this.label9.Text = "آدرس";
			//this.label9.Click += new System.EventHandler(this.label9_Click);
			// 
			// birthdateMaskedTextBox
			// 
			this.birthdateMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.birthdateMaskedTextBox.Location = new System.Drawing.Point(163, 187);
			this.birthdateMaskedTextBox.Mask = "0000/00/00";
			this.birthdateMaskedTextBox.Name = "birthdateMaskedTextBox";
			this.birthdateMaskedTextBox.Size = new System.Drawing.Size(256, 26);
			this.birthdateMaskedTextBox.TabIndex = 4;
			this.birthdateMaskedTextBox.Tag = "birthdate";
			this.birthdateMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label8.Location = new System.Drawing.Point(447, 290);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(77, 18);
			this.label8.TabIndex = 4;
			this.label8.Text = "تلفن همراه";
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label7.Location = new System.Drawing.Point(457, 257);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(67, 18);
			this.label7.TabIndex = 4;
			this.label7.Text = "تلفن ثابت";
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label6.Location = new System.Drawing.Point(459, 224);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(65, 18);
			this.label6.TabIndex = 4;
			this.label6.Text = "محل تولد";
			// 
			// genComboBox
			// 
			this.genComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.genComboBox.FormattingEnabled = true;
			this.genComboBox.Location = new System.Drawing.Point(163, 155);
			this.genComboBox.Name = "genComboBox";
			this.genComboBox.Size = new System.Drawing.Size(256, 26);
			this.genComboBox.TabIndex = 3;
			this.genComboBox.Tag = "gen";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label5.Location = new System.Drawing.Point(460, 191);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 18);
			this.label5.TabIndex = 2;
			this.label5.Text = "تاریخ تولد";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label4.Location = new System.Drawing.Point(466, 158);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 18);
			this.label4.TabIndex = 2;
			this.label4.Text = "جنسیت";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(468, 125);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "کد ملی";
			// 
			// addressTextBox
			// 
			this.addressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.addressTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
			this.addressTextBox.Location = new System.Drawing.Point(163, 315);
			this.addressTextBox.MaxLength = 50;
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.Size = new System.Drawing.Size(256, 26);
			this.addressTextBox.TabIndex = 8;
			this.addressTextBox.Tag = "address";
			this.addressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.addressTextBox.UseSystemPasswordChar = true;
			// 
			// mobileTextBox
			// 
			this.mobileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mobileTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
			this.mobileTextBox.Location = new System.Drawing.Point(163, 283);
			this.mobileTextBox.MaxLength = 50;
			this.mobileTextBox.Name = "mobileTextBox";
			this.mobileTextBox.Size = new System.Drawing.Size(256, 26);
			this.mobileTextBox.TabIndex = 7;
			this.mobileTextBox.Tag = "mobile";
			this.mobileTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.mobileTextBox.UseSystemPasswordChar = true;
			// 
			// phoneTextBox
			// 
			this.phoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.phoneTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
			this.phoneTextBox.Location = new System.Drawing.Point(163, 251);
			this.phoneTextBox.MaxLength = 50;
			this.phoneTextBox.Name = "phoneTextBox";
			this.phoneTextBox.Size = new System.Drawing.Size(256, 26);
			this.phoneTextBox.TabIndex = 6;
			this.phoneTextBox.Tag = "phone";
			this.phoneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.phoneTextBox.UseSystemPasswordChar = true;
			// 
			// birthdatelocalTextBox
			// 
			this.birthdatelocalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.birthdatelocalTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
			this.birthdatelocalTextBox.Location = new System.Drawing.Point(163, 219);
			this.birthdatelocalTextBox.MaxLength = 50;
			this.birthdatelocalTextBox.Name = "birthdatelocalTextBox";
			this.birthdatelocalTextBox.Size = new System.Drawing.Size(256, 26);
			this.birthdatelocalTextBox.TabIndex = 5;
			this.birthdatelocalTextBox.Tag = "birthdatelocal";
			this.birthdatelocalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.birthdatelocalTextBox.UseSystemPasswordChar = true;
			// 
			// nationalCodeTextBox
			// 
			this.nationalCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.nationalCodeTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
			this.nationalCodeTextBox.Location = new System.Drawing.Point(163, 123);
			this.nationalCodeTextBox.MaxLength = 10;
			this.nationalCodeTextBox.Name = "nationalCodeTextBox";
			this.nationalCodeTextBox.Size = new System.Drawing.Size(256, 26);
			this.nationalCodeTextBox.TabIndex = 2;
			this.nationalCodeTextBox.Tag = "nationalCode";
			this.nationalCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nationalCodeTextBox.UseSystemPasswordChar = true;
			// 
			// lastnameTextBox
			// 
			this.lastnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lastnameTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lastnameTextBox.Location = new System.Drawing.Point(163, 91);
			this.lastnameTextBox.MaxLength = 50;
			this.lastnameTextBox.Name = "lastnameTextBox";
			this.lastnameTextBox.Size = new System.Drawing.Size(256, 26);
			this.lastnameTextBox.TabIndex = 1;
			this.lastnameTextBox.Tag = "lastname";
			this.lastnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.lastnameTextBox.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(436, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 18);
			this.label2.TabIndex = 0;
			this.label2.Text = "نام خانوادگی";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.nameTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
			this.nameTextBox.Location = new System.Drawing.Point(163, 59);
			this.nameTextBox.MaxLength = 50;
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(256, 26);
			this.nameTextBox.TabIndex = 0;
			this.nameTextBox.Tag = "name";
			this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(499, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(25, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "نام";
			// 
			// carTabPage
			// 
			this.carTabPage.BackgroundImage = global::GasStation.Properties.Resources.formBK;
			this.carTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.carTabPage.Controls.Add(this.button9);
			this.carTabPage.Controls.Add(this.button1);
			this.carTabPage.Controls.Add(this.carDataGroupBox);
			this.carTabPage.Location = new System.Drawing.Point(4, 27);
			this.carTabPage.Name = "carTabPage";
			this.carTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.carTabPage.Size = new System.Drawing.Size(692, 497);
			this.carTabPage.TabIndex = 1;
			this.carTabPage.Text = "خودرو";
			this.carTabPage.UseVisualStyleBackColor = true;
			// 
			// button9
			// 
			this.button9.BackgroundImage = global::GasStation.Properties.Resources.next;
			this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button9.Location = new System.Drawing.Point(593, 412);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(82, 72);
			this.button9.TabIndex = 6;
			this.button9.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.BackgroundImage = global::GasStation.Properties.Resources.previous;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button1.Location = new System.Drawing.Point(16, 412);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(82, 72);
			this.button1.TabIndex = 2;
			this.button1.UseVisualStyleBackColor = true;
			// 
			// carDataGroupBox
			// 
			this.carDataGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.carDataGroupBox.BackColor = System.Drawing.Color.Transparent;
			this.carDataGroupBox.Controls.Add(this.numericUpDown1);
			this.carDataGroupBox.Controls.Add(this.carFuelButton);
			this.carDataGroupBox.Controls.Add(this.carSystemButton);
			this.carDataGroupBox.Controls.Add(this.carLevelButton);
			this.carDataGroupBox.Controls.Add(this.carTypeButton);
			this.carDataGroupBox.Controls.Add(this.label10);
			this.carDataGroupBox.Controls.Add(this.label11);
			this.carDataGroupBox.Controls.Add(this.label12);
			this.carDataGroupBox.Controls.Add(this.label13);
			this.carDataGroupBox.Controls.Add(this.carLevelComboBox);
			this.carDataGroupBox.Controls.Add(this.carSystemComboBox);
			this.carDataGroupBox.Controls.Add(this.carTypeComboBox);
			this.carDataGroupBox.Controls.Add(this.carFuelComboBox);
			this.carDataGroupBox.Controls.Add(this.carColorComboBox);
			this.carDataGroupBox.Controls.Add(this.label14);
			this.carDataGroupBox.Controls.Add(this.label15);
			this.carDataGroupBox.Controls.Add(this.label16);
			this.carDataGroupBox.Controls.Add(this.chasisCodeTextBox);
			this.carDataGroupBox.Controls.Add(this.engineCodeTextBox);
			this.carDataGroupBox.Controls.Add(this.capacityTextBox);
			this.carDataGroupBox.Controls.Add(this.label17);
			this.carDataGroupBox.Controls.Add(this.label18);
			this.carDataGroupBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
			this.carDataGroupBox.Location = new System.Drawing.Point(16, 20);
			this.carDataGroupBox.Name = "carDataGroupBox";
			this.carDataGroupBox.Size = new System.Drawing.Size(658, 384);
			this.carDataGroupBox.TabIndex = 1;
			this.carDataGroupBox.TabStop = false;
			this.carDataGroupBox.Text = "اطلاعات خودرو";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(178, 183);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(256, 26);
			this.numericUpDown1.TabIndex = 10;
			this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// carFuelButton
			// 
			this.carFuelButton.BackColor = System.Drawing.Color.White;
			this.carFuelButton.BackgroundImage = global::GasStation.Properties.Resources.add;
			this.carFuelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.carFuelButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.carFuelButton.Location = new System.Drawing.Point(139, 217);
			this.carFuelButton.Name = "carFuelButton";
			this.carFuelButton.Size = new System.Drawing.Size(33, 26);
			this.carFuelButton.TabIndex = 9;
			this.carFuelButton.UseVisualStyleBackColor = false;
			// 
			// carSystemButton
			// 
			this.carSystemButton.BackColor = System.Drawing.Color.White;
			this.carSystemButton.BackgroundImage = global::GasStation.Properties.Resources.add;
			this.carSystemButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.carSystemButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.carSystemButton.Location = new System.Drawing.Point(139, 89);
			this.carSystemButton.Name = "carSystemButton";
			this.carSystemButton.Size = new System.Drawing.Size(33, 26);
			this.carSystemButton.TabIndex = 9;
			this.carSystemButton.UseVisualStyleBackColor = false;
			// 
			// carLevelButton
			// 
			this.carLevelButton.BackColor = System.Drawing.Color.White;
			this.carLevelButton.BackgroundImage = global::GasStation.Properties.Resources.add;
			this.carLevelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.carLevelButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.carLevelButton.Location = new System.Drawing.Point(139, 121);
			this.carLevelButton.Name = "carLevelButton";
			this.carLevelButton.Size = new System.Drawing.Size(33, 26);
			this.carLevelButton.TabIndex = 9;
			this.carLevelButton.UseVisualStyleBackColor = false;
			// 
			// carTypeButton
			// 
			this.carTypeButton.BackColor = System.Drawing.Color.White;
			this.carTypeButton.BackgroundImage = global::GasStation.Properties.Resources.add;
			this.carTypeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.carTypeButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.carTypeButton.Location = new System.Drawing.Point(139, 57);
			this.carTypeButton.Name = "carTypeButton";
			this.carTypeButton.Size = new System.Drawing.Size(33, 26);
			this.carTypeButton.TabIndex = 9;
			this.carTypeButton.UseVisualStyleBackColor = false;
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label10.Location = new System.Drawing.Point(497, 252);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(49, 18);
			this.label10.TabIndex = 6;
			this.label10.Text = "ظرفیت";
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label11.Location = new System.Drawing.Point(444, 316);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(102, 18);
			this.label11.TabIndex = 4;
			this.label11.Text = "شماره شاسی";
			// 
			// label12
			// 
			this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label12.Location = new System.Drawing.Point(462, 284);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(84, 18);
			this.label12.TabIndex = 4;
			this.label12.Text = "شماره موتور";
			// 
			// label13
			// 
			this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label13.Location = new System.Drawing.Point(467, 220);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(79, 18);
			this.label13.TabIndex = 4;
			this.label13.Text = "نوع سوخت";
			// 
			// carLevelComboBox
			// 
			this.carLevelComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.carLevelComboBox.FormattingEnabled = true;
			this.carLevelComboBox.Location = new System.Drawing.Point(178, 121);
			this.carLevelComboBox.Name = "carLevelComboBox";
			this.carLevelComboBox.Size = new System.Drawing.Size(256, 26);
			this.carLevelComboBox.TabIndex = 3;
			this.carLevelComboBox.Tag = "";
			// 
			// carSystemComboBox
			// 
			this.carSystemComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.carSystemComboBox.FormattingEnabled = true;
			this.carSystemComboBox.Location = new System.Drawing.Point(178, 88);
			this.carSystemComboBox.Name = "carSystemComboBox";
			this.carSystemComboBox.Size = new System.Drawing.Size(256, 26);
			this.carSystemComboBox.TabIndex = 3;
			this.carSystemComboBox.Tag = "";
			// 
			// carTypeComboBox
			// 
			this.carTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.carTypeComboBox.FormattingEnabled = true;
			this.carTypeComboBox.Location = new System.Drawing.Point(178, 57);
			this.carTypeComboBox.Name = "carTypeComboBox";
			this.carTypeComboBox.Size = new System.Drawing.Size(256, 26);
			this.carTypeComboBox.TabIndex = 3;
			this.carTypeComboBox.Tag = "";
			// 
			// carFuelComboBox
			// 
			this.carFuelComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.carFuelComboBox.FormattingEnabled = true;
			this.carFuelComboBox.Location = new System.Drawing.Point(178, 217);
			this.carFuelComboBox.Name = "carFuelComboBox";
			this.carFuelComboBox.Size = new System.Drawing.Size(256, 26);
			this.carFuelComboBox.TabIndex = 3;
			this.carFuelComboBox.Tag = "";
			// 
			// carColorComboBox
			// 
			this.carColorComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.carColorComboBox.FormattingEnabled = true;
			this.carColorComboBox.Location = new System.Drawing.Point(178, 153);
			this.carColorComboBox.Name = "carColorComboBox";
			this.carColorComboBox.Size = new System.Drawing.Size(256, 26);
			this.carColorComboBox.TabIndex = 3;
			this.carColorComboBox.Tag = "";
			// 
			// label14
			// 
			this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label14.Location = new System.Drawing.Point(512, 188);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(34, 18);
			this.label14.TabIndex = 2;
			this.label14.Text = "مدل";
			// 
			// label15
			// 
			this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label15.Location = new System.Drawing.Point(514, 156);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(32, 18);
			this.label15.TabIndex = 2;
			this.label15.Text = "رنگ";
			// 
			// label16
			// 
			this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label16.Location = new System.Drawing.Point(503, 124);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(43, 18);
			this.label16.TabIndex = 2;
			this.label16.Text = "تیـــپ";
			// 
			// chasisCodeTextBox
			// 
			this.chasisCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chasisCodeTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chasisCodeTextBox.Location = new System.Drawing.Point(178, 313);
			this.chasisCodeTextBox.MaxLength = 50;
			this.chasisCodeTextBox.Name = "chasisCodeTextBox";
			this.chasisCodeTextBox.Size = new System.Drawing.Size(256, 26);
			this.chasisCodeTextBox.TabIndex = 8;
			this.chasisCodeTextBox.Tag = "chasisCode";
			this.chasisCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.chasisCodeTextBox.UseSystemPasswordChar = true;
			// 
			// engineCodeTextBox
			// 
			this.engineCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.engineCodeTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
			this.engineCodeTextBox.Location = new System.Drawing.Point(178, 281);
			this.engineCodeTextBox.MaxLength = 50;
			this.engineCodeTextBox.Name = "engineCodeTextBox";
			this.engineCodeTextBox.Size = new System.Drawing.Size(256, 26);
			this.engineCodeTextBox.TabIndex = 7;
			this.engineCodeTextBox.Tag = "engineCode";
			this.engineCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.engineCodeTextBox.UseSystemPasswordChar = true;
			// 
			// capacityTextBox
			// 
			this.capacityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.capacityTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
			this.capacityTextBox.Location = new System.Drawing.Point(178, 249);
			this.capacityTextBox.MaxLength = 50;
			this.capacityTextBox.Name = "capacityTextBox";
			this.capacityTextBox.Size = new System.Drawing.Size(256, 26);
			this.capacityTextBox.TabIndex = 6;
			this.capacityTextBox.Tag = "capacity";
			this.capacityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.capacityTextBox.UseSystemPasswordChar = true;
			// 
			// label17
			// 
			this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label17.Location = new System.Drawing.Point(487, 92);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(59, 18);
			this.label17.TabIndex = 0;
			this.label17.Text = "سیستم";
			// 
			// label18
			// 
			this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label18.Location = new System.Drawing.Point(518, 60);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(28, 18);
			this.label18.TabIndex = 0;
			this.label18.Text = "نوع";
			// 
			// plateTabPage
			// 
			this.plateTabPage.BackgroundImage = global::GasStation.Properties.Resources.formBK;
			this.plateTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.plateTabPage.Controls.Add(this.button7);
			this.plateTabPage.Controls.Add(this.button6);
			this.plateTabPage.Controls.Add(this.plateDataGroupBox);
			this.plateTabPage.Location = new System.Drawing.Point(4, 27);
			this.plateTabPage.Name = "plateTabPage";
			this.plateTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.plateTabPage.Size = new System.Drawing.Size(692, 497);
			this.plateTabPage.TabIndex = 2;
			this.plateTabPage.Text = "پلاک";
			this.plateTabPage.UseVisualStyleBackColor = true;
			// 
			// button7
			// 
			this.button7.BackgroundImage = global::GasStation.Properties.Resources.next;
			this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button7.Location = new System.Drawing.Point(593, 412);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(82, 72);
			this.button7.TabIndex = 5;
			this.button7.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.BackgroundImage = global::GasStation.Properties.Resources.previous;
			this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button6.Location = new System.Drawing.Point(16, 412);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(82, 72);
			this.button6.TabIndex = 4;
			this.button6.UseVisualStyleBackColor = true;
			// 
			// plateDataGroupBox
			// 
			this.plateDataGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.plateDataGroupBox.BackColor = System.Drawing.Color.Transparent;
			this.plateDataGroupBox.Controls.Add(this.domainUpDown3);
			this.plateDataGroupBox.Controls.Add(this.textBox2);
			this.plateDataGroupBox.Controls.Add(this.domainUpDown2);
			this.plateDataGroupBox.Controls.Add(this.button10);
			this.plateDataGroupBox.Controls.Add(this.label20);
			this.plateDataGroupBox.Controls.Add(this.comboBox3);
			this.plateDataGroupBox.Controls.Add(this.textBox1);
			this.plateDataGroupBox.Controls.Add(this.label27);
			this.plateDataGroupBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
			this.plateDataGroupBox.Location = new System.Drawing.Point(17, 13);
			this.plateDataGroupBox.Name = "plateDataGroupBox";
			this.plateDataGroupBox.Size = new System.Drawing.Size(658, 384);
			this.plateDataGroupBox.TabIndex = 3;
			this.plateDataGroupBox.TabStop = false;
			this.plateDataGroupBox.Text = "اطلاعات پلاک";
			// 
			// domainUpDown3
			// 
			this.domainUpDown3.Items.Add("79");
			this.domainUpDown3.Location = new System.Drawing.Point(397, 104);
			this.domainUpDown3.Name = "domainUpDown3";
			this.domainUpDown3.Size = new System.Drawing.Size(49, 26);
			this.domainUpDown3.TabIndex = 12;
			this.domainUpDown3.Text = "79";
			// 
			// textBox2
			// 
			this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.textBox2.Location = new System.Drawing.Point(325, 104);
			this.textBox2.MaxLength = 3;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(67, 26);
			this.textBox2.TabIndex = 11;
			this.textBox2.Tag = "chasisCode";
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox2.UseSystemPasswordChar = true;
			// 
			// domainUpDown2
			// 
			this.domainUpDown2.Items.Add("الف");
			this.domainUpDown2.Items.Add("ب");
			this.domainUpDown2.Items.Add("پ");
			this.domainUpDown2.Location = new System.Drawing.Point(262, 104);
			this.domainUpDown2.Name = "domainUpDown2";
			this.domainUpDown2.Size = new System.Drawing.Size(58, 26);
			this.domainUpDown2.TabIndex = 10;
			this.domainUpDown2.Text = "الف";
			// 
			// button10
			// 
			this.button10.BackColor = System.Drawing.Color.White;
			this.button10.BackgroundImage = global::GasStation.Properties.Resources.add;
			this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button10.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button10.Location = new System.Drawing.Point(151, 71);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(33, 26);
			this.button10.TabIndex = 9;
			this.button10.UseVisualStyleBackColor = false;
			// 
			// label20
			// 
			this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label20.AutoSize = true;
			this.label20.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label20.Location = new System.Drawing.Point(467, 107);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(82, 18);
			this.label20.TabIndex = 4;
			this.label20.Text = "شماره پلاک";
			// 
			// comboBox3
			// 
			this.comboBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(190, 72);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(256, 26);
			this.comboBox3.TabIndex = 3;
			this.comboBox3.Tag = "";
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.textBox1.Location = new System.Drawing.Point(190, 104);
			this.textBox1.MaxLength = 2;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(67, 26);
			this.textBox1.TabIndex = 8;
			this.textBox1.Tag = "chasisCode";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox1.UseSystemPasswordChar = true;
			// 
			// label27
			// 
			this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label27.AutoSize = true;
			this.label27.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label27.Location = new System.Drawing.Point(521, 72);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(28, 18);
			this.label27.TabIndex = 0;
			this.label27.Text = "نوع";
			// 
			// ownerTypeTabPage
			// 
			this.ownerTypeTabPage.BackgroundImage = global::GasStation.Properties.Resources.formBK;
			this.ownerTypeTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ownerTypeTabPage.Controls.Add(this.button8);
			this.ownerTypeTabPage.Controls.Add(this.ownerTypeDataGroupBox);
			this.ownerTypeTabPage.Location = new System.Drawing.Point(4, 27);
			this.ownerTypeTabPage.Name = "ownerTypeTabPage";
			this.ownerTypeTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.ownerTypeTabPage.Size = new System.Drawing.Size(692, 497);
			this.ownerTypeTabPage.TabIndex = 3;
			this.ownerTypeTabPage.Text = "مالک";
			this.ownerTypeTabPage.UseVisualStyleBackColor = true;
			// 
			// button8
			// 
			this.button8.BackgroundImage = global::GasStation.Properties.Resources.next;
			this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button8.Location = new System.Drawing.Point(593, 412);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(82, 72);
			this.button8.TabIndex = 6;
			this.button8.UseVisualStyleBackColor = true;
			// 
			// ownerTypeDataGroupBox
			// 
			this.ownerTypeDataGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ownerTypeDataGroupBox.BackColor = System.Drawing.Color.Transparent;
			this.ownerTypeDataGroupBox.Controls.Add(this.legalOwnerGroupBox);
			this.ownerTypeDataGroupBox.Controls.Add(this.legalRadioButton);
			this.ownerTypeDataGroupBox.Controls.Add(this.realRadioButton);
			this.ownerTypeDataGroupBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
			this.ownerTypeDataGroupBox.Location = new System.Drawing.Point(17, 12);
			this.ownerTypeDataGroupBox.Name = "ownerTypeDataGroupBox";
			this.ownerTypeDataGroupBox.Size = new System.Drawing.Size(658, 384);
			this.ownerTypeDataGroupBox.TabIndex = 4;
			this.ownerTypeDataGroupBox.TabStop = false;
			this.ownerTypeDataGroupBox.Text = "اطلاعات مالک";
			// 
			// legalOwnerGroupBox
			// 
			this.legalOwnerGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.legalOwnerGroupBox.BackColor = System.Drawing.Color.Transparent;
			this.legalOwnerGroupBox.Controls.Add(this.orgNameTextBox);
			this.legalOwnerGroupBox.Controls.Add(this.label21);
			this.legalOwnerGroupBox.Controls.Add(this.OrganizationCodeTextBox);
			this.legalOwnerGroupBox.Controls.Add(this.label19);
			this.legalOwnerGroupBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
			this.legalOwnerGroupBox.Location = new System.Drawing.Point(24, 136);
			this.legalOwnerGroupBox.Name = "legalOwnerGroupBox";
			this.legalOwnerGroupBox.Size = new System.Drawing.Size(613, 229);
			this.legalOwnerGroupBox.TabIndex = 5;
			this.legalOwnerGroupBox.TabStop = false;
			this.legalOwnerGroupBox.Text = "اطلاعات مالک حقوقی";
			// 
			// orgNameTextBox
			// 
			this.orgNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.orgNameTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
			this.orgNameTextBox.Location = new System.Drawing.Point(86, 119);
			this.orgNameTextBox.MaxLength = 50;
			this.orgNameTextBox.Name = "orgNameTextBox";
			this.orgNameTextBox.Size = new System.Drawing.Size(256, 26);
			this.orgNameTextBox.TabIndex = 8;
			this.orgNameTextBox.Tag = "name";
			this.orgNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.orgNameTextBox.UseSystemPasswordChar = true;
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.ForeColor = System.Drawing.Color.Black;
			this.label21.Location = new System.Drawing.Point(460, 122);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(76, 18);
			this.label21.TabIndex = 0;
			this.label21.Text = "نام سازمان";
			// 
			// OrganizationCodeTextBox
			// 
			this.OrganizationCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.OrganizationCodeTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
			this.OrganizationCodeTextBox.Location = new System.Drawing.Point(86, 87);
			this.OrganizationCodeTextBox.MaxLength = 50;
			this.OrganizationCodeTextBox.Name = "OrganizationCodeTextBox";
			this.OrganizationCodeTextBox.Size = new System.Drawing.Size(256, 26);
			this.OrganizationCodeTextBox.TabIndex = 8;
			this.OrganizationCodeTextBox.Tag = "OrganizationCode";
			this.OrganizationCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.OrganizationCodeTextBox.UseSystemPasswordChar = true;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.ForeColor = System.Drawing.Color.Black;
			this.label19.Location = new System.Drawing.Point(395, 90);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(141, 18);
			this.label19.TabIndex = 0;
			this.label19.Text = "کد شناسایی سازمان";
			// 
			// legalRadioButton
			// 
			this.legalRadioButton.AutoSize = true;
			this.legalRadioButton.ForeColor = System.Drawing.Color.Black;
			this.legalRadioButton.Location = new System.Drawing.Point(205, 52);
			this.legalRadioButton.Name = "legalRadioButton";
			this.legalRadioButton.Size = new System.Drawing.Size(75, 22);
			this.legalRadioButton.TabIndex = 1;
			this.legalRadioButton.TabStop = true;
			this.legalRadioButton.Text = "حقوقی";
			this.legalRadioButton.UseVisualStyleBackColor = true;
			// 
			// realRadioButton
			// 
			this.realRadioButton.AutoSize = true;
			this.realRadioButton.ForeColor = System.Drawing.Color.Black;
			this.realRadioButton.Location = new System.Drawing.Point(400, 52);
			this.realRadioButton.Name = "realRadioButton";
			this.realRadioButton.Size = new System.Drawing.Size(75, 22);
			this.realRadioButton.TabIndex = 0;
			this.realRadioButton.TabStop = true;
			this.realRadioButton.Text = "حقیقی";
			this.realRadioButton.UseVisualStyleBackColor = true;
			// 
			// InformationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = global::GasStation.Properties.Resources.formBK;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(749, 586);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "InformationForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ثبت اطلاعات";
			this.groupBox1.ResumeLayout(false);
			this.ownerTabControl.ResumeLayout(false);
			this.ownerTabPage.ResumeLayout(false);
			this.ownerDataGroupBox.ResumeLayout(false);
			this.ownerDataGroupBox.PerformLayout();
			this.carTabPage.ResumeLayout(false);
			this.carDataGroupBox.ResumeLayout(false);
			this.carDataGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.plateTabPage.ResumeLayout(false);
			this.plateDataGroupBox.ResumeLayout(false);
			this.plateDataGroupBox.PerformLayout();
			this.ownerTypeTabPage.ResumeLayout(false);
			this.ownerTypeDataGroupBox.ResumeLayout(false);
			this.ownerTypeDataGroupBox.PerformLayout();
			this.legalOwnerGroupBox.ResumeLayout(false);
			this.legalOwnerGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TabControl ownerTabControl;
		private System.Windows.Forms.TabPage ownerTabPage;
		private System.Windows.Forms.TabPage carTabPage;
		private System.Windows.Forms.Button nextOwnerButton;
		private System.Windows.Forms.GroupBox ownerDataGroupBox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.MaskedTextBox birthdateMaskedTextBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox genComboBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox addressTextBox;
		private System.Windows.Forms.TextBox mobileTextBox;
		private System.Windows.Forms.TextBox phoneTextBox;
		private System.Windows.Forms.TextBox birthdatelocalTextBox;
		private System.Windows.Forms.TextBox nationalCodeTextBox;
		private System.Windows.Forms.TextBox lastnameTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox carDataGroupBox;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox carLevelComboBox;
		private System.Windows.Forms.ComboBox carSystemComboBox;
		private System.Windows.Forms.ComboBox carTypeComboBox;
		private System.Windows.Forms.ComboBox carColorComboBox;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox chasisCodeTextBox;
		private System.Windows.Forms.TextBox engineCodeTextBox;
		private System.Windows.Forms.TextBox capacityTextBox;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.ComboBox carFuelComboBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TabPage plateTabPage;
		private System.Windows.Forms.Button carTypeButton;
		private System.Windows.Forms.Button carFuelButton;
		private System.Windows.Forms.Button carLevelButton;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Button carSystemButton;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.GroupBox plateDataGroupBox;
		private System.Windows.Forms.DomainUpDown domainUpDown3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.DomainUpDown domainUpDown2;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.TabPage ownerTypeTabPage;
		private System.Windows.Forms.GroupBox ownerTypeDataGroupBox;
		private System.Windows.Forms.GroupBox legalOwnerGroupBox;
		private System.Windows.Forms.TextBox orgNameTextBox;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox OrganizationCodeTextBox;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.RadioButton legalRadioButton;
		private System.Windows.Forms.RadioButton realRadioButton;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
	}
}