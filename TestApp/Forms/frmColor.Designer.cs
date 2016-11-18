namespace TestApp.Forms
{
    partial class frmColor
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
            this.txtColor = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            this.btnSave = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.elGroupBox2 = new Klik.Windows.Forms.v1.EntryLib.ELGroupBox();
            this.btnDelete = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.btnShow = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elGroupBox2)).BeginInit();
            this.elGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).BeginInit();
            this.SuspendLayout();
            // 
            // txtColor
            // 
            this.txtColor.CaptionStyle.CaptionSize = 90;
            this.txtColor.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txtColor.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.txtColor.CaptionStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicSilver;
            this.txtColor.CaptionStyle.TextStyle.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtColor.CaptionStyle.TextStyle.Text = "نام رنگ";
            this.txtColor.EditBoxStyle.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtColor.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtColor.EditBoxStyle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtColor.Location = new System.Drawing.Point(52, 50);
            this.txtColor.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(315, 42);
            this.txtColor.TabIndex = 2;
            this.txtColor.ValidationStyle.PasswordChar = '\0';
            this.txtColor.Value = "";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageStyle.Alpha = 100;
            this.btnSave.BackgroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btnSave.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btnSave.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Location = new System.Drawing.Point(260, 113);
            this.btnSave.Name = "btnSave";
            this.btnSave.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.btnSave.Size = new System.Drawing.Size(99, 34);
            this.btnSave.TabIndex = 14;
            this.btnSave.TextStyle.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSave.TextStyle.Text = "ذخیره";
            this.btnSave.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // elGroupBox2
            // 
            this.elGroupBox2.BackgroundStyle.GradientAngle = 45F;
            this.elGroupBox2.BackgroundStyle.GradientEndColor = System.Drawing.Color.Teal;
            this.elGroupBox2.BackgroundStyle.GradientStartColor = System.Drawing.Color.Azure;
            this.elGroupBox2.CaptionStyle.BackgroundStyle.GradientEndColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.elGroupBox2.CaptionStyle.BackgroundStyle.SolidColor = System.Drawing.Color.Turquoise;
            this.elGroupBox2.CaptionStyle.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.elGroupBox2.CaptionStyle.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.elGroupBox2.CaptionStyle.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.elGroupBox2.CaptionStyle.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.elGroupBox2.CaptionStyle.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None;
            this.elGroupBox2.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.elGroupBox2.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.elGroupBox2.CaptionStyle.Office2003Scheme = Klik.Windows.Forms.v1.Common.Office2003Schemes.Divider;
            this.elGroupBox2.CaptionStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.elGroupBox2.CaptionStyle.Size = new System.Drawing.Size(150, 30);
            this.elGroupBox2.CaptionStyle.TextStyle.BackColor = System.Drawing.SystemColors.ControlText;
            this.elGroupBox2.CaptionStyle.TextStyle.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.elGroupBox2.CaptionStyle.TextStyle.ForeColor = System.Drawing.Color.Black;
            this.elGroupBox2.CaptionStyle.TextStyle.Text = "ثبت رنگ خودرو";
            this.elGroupBox2.CaptionStyle.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.elGroupBox2.CaptionStyle.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Office2003;
            this.elGroupBox2.Controls.Add(this.btnShow);
            this.elGroupBox2.Controls.Add(this.btnDelete);
            this.elGroupBox2.Controls.Add(this.btnSave);
            this.elGroupBox2.Controls.Add(this.txtColor);
            this.elGroupBox2.Location = new System.Drawing.Point(12, 12);
            this.elGroupBox2.Name = "elGroupBox2";
            this.elGroupBox2.Office2003Scheme = Klik.Windows.Forms.v1.Common.Office2003Schemes.ToolBar;
            this.elGroupBox2.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlack;
            this.elGroupBox2.Padding = new System.Windows.Forms.Padding(4, 33, 4, 3);
            this.elGroupBox2.Size = new System.Drawing.Size(410, 172);
            this.elGroupBox2.TabIndex = 55;
            this.elGroupBox2.TransparentStyle.BackColor = System.Drawing.Color.Transparent;
            this.elGroupBox2.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImageStyle.Alpha = 100;
            this.btnDelete.BackgroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btnDelete.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btnDelete.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Location = new System.Drawing.Point(159, 113);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.btnDelete.Size = new System.Drawing.Size(95, 34);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.TextStyle.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDelete.TextStyle.Text = "حذف";
            this.btnDelete.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShow
            // 
            this.btnShow.BackgroundImageStyle.Alpha = 100;
            this.btnShow.BackgroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnShow.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btnShow.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btnShow.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShow.Location = new System.Drawing.Point(58, 113);
            this.btnShow.Name = "btnShow";
            this.btnShow.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.btnShow.Size = new System.Drawing.Size(95, 34);
            this.btnShow.TabIndex = 16;
            this.btnShow.TextStyle.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnShow.TextStyle.Text = "نمایش";
            this.btnShow.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(429, 196);
            this.Controls.Add(this.elGroupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmColor";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.txtColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elGroupBox2)).EndInit();
            this.elGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Klik.Windows.Forms.v1.EntryLib.ELEntryBox txtColor;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btnSave;
        private Klik.Windows.Forms.v1.EntryLib.ELGroupBox elGroupBox2;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btnShow;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btnDelete;


    }
}