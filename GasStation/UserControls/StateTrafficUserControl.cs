using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GasStation.UserControls
{
	public partial class StateTrafficUserControl : UserControl
	{
		#region Properties

		public DataTable tableResult 
		{
			get;
			set;
		}
		#endregion
		public StateTrafficUserControl (DataTable tbResult)
		{
			InitializeComponent ();
			tableResult = tbResult;

			Init();
		}

		private void Init ()
		{
			prepare();
		}

		private void prepare ()
		{
			showData();
		}

		private void showData ()
		{
			stateTrafficGrid.DataSource = tableResult;
			stateTrafficGrid.loadHeader(this.GetType().Name);
		}
	}
}
