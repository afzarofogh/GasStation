namespace GasStation.Forms.Forms
{
	partial class CustomerViewForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.mainMenu = new System.Windows.Forms.MenuStrip();
			this.اطلاعاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reloadMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.insertMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.modifyMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.mainTabControl = new System.Windows.Forms.TabControl();
			this.customerTabPage = new System.Windows.Forms.TabPage();
			this.resultGrid = new System.Windows.Forms.DataGridView();
			this.mainMenu.SuspendLayout();
			this.mainTabControl.SuspendLayout();
			this.customerTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.resultGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// mainMenu
			// 
			this.mainMenu.Font = new System.Drawing.Font("Tahoma", 9F);
			this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اطلاعاتToolStripMenuItem});
			this.mainMenu.Location = new System.Drawing.Point(0, 0);
			this.mainMenu.Name = "mainMenu";
			this.mainMenu.Size = new System.Drawing.Size(782, 26);
			this.mainMenu.TabIndex = 2;
			// 
			// اطلاعاتToolStripMenuItem
			// 
			this.اطلاعاتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadMenu,
            this.toolStripSeparator1,
            this.insertMenu,
            this.modifyMenu,
            this.deleteMenu,
            this.toolStripMenuItem1,
            this.exitMenu});
			this.اطلاعاتToolStripMenuItem.Name = "اطلاعاتToolStripMenuItem";
			this.اطلاعاتToolStripMenuItem.Size = new System.Drawing.Size(70, 22);
			this.اطلاعاتToolStripMenuItem.Text = "اطلاعات";
			// 
			// reloadMenu
			// 
			this.reloadMenu.Name = "reloadMenu";
			this.reloadMenu.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.reloadMenu.Size = new System.Drawing.Size(208, 22);
			this.reloadMenu.Text = "بازخوانی اطلاعات";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(205, 6);
			// 
			// insertMenu
			// 
			this.insertMenu.Name = "insertMenu";
			this.insertMenu.ShortcutKeys = System.Windows.Forms.Keys.F2;
			this.insertMenu.Size = new System.Drawing.Size(208, 22);
			this.insertMenu.Text = "ثبت رکورد جدید";
			// 
			// modifyMenu
			// 
			this.modifyMenu.Name = "modifyMenu";
			this.modifyMenu.ShortcutKeys = System.Windows.Forms.Keys.F3;
			this.modifyMenu.Size = new System.Drawing.Size(208, 22);
			this.modifyMenu.Text = "ویرایش رکورد ";
			// 
			// deleteMenu
			// 
			this.deleteMenu.Name = "deleteMenu";
			this.deleteMenu.ShortcutKeys = System.Windows.Forms.Keys.F9;
			this.deleteMenu.Size = new System.Drawing.Size(208, 22);
			this.deleteMenu.Text = "حذف رکورد";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(205, 6);
			// 
			// exitMenu
			// 
			this.exitMenu.Name = "exitMenu";
			this.exitMenu.ShortcutKeys = System.Windows.Forms.Keys.F12;
			this.exitMenu.Size = new System.Drawing.Size(208, 22);
			this.exitMenu.Text = "خروج";
			// 
			// mainTabControl
			// 
			this.mainTabControl.Controls.Add(this.customerTabPage);
			this.mainTabControl.Location = new System.Drawing.Point(12, 31);
			this.mainTabControl.Name = "mainTabControl";
			this.mainTabControl.RightToLeftLayout = true;
			this.mainTabControl.SelectedIndex = 0;
			this.mainTabControl.Size = new System.Drawing.Size(758, 492);
			this.mainTabControl.TabIndex = 4;
			// 
			// customerTabPage
			// 
			this.customerTabPage.Controls.Add(this.resultGrid);
			this.customerTabPage.Location = new System.Drawing.Point(4, 27);
			this.customerTabPage.Name = "customerTabPage";
			this.customerTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.customerTabPage.Size = new System.Drawing.Size(750, 461);
			this.customerTabPage.TabIndex = 0;
			this.customerTabPage.Text = "مشتریان ثبت شده";
			this.customerTabPage.UseVisualStyleBackColor = true;
			// 
			// resultGrid
			// 
			this.resultGrid.AllowUserToAddRows = false;
			this.resultGrid.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
			this.resultGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.resultGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.resultGrid.BackgroundColor = System.Drawing.Color.White;
			this.resultGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.resultGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.resultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.resultGrid.Location = new System.Drawing.Point(15, 12);
			this.resultGrid.MultiSelect = false;
			this.resultGrid.Name = "resultGrid";
			this.resultGrid.ReadOnly = true;
			this.resultGrid.RowTemplate.Height = 24;
			this.resultGrid.Size = new System.Drawing.Size(721, 436);
			this.resultGrid.TabIndex = 5;
			// 
			// CustomerViewForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(782, 535);
			this.Controls.Add(this.mainTabControl);
			this.Controls.Add(this.mainMenu);
			this.Name = "CustomerViewForm";
			this.Text = "مشاهده اطلاعات مشتریان";
			this.mainMenu.ResumeLayout(false);
			this.mainMenu.PerformLayout();
			this.mainTabControl.ResumeLayout(false);
			this.customerTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.resultGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip mainMenu;
		private System.Windows.Forms.ToolStripMenuItem اطلاعاتToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reloadMenu;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem insertMenu;
		private System.Windows.Forms.ToolStripMenuItem modifyMenu;
		private System.Windows.Forms.ToolStripMenuItem deleteMenu;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem exitMenu;
		private System.Windows.Forms.TabControl mainTabControl;
		private System.Windows.Forms.TabPage customerTabPage;
		private System.Windows.Forms.DataGridView resultGrid;

	}
}