﻿using BaseDAL.Model;
using Common.Helper.Logger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GasStation.Forms.Base
{
	public partial class CarColorEntryForm : General.SuperForm
	{
		#region Variables
		/// <summary>
		/// Model
		/// </summary>
		Common.BLL.Entity.GasStation.Base__CarColor	model;
		#endregion

		#region Properties

		#endregion

		#region Methods
		/// <summary>
		/// Constructor
		/// </summary>
		public CarColorEntryForm (Common.BLL.Entity.GasStation.Base__CarColor model = null)
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
				model	= new Common.BLL.Entity.GasStation.Base__CarColor ();
			else
			{
				// Load model data from db
				Common.BLL.Logic.GasStation.Base__CarColor	lCarColor	= new Common.BLL.Logic.GasStation.Base__CarColor(Common.Enum.EDatabase.GasStation);
				CommandResult	opResult	= lCarColor.read(model);	
				///TODO: CHECK ERRORS
			}

			// Fill Controls
			BaseBLL.General.FormModelHelper<Common.BLL.Entity.GasStation.Base__CarColor>.fillControl (dataGroupBox, model);			
		}

		/// <summary>
		/// Bind Events
		/// </summary>
		private void bindEvents ()
		{
			exitButton.Click	+= exitButton_Click;
			saveButton.Click	+= saveButton_Click;
		}

		/// <summary>
		/// Save Button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void saveButton_Click (object sender, EventArgs e)
		{
			//String s = "";

			CommandResult	opResult	= validate ();

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
			{ 
				// Fill Model
				BaseBLL.General.FormModelHelper<Common.BLL.Entity.GasStation.Base__CarColor>.fillModel (dataGroupBox, model);

				// Save
				saveRecord ();
			}
			else
				MessageBox.Show (this, opResult.message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		/// <summary>
		/// Insert new record
		/// </summary>
		private void saveRecord ()
		{
			CommandResult	opResult	= null;
			Common.BLL.Logic.GasStation.Base__CarColor	lCarColor	= new Common.BLL.Logic.GasStation.Base__CarColor (Common.Enum.EDatabase.GasStation);
			//Common.BLL.Entity.GasStation.Base__CarColor	carColor	= new Common.BLL.Entity.GasStation.Base__CarColor ();

			// Set author data
			if (model.id == 0)
			{
				#region Insert
				model.insertedById = Common.GlobalData.UserManager.currentUser.id;
				model.insertDate = DateTime.Now;

				opResult = lCarColor.create (model); 
				#endregion
			}
			else
			{
				#region Modify
				model.updatedById = Common.GlobalData.UserManager.currentUser.id;
				model.updateDate = DateTime.Now;

				opResult = lCarColor.update (model); 
				#endregion
			}

			// Create/Modify data

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				CloseSuccess ();
			else
			{
				Logger.logger.log (opResult);
 				MessageBox.Show (this, "خطا در ذخیره اطلاعات", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// Validate data
		/// </summary>
		/// <returns></returns>
		private CommandResult validate ()
		{
			CommandResult result	= null;

			string	color	= colorTextBox.Text.Trim ();

			#region Validate
			bool err = color.isNullOrEmptyOrWhiteSpaceOrLen (50);

			if (err)
				result = CommandResult.makeErrorResult ("مقدار وارد شده نامعتبر می باشد");
			else
				result = CommandResult.makeSuccessResult (); 
			#endregion

			return result;
		}

		/// <summary>
		/// Exit Button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void exitButton_Click (object sender, EventArgs e)
		{
			DialogResult	= System.Windows.Forms.DialogResult.Cancel;
			Close ();
		} 

		/// <summary>
		/// Close Success
		/// </summary>
		private void CloseSuccess ()
		{
			DialogResult	= System.Windows.Forms.DialogResult.OK;
			Close ();
		}
		#endregion

		
	}
}
