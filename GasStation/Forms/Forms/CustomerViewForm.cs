using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GasStation.Forms.Forms
{
	public partial class CustomerViewForm : General.SuperForm
	{
		#region Methods
		/// <summary>
		/// Constructor
		/// </summary>
		public CustomerViewForm ()
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
			loadData ();
		}

		/// <summary>
		/// Double click
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ResultGrid_CellDoubleClick (object sender, DataGridViewCellEventArgs e)
		{
			showDetail ();
		}

		/// <summary>
		/// Show Detail
		/// </summary>
		private void showDetail ()
		{	
		}

		/// <summary>
		/// Bind Events
		/// </summary>
		private void bindEvents ()
		{
			resultGrid.CellDoubleClick  += ResultGrid_CellDoubleClick;
		}

		/// <summary>
		/// Prepare
		/// </summary>
		private void prepare ()
		{
		}

		/// <summary>
		/// Load data
		/// </summary>
		private void loadData ()
		{
			Common.BLL.Logic.GasStation.Owner	lOwner	= new Common.BLL.Logic.GasStation.Owner (Common.Enum.EDatabase.GasStation);

			#region Load owner data
			DataTable	table	= lOwner.allData ("", "", false).model as  DataTable;

			resultGrid.DataSource	= table;
			resultGrid.loadHeader (this.GetType ().Name);
			#endregion
		}
		#endregion
	}
}
