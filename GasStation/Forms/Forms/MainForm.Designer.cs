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
			this.reportAntennaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.تنظیماتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.اطلاعاتکاربریToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.تنظیماتبرنامهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.راهنماToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.دربارهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
			this.versionToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.تنظیماتآنتنToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.تنظیماتپیامکToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
			this.fileMenuItem.Size = new System.Drawing.Size(45, 22);
			this.fileMenuItem.Text = "فایل";
			// 
			// logoffMenuItem
			// 
			this.logoffMenuItem.Name = "logoffMenuItem";
			this.logoffMenuItem.Size = new System.Drawing.Size(175, 22);
			this.logoffMenuItem.Text = "تغییر کاربر";
			// 
			// exitMenuItem
			// 
			this.exitMenuItem.Name = "exitMenuItem";
			this.exitMenuItem.Size = new System.Drawing.Size(175, 22);
			this.exitMenuItem.Text = "خروج";
			// 
			// baseInfoMenuItem
			// 
			this.baseInfoMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مدلخودروToolStripMenuItem,
            this.رنگخودروToolStripMenuItem});
			this.baseInfoMenuItem.Name = "baseInfoMenuItem";
			this.baseInfoMenuItem.Size = new System.Drawing.Size(96, 22);
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
			this.مدلخودروToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
			this.مدلخودروToolStripMenuItem.Text = "خودرو";
			// 
			// carSystemMenuItem
			// 
			this.carSystemMenuItem.Name = "carSystemMenuItem";
			this.carSystemMenuItem.Size = new System.Drawing.Size(127, 22);
			this.carSystemMenuItem.Text = "سیستم";
			// 
			// carColorMenuItem
			// 
			this.carColorMenuItem.Name = "carColorMenuItem";
			this.carColorMenuItem.Size = new System.Drawing.Size(127, 22);
			this.carColorMenuItem.Text = "رنگ";
			// 
			// carTypeMenuItem
			// 
			this.carTypeMenuItem.Name = "carTypeMenuItem";
			this.carTypeMenuItem.Size = new System.Drawing.Size(127, 22);
			this.carTypeMenuItem.Text = "نوع";
			// 
			// carLevelMenuItem
			// 
			this.carLevelMenuItem.Name = "carLevelMenuItem";
			this.carLevelMenuItem.Size = new System.Drawing.Size(127, 22);
			this.carLevelMenuItem.Text = "تیپ";
			// 
			// carFuelMenuItem
			// 
			this.carFuelMenuItem.Name = "carFuelMenuItem";
			this.carFuelMenuItem.Size = new System.Drawing.Size(127, 22);
			this.carFuelMenuItem.Text = "سوخت";
			// 
			// رنگخودروToolStripMenuItem
			// 
			this.رنگخودروToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plateCityMenuItem,
            this.plateTypeMenuItem});
			this.رنگخودروToolStripMenuItem.Name = "رنگخودروToolStripMenuItem";
			this.رنگخودروToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
			this.رنگخودروToolStripMenuItem.Text = "پلاک";
			// 
			// plateCityMenuItem
			// 
			this.plateCityMenuItem.Name = "plateCityMenuItem";
			this.plateCityMenuItem.Size = new System.Drawing.Size(105, 22);
			this.plateCityMenuItem.Text = "شهر";
			// 
			// plateTypeMenuItem
			// 
			this.plateTypeMenuItem.Name = "plateTypeMenuItem";
			this.plateTypeMenuItem.Size = new System.Drawing.Size(105, 22);
			this.plateTypeMenuItem.Text = "نوع";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerMenuItem,
            this.customerShowMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(73, 22);
			this.toolStripMenuItem1.Text = "مشتریان";
			// 
			// customerMenuItem
			// 
			this.customerMenuItem.Name = "customerMenuItem";
			this.customerMenuItem.Size = new System.Drawing.Size(242, 22);
			this.customerMenuItem.Text = "ثبت مشتری جدید";
			// 
			// customerShowMenuItem
			// 
			this.customerShowMenuItem.Name = "customerShowMenuItem";
			this.customerShowMenuItem.Size = new System.Drawing.Size(242, 22);
			this.customerShowMenuItem.Text = "مشاهده اطلاعات مشتریان";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportCustomerMenuItem,
            this.reportCarMenuItem,
            this.reportTrafficMenuItem,
            this.reportAntennaMenuItem});
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(73, 22);
			this.toolStripMenuItem2.Text = "گزارشات";
			// 
			// reportCustomerMenuItem
			// 
			this.reportCustomerMenuItem.Name = "reportCustomerMenuItem";
			this.reportCustomerMenuItem.Size = new System.Drawing.Size(175, 22);
			this.reportCustomerMenuItem.Text = "مشتریان";
			// 
			// reportCarMenuItem
			// 
			this.reportCarMenuItem.Name = "reportCarMenuItem";
			this.reportCarMenuItem.Size = new System.Drawing.Size(175, 22);
			this.reportCarMenuItem.Text = "خودروها";
			// 
			// reportTrafficMenuItem
			// 
			this.reportTrafficMenuItem.Name = "reportTrafficMenuItem";
			this.reportTrafficMenuItem.Size = new System.Drawing.Size(175, 22);
			this.reportTrafficMenuItem.Text = "تردد ها";
			// 
			// reportAntennaMenuItem
			// 
			this.reportAntennaMenuItem.Name = "reportAntennaMenuItem";
			this.reportAntennaMenuItem.Size = new System.Drawing.Size(175, 22);
			this.reportAntennaMenuItem.Text = "آنتن";
			// 
			// تنظیماتToolStripMenuItem
			// 
			this.تنظیماتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اطلاعاتکاربریToolStripMenuItem,
            this.تنظیماتبرنامهToolStripMenuItem});
			this.تنظیماتToolStripMenuItem.Name = "تنظیماتToolStripMenuItem";
			this.تنظیماتToolStripMenuItem.Size = new System.Drawing.Size(70, 22);
			this.تنظیماتToolStripMenuItem.Text = "تنظیمات";
			// 
			// اطلاعاتکاربریToolStripMenuItem
			// 
			this.اطلاعاتکاربریToolStripMenuItem.Name = "اطلاعاتکاربریToolStripMenuItem";
			this.اطلاعاتکاربریToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
			this.اطلاعاتکاربریToolStripMenuItem.Text = "اطلاعات کاربری";
			// 
			// تنظیماتبرنامهToolStripMenuItem
			// 
			this.تنظیماتبرنامهToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تنظیماتآنتنToolStripMenuItem,
            this.تنظیماتپیامکToolStripMenuItem});
			this.تنظیماتبرنامهToolStripMenuItem.Name = "تنظیماتبرنامهToolStripMenuItem";
			this.تنظیماتبرنامهToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
			this.تنظیماتبرنامهToolStripMenuItem.Text = "تنظیمات برنامه";
			// 
			// راهنماToolStripMenuItem
			// 
			this.راهنماToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.دربارهToolStripMenuItem});
			this.راهنماToolStripMenuItem.Name = "راهنماToolStripMenuItem";
			this.راهنماToolStripMenuItem.Size = new System.Drawing.Size(57, 22);
			this.راهنماToolStripMenuItem.Text = "راهنما";
			// 
			// دربارهToolStripMenuItem
			// 
			this.دربارهToolStripMenuItem.Name = "دربارهToolStripMenuItem";
			this.دربارهToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.دربارهToolStripMenuItem.Text = "درباره ...";
			// 
			// mainStatusStrip
			// 
			this.mainStatusStrip.Font = new System.Drawing.Font("B Yekan", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.mainStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripStatusLabel});
			this.mainStatusStrip.Location = new System.Drawing.Point(0, 456);
			this.mainStatusStrip.Name = "mainStatusStrip";
			this.mainStatusStrip.Size = new System.Drawing.Size(864, 31);
			this.mainStatusStrip.TabIndex = 1;
			// 
			// versionToolStripStatusLabel
			// 
			this.versionToolStripStatusLabel.Name = "versionToolStripStatusLabel";
			this.versionToolStripStatusLabel.Size = new System.Drawing.Size(180, 20);
			this.versionToolStripStatusLabel.Text = "اطلاعات برنامه(نسخه و . .. )";
			// 
			// تنظیماتآنتنToolStripMenuItem
			// 
			this.تنظیماتآنتنToolStripMenuItem.Name = "تنظیماتآنتنToolStripMenuItem";
			this.تنظیماتآنتنToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
			this.تنظیماتآنتنToolStripMenuItem.Text = "تنظیمات آنتن";
			// 
			// تنظیماتپیامکToolStripMenuItem
			// 
			this.تنظیماتپیامکToolStripMenuItem.Name = "تنظیماتپیامکToolStripMenuItem";
			this.تنظیماتپیامکToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
			this.تنظیماتپیامکToolStripMenuItem.Text = "تنظیمات پیامک";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
		private System.Windows.Forms.ToolStripMenuItem دربارهToolStripMenuItem;
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
		private System.Windows.Forms.ToolStripMenuItem reportAntennaMenuItem;
		private System.Windows.Forms.ToolStripMenuItem تنظیماتآنتنToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem تنظیماتپیامکToolStripMenuItem;
	}
}