using BaseDAL.Model;
using GasStation.Forms.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common.BLL.Entity.GasStation;

namespace GasStation.Forms.Forms
{
	public partial class MainForm : SuperForm
	{
		#region Properties
		#endregion

		#region Variable
		Common.BLL.Logic.GasStation.User	lUser;
		Common.BLL.Entity.GasStation.User	user;
		#endregion

		#region Methods
		/// <summary>
		/// Constructor
		/// </summary>
		public MainForm ()
		{
			InitializeComponent ();

			init ();
		}


		/// <summary>
		/// Init
		/// </summary>
		private void init ()
		{
			bindEvents ();
			prepare ();
		}

		/// <summary>
		/// Prepare
		/// </summary>
		private void prepare ()
		{
			__Program.hasLogin	= 0;		// Default exit menu (Logoff)
		}

		/// <summary>
		/// Bind Events
		/// </summary>
		private void bindEvents ()
		{
			// Menus	
			logoffMenuItem.Click	+= LogoffMenuItem_Click;
			exitMenuItem.Click		+= ExitMenuItem_Click;
		}

		/// <summary>
		/// Exit
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ExitMenuItem_Click (object sender, EventArgs e)
		{
			__Program.hasLogin	= 2;
			Close ();
		}

		/// <summary>
		/// Logoff Menu
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LogoffMenuItem_Click (object sender, EventArgs e)
		{
			__Program.hasLogin	= 0;
			Close ();
		}

		/// <summary>
		/// OnClose
		/// </summary>
		/// <param name="e"></param>
		protected override void OnClosed (EventArgs e)
		{
			base.OnClosed (e);
		}
		#endregion
	}
}
