namespace GasStation.Forms.Forms
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.mainMenu = new System.Windows.Forms.MenuStrip();
			this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logoffMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.baseInfoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.مدلخودروToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.carSystemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.carColorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.carTypeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.carLevelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.carFuelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.رنگخودروToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.plateCityMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.plateTypeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.customerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.customerShowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.reportCustomerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reportCarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reportTrafficMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.تنظیماتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.اطلاعاتکاربریToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.تنظیماتبرنامهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.تنظیماتآنتنToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.تنظیماتپیامکToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.راهنماToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
			this.versionToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.nameTtoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.dateToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.customerSerachMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenu.SuspendLayout();
			this.mainStatusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenu
			// 
			this.mainMenu.Font = new System.Drawing.Font("B Yekan", 12F);
			this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.baseInfoMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.تنظیماتToolStripMenuItem,
            this.راهنماToolStripMenuItem});
			this.mainMenu.Location = new System.Drawing.Point(0, 0);
			this.mainMenu.Name = "mainMenu";
			this.mainMenu.Size = new System.Drawing.Size(864, 38);
			this.mainMenu.TabIndex = 0;
			// 
			// fileMenuItem
			// 
			this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoffMenuItem,
            this.exitMenuItem});
			this.fileMenuItem.Name = "fileMenuItem";
			this.fileMenuItem.Size = new System.Drawing.Size(60, 34);
			this.fileMenuItem.Text = "فایل";
			// 
			// logoffMenuItem
			// 
			this.logoffMenuItem.Name = "logoffMenuItem";
			this.logoffMenuItem.Size = new System.Drawing.Size(165, 34);
			this.logoffMenuItem.Text = "تغییر کاربر";
			// 
			// exitMenuItem
			// 
			this.exitMenuItem.Name = "exitMenuItem";
			this.exitMenuItem.Size = new System.Drawing.Size(165, 34);
			this.exitMenuItem.Text = "خروج";
			// 
			// baseInfoMenuItem
			// 
			this.baseInfoMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مدلخودروToolStripMenuItem,
            this.رنگخودروToolStripMenuItem});
			this.baseInfoMenuItem.Name = "baseInfoMenuItem";
			this.baseInfoMenuItem.Size = new System.Drawing.Size(115, 34);
			this.baseInfoMenuItem.Text = "اطلاعات پایه";
			// 
			// مدلخودروToolStripMenuItem
			// 
			this.مدلخودروToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carSystemMenuItem,
            this.carColorMenuItem,
            this.carTypeMenuItem,
            this.carLevelMenuItem,
            this.carFuelMenuItem});
			this.مدلخودروToolStripMenuItem.Name = "مدلخودروToolStripMenuItem";
			this.مدلخودروToolStripMenuItem.Size = new System.Drawing.Size(132, 34);
			this.مدلخودروToolStripMenuItem.Text = "خودرو";
			// 
			// carSystemMenuItem
			// 
			this.carSystemMenuItem.Name = "carSystemMenuItem";
			this.carSystemMenuItem.Size = new System.Drawing.Size(141, 34);
			this.carSystemMenuItem.Text = "سیستم";
			// 
			// carColorMenuItem
			// 
			this.carColorMenuItem.Name = "carColorMenuItem";
			this.carColorMenuItem.Size = new System.Drawing.Size(141, 34);
			this.carColorMenuItem.Text = "رنگ";
			// 
			// carTypeMenuItem
			// 
			this.carTypeMenuItem.Name = "carTypeMenuItem";
			this.carTypeMenuItem.Size = new System.Drawing.Size(141, 34);
			this.carTypeMenuItem.Text = "نوع";
			// 
			// carLevelMenuItem
			// 
			this.carLevelMenuItem.Name = "carLevelMenuItem";
			this.carLevelMenuItem.Size = new System.Drawing.Size(141, 34);
			this.carLevelMenuItem.Text = "تیپ";
			// 
			// carFuelMenuItem
			// 
			this.carFuelMenuItem.Name = "carFuelMenuItem";
			this.carFuelMenuItem.Size = new System.Drawing.Size(141, 34);
			this.carFuelMenuItem.Text = "سوخت";
			// 
			// رنگخودروToolStripMenuItem
			// 
			this.رنگخودروToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plateCityMenuItem,
            this.plateTypeMenuItem});
			this.رنگخودروToolStripMenuItem.Name = "رنگخودروToolStripMenuItem";
			this.رنگخودروToolStripMenuItem.Size = new System.Drawing.Size(132, 34);
			this.رنگخودروToolStripMenuItem.Text = "پلاک";
			// 
			// plateCityMenuItem
			// 
			this.plateCityMenuItem.Name = "plateCityMenuItem";
			this.plateCityMenuItem.Size = new System.Drawing.Size(117, 34);
			this.plateCityMenuItem.Text = "شهر";
			// 
			// plateTypeMenuItem
			// 
			this.plateTypeMenuItem.Name = "plateTypeMenuItem";
			this.plateTypeMenuItem.Size = new System.Drawing.Size(117, 34);
			this.plateTypeMenuItem.Text = "نوع";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerMenuItem,
            this.customerShowMenuItem,
            this.customerSerachMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(89, 34);
			this.toolStripMenuItem1.Text = "مشتریان";
			// 
			// customerMenuItem
			// 
			this.customerMenuItem.Name = "customerMenuItem";
			this.customerMenuItem.Size = new System.Drawing.Size(274, 34);
			this.customerMenuItem.Text = "ثبت مشتری جدید";
			// 
			// customerShowMenuItem
			// 
			this.customerShowMenuItem.Name = "customerShowMenuItem";
			this.customerShowMenuItem.Size = new System.Drawing.Size(274, 34);
			this.customerShowMenuItem.Text = "مشاهده اطلاعات مشتریان";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportCustomerMenuItem,
            this.reportCarMenuItem,
            this.reportTrafficMenuItem});
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(91, 34);
			this.toolStripMenuItem2.Text = "گزارشات";
			// 
			// reportCustomerMenuItem
			// 
			this.reportCustomerMenuItem.Name = "reportCustomerMenuItem";
			this.reportCustomerMenuItem.Size = new System.Drawing.Size(150, 34);
			this.reportCustomerMenuItem.Text = "مشتریان";
			// 
			// reportCarMenuItem
			// 
			this.reportCarMenuItem.Name = "reportCarMenuItem";
			this.reportCarMenuItem.Size = new System.Drawing.Size(150, 34);
			this.reportCarMenuItem.Text = "خودروها";
			// 
			// reportTrafficMenuItem
			// 
			this.reportTrafficMenuItem.Name = "reportTrafficMenuItem";
			this.reportTrafficMenuItem.Size = new System.Drawing.Size(150, 34);
			this.reportTrafficMenuItem.Text = "تردد ها";
			// 
			// تنظیماتToolStripMenuItem
			// 
			this.تنظیماتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اطلاعاتکاربریToolStripMenuItem,
            this.تنظیماتبرنامهToolStripMenuItem});
			this.تنظیماتToolStripMenuItem.Name = "تنظیماتToolStripMenuItem";
			this.تنظیماتToolStripMenuItem.Size = new System.Drawing.Size(85, 34);
			this.تنظیماتToolStripMenuItem.Text = "تنظیمات";
			// 
			// اطلاعاتکاربریToolStripMenuItem
			// 
			this.اطلاعاتکاربریToolStripMenuItem.Name = "اطلاعاتکاربریToolStripMenuItem";
			this.اطلاعاتکاربریToolStripMenuItem.Size = new System.Drawing.Size(196, 34);
			this.اطلاعاتکاربریToolStripMenuItem.Text = "اطلاعات کاربری";
			// 
			// تنظیماتبرنامهToolStripMenuItem
			// 
			this.تنظیماتبرنامهToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تنظیماتآنتنToolStripMenuItem,
            this.تنظیماتپیامکToolStripMenuItem});
			this.تنظیماتبرنامهToolStripMenuItem.Name = "تنظیماتبرنامهToolStripMenuItem";
			this.تنظیماتبرنامهToolStripMenuItem.Size = new System.Drawing.Size(196, 34);
			this.تنظیماتبرنامهToolStripMenuItem.Text = "تنظیمات برنامه";
			// 
			// تنظیماتآنتنToolStripMenuItem
			// 
			this.تنظیماتآنتنToolStripMenuItem.Name = "تنظیماتآنتنToolStripMenuItem";
			this.تنظیماتآنتنToolStripMenuItem.Size = new System.Drawing.Size(195, 34);
			this.تنظیماتآنتنToolStripMenuItem.Text = "تنظیمات آنتن";
			// 
			// تنظیماتپیامکToolStripMenuItem
			// 
			this.تنظیماتپیامکToolStripMenuItem.Name = "تنظیماتپیامکToolStripMenuItem";
			this.تنظیماتپیامکToolStripMenuItem.Size = new System.Drawing.Size(195, 34);
			this.تنظیماتپیامکToolStripMenuItem.Text = "تنظیمات پیامک";
			// 
			// راهنماToolStripMenuItem
			// 
			this.راهنماToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.راهنماToolStripMenuItem.Name = "راهنماToolStripMenuItem";
			this.راهنماToolStripMenuItem.Size = new System.Drawing.Size(71, 34);
			this.راهنماToolStripMenuItem.Text = "راهنما";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(154, 34);
			this.aboutToolStripMenuItem.Text = "درباره ...";
			// 
			// mainStatusStrip
			// 
			this.mainStatusStrip.Font = new System.Drawing.Font("B Yekan", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.mainStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripStatusLabel,
            this.nameTtoolStripStatusLabel,
            this.dateToolStripStatusLabel});
			this.mainStatusStrip.Location = new System.Drawing.Point(0, 456);
			this.mainStatusStrip.Name = "mainStatusStrip";
			this.mainStatusStrip.Size = new System.Drawing.Size(864, 31);
			this.mainStatusStrip.TabIndex = 1;
			// 
			// versionToolStripStatusLabel
			// 
			this.versionToolStripStatusLabel.Name = "versionToolStripStatusLabel";
			this.versionToolStripStatusLabel.Size = new System.Drawing.Size(187, 26);
			this.versionToolStripStatusLabel.Text = "اطلاعات برنامه(نسخه و . .. )";
			// 
			// nameTtoolStripStatusLabel
			// 
			this.nameTtoolStripStatusLabel.Name = "nameTtoolStripStatusLabel";
			this.nameTtoolStripStatusLabel.Size = new System.Drawing.Size(51, 26);
			this.nameTtoolStripStatusLabel.Text = "امروز:";
			// 
			// dateToolStripStatusLabel
			// 
			this.dateToolStripStatusLabel.Name = "dateToolStripStatusLabel";
			this.dateToolStripStatusLabel.Size = new System.Drawing.Size(82, 26);
			this.dateToolStripStatusLabel.Text = "تاریخ امروز";
			// 
			// customerSerachMenuItem
			// 
			this.customerSerachMenuItem.Name = "customerSerachMenuItem";
			this.customerSerachMenuItem.Size = new System.Drawing.Size(274, 34);
			this.customerSerachMenuItem.Text = "جستجوی مشتریان";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(864, 487);
			this.Controls.Add(this.mainStatusStrip);
			this.Controls.Add(this.mainMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MainMenuStrip = this.mainMenu;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "ورود به سامانه";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.mainMenu.ResumeLayout(false);
			this.mainMenu.PerformLayout();
			this.mainStatusStrip.ResumeLayout(false);
			this.mainStatusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip mainMenu;
		private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logoffMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
		private System.Windows.Forms.ToolStripMenuItem baseInfoMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem customerMenuItem;
		private System.Windows.Forms.ToolStripMenuItem customerShowMenuItem;
		private System.Windows.Forms.ToolStripMenuItem تنظیماتToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem اطلاعاتکاربریToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem تنظیماتبرنامهToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem راهنماToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem reportCustomerMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reportCarMenuItem;
		private System.Windows.Forms.StatusStrip mainStatusStrip;
		private System.Windows.Forms.ToolStripStatusLabel versionToolStripStatusLabel;
		private System.Windows.Forms.ToolStripMenuItem مدلخودروToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem رنگخودروToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem carSystemMenuItem;
		private System.Windows.Forms.ToolStripMenuItem carColorMenuItem;
		private System.Windows.Forms.ToolStripMenuItem carTypeMenuItem;
		private System.Windows.Forms.ToolStripMenuItem carLevelMenuItem;
		private System.Windows.Forms.ToolStripMenuItem carFuelMenuItem;
		private System.Windows.Forms.ToolStripMenuItem plateCityMenuItem;
		private System.Windows.Forms.ToolStripMenuItem plateTypeMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reportTrafficMenuItem;
		private System.Windows.Forms.ToolStripMenuItem تنظیماتآنتنToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem تنظیماتپیامکToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel nameTtoolStripStatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel dateToolStripStatusLabel;
		private System.Windows.Forms.ToolStripMenuItem customerSerachMenuItem;
	}
}