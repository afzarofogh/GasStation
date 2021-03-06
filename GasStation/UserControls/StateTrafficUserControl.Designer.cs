﻿namespace GasStation.UserControls
{
	partial class StateTrafficUserControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.stateTrafficGrid = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.stateTrafficGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// stateTrafficGrid
			// 
			this.stateTrafficGrid.AllowUserToAddRows = false;
			this.stateTrafficGrid.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
			this.stateTrafficGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.stateTrafficGrid.BackgroundColor = System.Drawing.Color.White;
			this.stateTrafficGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.stateTrafficGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.stateTrafficGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.stateTrafficGrid.Location = new System.Drawing.Point(13, 11);
			this.stateTrafficGrid.MultiSelect = false;
			this.stateTrafficGrid.Name = "stateTrafficGrid";
			this.stateTrafficGrid.ReadOnly = true;
			this.stateTrafficGrid.RowTemplate.Height = 24;
			this.stateTrafficGrid.Size = new System.Drawing.Size(848, 295);
			this.stateTrafficGrid.TabIndex = 3;
			// 
			// StateTrafficUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.stateTrafficGrid);
			this.Name = "StateTrafficUserControl";
			this.Size = new System.Drawing.Size(869, 316);
			((System.ComponentModel.ISupportInitialize)(this.stateTrafficGrid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView stateTrafficGrid;

	}
}
