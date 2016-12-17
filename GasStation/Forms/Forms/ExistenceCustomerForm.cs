using BaseDAL.Model;
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
	public partial class ExistenceCustomerForm : General.SuperForm
	{

		#region Variables
		/// <summary>
		/// Model
		/// </summary>
		Common.BLL.Entity.GasStation.Owner	model;
		#endregion

		#region Properties

		#endregion

		#region Methods
		/// <summary>
		/// Constructor
		/// </summary>
		public ExistenceCustomerForm (Common.BLL.Entity.GasStation.Owner model = null)
		{
			InitializeComponent ();

			// Set data
			this.model	= model;		

			init ();
		}

		/// <summary>
		/// Initilize
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
			if (null == model)
				model	= new Common.BLL.Entity.GasStation.Owner ();
			else
			{
				// Load model data from db
				Common.BLL.Logic.GasStation.Owner	lOwner	= new Common.BLL.Logic.GasStation.Owner(Common.Enum.EDatabase.GasStation);
				CommandResult	opResult	= lOwner.read(model, "nationalCode");					
			}

			// Fill Controls
			BaseBLL.General.FormModelHelper<Common.BLL.Entity.GasStation.Owner>.fillControl (ownerDataGroupBox, model);			
		}

		/// <summary>
		/// Bind Events
		/// </summary>
		private void bindEvents ()
		{
			getButton.Click	+= getButton_Click;
			
		}

		private void getButton_Click (object sender, EventArgs e)
		{
			
		}

		#endregion
	}
}
