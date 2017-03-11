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
using GasStation.Forms.Base;
using System.Reflection;

namespace GasStation.Forms.Forms
{
	public partial class MainForm : General.SuperForm
	{
		#region Properties
		#endregion

		#region Variable
		//Common.BLL.Logic.GasStation.User	lUser;
		//Common.BLL.Entity.GasStation.User	user;
		Common.BLL.Entity.GasStation.System__Data	model;

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
		
			model = new Common.BLL.Entity.GasStation.System__Data()
			{ 
				name = "DB-Version"
			};
			Common.BLL.Logic.GasStation.System__Data	lSystemData = new Common.BLL.Logic.GasStation.System__Data(Common.Enum.EDatabase.GasStation);
			CommandResult	opResult	= lSystemData.read(model, "name");
			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				versionToolStripStatusLabel.Text = model.value;

			// Get Version
			string version = Assembly.GetExecutingAssembly ().GetName ().Version.ToString ();
			versionToolStripStatusLabel.Text= version;

		}		
		/// <summary>
		/// Bind Events
		/// </summary>
		private void bindEvents ()
		{
			// Menus	
			logoffMenuItem.Click	+= LogoffMenuItem_Click;
			exitMenuItem.Click		+= ExitMenuItem_Click;

			//Customer
			customerMenuItem.Click		+= CustomerMenuItem_Click;
			customerShowMenuItem.Click	+= CustomerShowMenuItem_Click;

			//Car
			carTypeMenuItem.Click	+= CarTypeMenuItem_Click;
			carSystemMenuItem.Click	+= CarSystemMenuItem_Click;
			carFuelMenuItem.Click	+= CarFuelMenuItem_Click;
			carLevelMenuItem.Click	+= CarLevelMenuItem_Click;
			carColorMenuItem.Click	+= CarColorMenuItem_Click;

			//Plate
			plateCityMenuItem.Click	+= PlateCityMenuItem_Click;
			plateTypeMenuItem.Click += PlateTypeMenuItem_Click;	
	
			//Report
			reportCustomerMenuItem.Click	+= ReportCustomerMenuItem_Click;
		}

		/// <summary>
		/// Report Customer Menu Item
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ReportCustomerMenuItem_Click (object sender, EventArgs e)
		{
			List<Owner> lstOwner = new List<Owner> ();
			Owner o = new Common.BLL.Entity.GasStation.Owner ();
			o.name = "علی";
			o.lastname = "علویی";
			o.mobile ="09193862018";
			o.nationalCode ="4324260869";
			o.phone= "02833652700";
			lstOwner.Add(o);
		}

		/// <summary>
		/// Show Customer Menu Item
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CustomerShowMenuItem_Click (object sender, EventArgs e)
		{
			CustomerViewForm	form	= new CustomerViewForm ();
			form.ShowDialog();
		}		
		/// <summary>
		/// Customer
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CustomerMenuItem_Click (object sender, EventArgs e)
		{
			CustomerForm		form	= new CustomerForm();
			form.ShowDialog();
		}
		
		/// <summary>
		/// Car Level Form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CarLevelMenuItem_Click (object sender, EventArgs e)
		{
			CarLevelForm	form		= new CarLevelForm();
			form.ShowDialog();
		}

		/// <summary>
		/// Car Fuel Form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CarFuelMenuItem_Click (object sender, EventArgs e)
		{
			CarFuelForm		form		= new CarFuelForm();
			form.ShowDialog();
		}

		/// <summary>
		/// Car System Form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>

		private void CarSystemMenuItem_Click (object sender, EventArgs e)
		{
			CarSystemForm	form		= new CarSystemForm();
			form.ShowDialog();
		}

		/// <summary>
		/// Car Type Form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CarTypeMenuItem_Click (object sender, EventArgs e)
		{
			CarTypeForm		form		= new CarTypeForm();
			form.ShowDialog();
		}

		/// <summary>
		/// Car Color Form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CarColorMenuItem_Click (object sender, EventArgs e)
		{
			CarColorForm	form		= new CarColorForm();
			form.ShowDialog();
		}

		/// <summary>
		/// Plate City
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PlateCityMenuItem_Click (object sender, EventArgs e)
		{
			PlateCityForm	 form		= new PlateCityForm ();
			form.ShowDialog();
		}

		/// <summary>
		/// Plate Type Form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PlateTypeMenuItem_Click (object sender, EventArgs e)
		{
			PlateTypeForm	form = new PlateTypeForm();
			form.ShowDialog();
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
