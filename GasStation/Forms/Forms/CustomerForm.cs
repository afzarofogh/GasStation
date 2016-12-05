﻿using BaseDAL.Model;
using Common.Helper.Logger;
using Common.Network.Core;
using GasStation.Enum;
using GasStation.Forms.Base;
using GasStation.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GasStation.Forms.Forms
{
	public partial class CustomerForm : General.SuperForm
	{

		#region Properties
		#endregion

		#region Variable
		
		Common.BLL.Entity.GasStation.Owner 			ownerModel;	
		Common.BLL.Entity.GasStation.Car			carModel;		
		Common.BLL.Entity.GasStation.CarOwner		carOwnerModel;
		Common.BLL.Entity.GasStation.Plate			plateModel;		
		Common.BLL.Entity.GasStation.LegalOwner		legalOwnerModel;
		Common.BLL.Entity.GasStation.Tag			tagModel;
		Common.BLL.Entity.GasStation.CarTag			carTagModel;
		

		private const int		C_BufferSize	= 1024;
		AntennaClient anntenaClient ;
		

		#endregion

		#region Methods		
		
		
		public CustomerForm ()
		{
			InitializeComponent ();

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

			if (null == ownerModel)
				ownerModel		= new  Common.BLL.Entity.GasStation.Owner();
			if (null == carModel)
				carModel		= new Common.BLL.Entity.GasStation.Car ();
			if (null == carOwnerModel)
				carOwnerModel	= new Common.BLL.Entity.GasStation.CarOwner();
			if (null == legalOwnerModel)
				legalOwnerModel	= new Common.BLL.Entity.GasStation.LegalOwner();
			if (null == plateModel)
				plateModel		= new Common.BLL.Entity.GasStation.Plate();
			if (null == tagModel)
				tagModel		= new Common.BLL.Entity.GasStation.Tag();
			if (null == carTagModel)
				carTagModel		= new Common.BLL.Entity.GasStation.CarTag();


			// Update ui
			updateUi ();

			enableTab(carTabPage, false);
			enableTab(plateTabPage, false);
			enableTab(ownerTypeTabPage, false);
			enableTab(showInfoTabPage, false);
			enableTab(tagTabPage, false);	
			
			reloadCombo();
			
		}


		/// <summary>
		/// Enable Tab
		/// </summary>
		/// <param name="page"></param>
		/// <param name="enable"></param>
		public static void enableTab(TabPage page, bool enable)
		{
			enableControls(page.Controls, enable);
		}
		/// <summary>
		/// Enable Controls
		/// </summary>
		/// <param name="ctls"></param>
		/// <param name="enable"></param>
		private static void enableControls(Control.ControlCollection ctls, bool enable)
		{
			foreach (Control ctl in ctls)
			{
				ctl.Enabled = enable;
				enableControls(ctl.Controls, enable);
			}
		}		

		/// <summary>
		/// Reload ComboBox
		/// </summary>
		private void reloadCombo ()
		{
			// Car Color
			Common.BLL.Logic.GasStation.HC__Sexuality	lSex	= new Common.BLL.Logic.GasStation.HC__Sexuality (Common.Enum.EDatabase.GasStation);
			DataTable resultSex	= lSex.allData ("", "", false).model as DataTable;
			genComboBox.fillByTable (resultSex, "id", "gen");			

			//genComboBox.DataSource = System.Enum.GetValues(typeof(enumGenType));

			// Car Color
			Common.BLL.Logic.GasStation.Base__CarColor	lCarColor	= new Common.BLL.Logic.GasStation.Base__CarColor (Common.Enum.EDatabase.GasStation);
			DataTable resultColor	= lCarColor.allData ("", "", false).model as DataTable;
			carColorComboBox.fillByTable (resultColor, "id", "color");			
			
			//Car Type
			Common.BLL.Logic.GasStation.Base__CarType	lCarType	= new Common.BLL.Logic.GasStation.Base__CarType (Common.Enum.EDatabase.GasStation);
			DataTable 	resultType			= lCarType.allData("", "", false).model as DataTable;		
			carTypeComboBox.fillByTable (resultType, "id", "type");

			//Car Fuel
			Common.BLL.Logic.GasStation.Base__CarFuel	lCarFuel	= new Common.BLL.Logic.GasStation.Base__CarFuel (Common.Enum.EDatabase.GasStation);
			DataTable resultFuel			= lCarFuel.allData ("", "", false).model as DataTable;
			carFuelComboBox.fillByTable (resultFuel, "id", "fuel");			

			//Car Level
			Common.BLL.Logic.GasStation.Base__CarLevel	lCarLevel	= new Common.BLL.Logic.GasStation.Base__CarLevel (Common.Enum.EDatabase.GasStation);
			DataTable 	resultLevel			= lCarLevel.allData ("", "", false).model as DataTable;		
			carLevelComboBox.fillByTable (resultLevel, "id", "levelcar");

			//Car System
			Common.BLL.Logic.GasStation.Base__CarSystem		lCarSystem	= new Common.BLL.Logic.GasStation.Base__CarSystem (Common.Enum.EDatabase.GasStation);
			DataTable	resultSystem		= lCarSystem.allData ("", "", false).model as DataTable;			
			carSystemComboBox.fillByTable (resultSystem, "id", "system");

			//Plate type 
			Common.BLL.Logic.GasStation.Base__PlateType		lPlateType		= new Common.BLL.Logic.GasStation.Base__PlateType (Common.Enum.EDatabase.GasStation);
			DataTable	resultPlateType		= lPlateType.allData("", "", false).model as DataTable;				
			plateTypeComboBox.fillByTable (resultPlateType, "id", "type");		
			
		}

		/// <summary>
		/// Bind Events
		/// </summary>
		private void bindEvents ()
		{
			
			mainTabControl.SelectedIndexChanged		+= MainTabControl_SelectedIndexChanged;
			plateTypeComboBox.SelectedIndexChanged	+= PlateTypeComboBox_SelectedIndexChanged;
			legalRadioButton.CheckedChanged			+= LegalRadioButton_CheckedChanged;
			code1Numeric.SelectedItemChanged		+= Code1Numeric_SelectedItemChanged;
			code2Numeric.SelectedItemChanged		+= Code2Numeric_SelectedItemChanged;

			nameTextBox.KeyPress					+= NameTextBox_KeyPress;
			lastNameTextBox.KeyPress				+= LastNameTextBox_KeyPress;			
			phoneTextBox.KeyPress					+= PhoneTextBox_KeyPress;
			mobileTextBox.KeyPress					+= MobileTextBox_KeyPress;

			nextButton.Click						+= NextButton_Click;
			previousButton.Click					+= PreviousButton_Click;
			exitMenu.Click							+= ExitMenu_Click;
			insertMenu.Click						+= InsertMenu_Click;
			carTypeButton.Click						+= CarTypeButton_Click;
			carSystemButton.Click					+= CarSystemButton_Click;
			carColorButton.Click					+= CarColorButton_Click;
			carFuelButton.Click						+= CarFuelButton_Click;
			carLevelButton.Click					+= CarLevelButton_Click;
			plateTypeButton.Click					+= PlateTypeButton_Click;

			getTagButton.Click						+= GetTagButton_Click;
			registerButton.Click					+= RegisterButton_Click;
			finalSaveButton.Click					+= FinalSaveButton_Click;			
		}

		/// <summary>
		/// Insert Menu
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void InsertMenu_Click (object sender, EventArgs e)
		{
			reload();
		}

		private void reload ()
		{
			
		}
		/// <summary>
		/// Exit Menu
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ExitMenu_Click (object sender, EventArgs e)
		{
			Close();
		}	
		
		/// <summary>
		/// Show Data in List View
		/// </summary>
		private void listviewDetails ()
		{
			ListViewGroup owner_group = new ListViewGroup("راننده");
            ListViewGroup car_group = new ListViewGroup("خودرو");
			ListViewGroup plate_group = new ListViewGroup("پلاک");
			ListViewGroup ownerType_group = new ListViewGroup("مالک");

			InfoListView.Groups.Add(owner_group);
			InfoListView.Groups.Add(car_group);
            InfoListView.Groups.Add(plate_group);
			InfoListView.Groups.Add(ownerType_group);

			InfoListView.Items.Add(new ListViewItem(new string[]{   "نام",				ownerModel.name},					owner_group));
			InfoListView.Items.Add(new ListViewItem(new string[]{   "نام خانوادگی",	ownerModel.lastname},				owner_group));
			InfoListView.Items.Add(new ListViewItem(new string[]{   "کد ملی",			ownerModel.nationalCode},			owner_group));
			InfoListView.Items.Add(new ListViewItem(new string[]{   "جنسیت",			genComboBox.Text},					owner_group));
			InfoListView.Items.Add(new ListViewItem(new string[]{   "تاریخ تولد",		ownerModel.birthdate.ToString()},	owner_group));
			InfoListView.Items.Add(new ListViewItem(new string[]{   "محل تولد",			ownerModel.birthdatelocal},			owner_group));
			InfoListView.Items.Add(new ListViewItem(new string[]{   "تلفن ثابت",		ownerModel.phone},					owner_group));
			InfoListView.Items.Add(new ListViewItem(new string[]{   "تلفن همراه",		ownerModel.mobile},					owner_group));
			InfoListView.Items.Add(new ListViewItem(new string[]{   "آدرس",				ownerModel.address},				owner_group));


			InfoListView.Items.Add(new ListViewItem(new string[]{   "نوع",			carTypeComboBox.Text},			car_group));
			InfoListView.Items.Add(new ListViewItem(new string[]{   "سیستم",		carSystemComboBox.Text},		car_group));
			InfoListView.Items.Add(new ListViewItem(new string[]{   "تیپ",			carLevelComboBox.Text},			car_group));
			InfoListView.Items.Add(new ListViewItem(new string[]{   "رنگ",			carColorComboBox.Text},			car_group));
			InfoListView.Items.Add(new ListViewItem(new string[]{   "نوع سوخت",		carFuelComboBox.Text},			car_group));
			InfoListView.Items.Add(new ListViewItem(new string[]{   "مدل",			carModel.model},				car_group));
			InfoListView.Items.Add(new ListViewItem(new string[]{   "ظرفیت",		carModel.capacity.ToString()},	car_group));
			InfoListView.Items.Add(new ListViewItem(new string[]{   "شماره موتور", carModel.engineCode},			car_group));
			InfoListView.Items.Add(new ListViewItem(new string[]{   "شماره شاسی",	carModel.chasisCode},			car_group));

			InfoListView.Items.Add(new ListViewItem(new string[]{   "نوع پلاک",		plateTypeComboBox.Text},	plate_group));
			InfoListView.Items.Add(new ListViewItem(new string[]{   "شماره پلاک",	plateModel.plate},			plate_group));

			if (!carOwnerModel.type)
				InfoListView.Items.Add(new ListViewItem(new string[]{   "نوع مالک", 	"حقیقی"},		ownerType_group));
			else
			{ 
				InfoListView.Items.Add(new ListViewItem(new string[]{   "نوع مالک", 	"حقوقی"},											ownerType_group));
				InfoListView.Items.Add(new ListViewItem(new string[]{   "کد شناسایی سازمان", 		legalOwnerModel.OrganizationCode},		ownerType_group));
				InfoListView.Items.Add(new ListViewItem(new string[]{   "نام سازمان", 				legalOwnerModel.name},					ownerType_group));
			}
		}

		/// <summary>
		/// Save final data
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FinalSaveButton_Click (object sender, EventArgs e)
		{
			if (!registerData())
				MessageBox.Show("خطا در ذخیره اطلاعات","خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else
			{
				MessageBox.Show (this, "اطلاعات با موفقیت ذخیره شد", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
				init ();
			}
		}

		/// <summary>
		/// Lastname TextBox Key Press
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LastNameTextBox_KeyPress (object sender, KeyPressEventArgs e)
		{
			 e.Handled = !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
		}

		/// <summary>
		/// Name TextBox Key Press
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void NameTextBox_KeyPress (object sender, KeyPressEventArgs e)
		{
			 e.Handled = !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
		}

		/// <summary>
		/// Mobile TextBox Key Press
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MobileTextBox_KeyPress (object sender, KeyPressEventArgs e)
		{
			e.Handled = (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar));			
		}

		/// <summary>
		/// Phone TextBox KeyPress
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PhoneTextBox_KeyPress (object sender, KeyPressEventArgs e)
		{
			e.Handled = (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar));	
		}		

		/// <summary>
		/// Code 1 Numbric SelectedItemChanged
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Code1Numeric_SelectedItemChanged (object sender, EventArgs e)
		{
			if (code1Numeric.Text.Length == 2)
			{
				cityLabel.Visible = true;
				cityLabel.Text = (null != getNameCity(code1Numeric.Text.Trim())) ? getNameCity(code1Numeric.Text.Trim()) :"کد وارد شده نامعتبر است";	
			}
			else
			{
				cityLabel.Text = "";
				cityLabel.Visible = false;
			}
				
		}
		/// <summary>
		/// Code 2 Numberic SelectedItemChanged
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Code2Numeric_SelectedItemChanged (object sender, EventArgs e)
		{
			if (code2Numeric.Text.Length == 2)
			{
				cityLabel.Visible = true;
				cityLabel.Text = (null != getNameCity(code2Numeric.Text.Trim())) ? getNameCity(code2Numeric.Text.Trim()) :"کد وارد شده نامعتبر است";	
			}
			else
			{
				cityLabel.Text = "";
				cityLabel.Visible = false;
			}
		}

		/// <summary>
		/// Register Button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RegisterButton_Click (object sender, EventArgs e)
		{
			int				step		= 0;		
			// Get step
			step	= mainTabControl.SelectedIndex;
			enableTab(tagTabPage, true);
			nextStep(step);
			
		}
		/// <summary>
		/// Register Data
		/// </summary>
		private bool registerData ()
		{			 
			//save_Owner_Car_Plate(ownerModel, carModel, plateModel, legalOwnerModel);
			bool result = false;
			if (savePlate())			
				if (saveOwner())
					if (saveCar ())
						if (saveCarOwner())
							if ( null == legalOwnerModel)
							{ 
								if (saveTag())
								{
									if (saveCarTag())
									{										
										//CloseSuccess();
										result = true;
									}	
									else 
										result = false;
								}
								else 
									result = false;
								
							}
							else if (null != legalOwnerModel && saveLegalOwner())
							{
								if (saveTag())
								{
									if (saveCarTag())
									{										
										//CloseSuccess();
										result = true;
									}	
									else 
										result = false ;
								}	
								else 
									result = false;
							}
			return result;
					
		}		
	
		/// <summary>
		/// Insert new Owner
		/// </summary>
		private bool saveOwner ()
		{
			//TODO: if Owner exis
		    bool result = false;
			CommandResult opResult = null;
			//Common.BLL.Entity.GasStation.Owner model = new Common.BLL.Entity.GasStation.Owner()
			//{
			//	nationalCode = ownerModel.nationalCode
			//};
			
			Common.BLL.Logic.GasStation.Owner  lOwner = new Common.BLL.Logic.GasStation.Owner (Common.Enum.EDatabase.GasStation);
			//opResult = lOwner.read(model);
			
			//if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
			//{
			//	ownerModel.id = model.id;
			//	result = true ;
			//}
			//else
			//{
				// Set author data
				if (ownerModel.id == 0)
				{
					#region Insert
					ownerModel.insertedById = Common.GlobalData.UserManager.currentUser.id;
					ownerModel.insertDate = DateTime.Now;

					opResult = lOwner.create (ownerModel);
					#endregion
				}
				if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)			
					result = true;
				else
				{
					result = false ;
					Logger.logger.log (opResult);
					MessageBox.Show (this, "خطا در ذخیره اطلاعات راننده وجود دارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			//}
			

			return result;
		}
			/// <summary>
		/// Insert new Plate
		/// </summary>
		private bool savePlate ()
		{
			bool result =   false;
			CommandResult opResult = null;
			Common.BLL.Logic.GasStation.Plate  lPlate = new Common.BLL.Logic.GasStation.Plate (Common.Enum.EDatabase.GasStation);			

			// Set author data
			if (plateModel.id == 0)
			{
				#region Insert				
				plateModel.insertedById = Common.GlobalData.UserManager.currentUser.id;
				plateModel.insertDate = DateTime.Now;

				opResult = lPlate.create (plateModel);
				#endregion
			}
					

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)			
				result = true ;			
			else
			{
				result = false;
				Logger.logger.log (opResult);
				MessageBox.Show (this, "خطا در ذخیره اطلاعات پلاک وجود دارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return result;
		}
		/// <summary>
		/// Insert new Car 
		/// </summary>
		private bool saveCar ()
		{
			bool result = false;
			CommandResult opResult = null;
			Common.BLL.Logic.GasStation.Car  lCar = new Common.BLL.Logic.GasStation.Car (Common.Enum.EDatabase.GasStation);			

			// Set author data
			if (carModel.id == 0)
			{
				#region Insert
				carModel.plateId	= plateModel.id;
				carModel.insertedById = Common.GlobalData.UserManager.currentUser.id;
				carModel.insertDate = DateTime.Now;

				opResult = lCar.create (carModel);
				#endregion
			}
			
			// Create/Modify data

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)			
				result = true;			
			else
			{
				result= false;
				Logger.logger.log (opResult);
				MessageBox.Show (this, "خطا در ذخیره اطلاعات", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return result;
		}
				
		/// <summary>
		/// Insert new Car Owner
		/// </summary>
		private bool saveCarOwner ()
		{	
			bool result = false;
			CommandResult opResult = null;
			Common.BLL.Logic.GasStation.CarOwner lCarOwner = new Common.BLL.Logic.GasStation.CarOwner(Common.Enum.EDatabase.GasStation);

			if(carOwnerModel.id == 0)
			{
				#region Insert
				carOwnerModel.ownerId = ownerModel.id;
				carOwnerModel.carId = carModel.id;
				carOwnerModel.insertedById = Common.GlobalData.UserManager.currentUser.id;
				carOwnerModel.insertDate = DateTime.Now;

				opResult = lCarOwner.create(carOwnerModel);		 
				#endregion
			}
			// Create/Modify data

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				result = true ;
			else
			{
				result = false;
				Logger.logger.log (opResult);
				MessageBox.Show (this, "خطا در ذخیره اطلاعات", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	
		 	return result;
		}

		/// <summary>
		/// Insert Legal Owner
		/// </summary>
		private bool saveLegalOwner ()
		{
			bool result = false;
			CommandResult opResult = null;
			Common.BLL.Logic.GasStation.LegalOwner lLegalOwner = new Common.BLL.Logic.GasStation.LegalOwner(Common.Enum.EDatabase.GasStation);
				
			if (legalOwnerModel.id == 0)
			{
				legalOwnerModel.carOwnerId = carOwnerModel.id;
				legalOwnerModel.insertedById = Common.GlobalData.UserManager.currentUser.id;
				legalOwnerModel.insertDate = DateTime.Now;

				opResult = lLegalOwner.create(legalOwnerModel);
			}
			// Create/Modify data

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				result = true ;
			else
			{
				Logger.logger.log (opResult);
				MessageBox.Show (this, "خطا در ذخیره اطلاعات نوع مالک وجود دارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return result;			
		}
			
		/// <summary>
		/// Insert CarTag
		/// </summary>
		/// <returns></returns>
		private bool saveCarTag ()
		{
			bool result = false;
			CommandResult opResult = null;
			Common.BLL.Logic.GasStation.CarTag	lCarTag		= new Common.BLL.Logic.GasStation.CarTag (Common.Enum.EDatabase.GasStation);			

			// Set author data
			if (carTagModel.id == 0)
			{
				#region Insert
				carTagModel.carId = carModel.id;
				carTagModel.tagId = tagModel.id;
				carTagModel.insertedById = Common.GlobalData.UserManager.currentUser.id;
				carTagModel.insertDate = DateTime.Now;

				opResult = lCarTag.create (carTagModel);
				#endregion
			}
			
			// Create/Modify data

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)			
				result = true;			
			
			else
			{
				result = false ;
				Logger.logger.log (opResult);
				MessageBox.Show (this, "خطا در ذخیره اطلاعات ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return result;
		}

		/// <summary>
		/// Insert new Tag
		/// </summary>
		private bool saveTag ()
		{
			BaseBLL.General.FormModelHelper<Common.BLL.Entity.GasStation.Tag>.fillModel (tagDataGroupBox,tagModel);

			bool result = false;
			CommandResult opResult = null;
			Common.BLL.Logic.GasStation.Tag  lTag	= new Common.BLL.Logic.GasStation.Tag (Common.Enum.EDatabase.GasStation);			

			// Set author data
			if (tagModel.id == 0)
			{
				#region Insert
				tagModel.insertedById = Common.GlobalData.UserManager.currentUser.id;
				tagModel.insertDate = DateTime.Now;

				opResult = lTag.create (tagModel);
				#endregion
			}
			
			// Create/Modify data

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)			
				result = true;			
			
			else
			{
				result = false ;
				Logger.logger.log (opResult);
				MessageBox.Show (this, "خطا در ذخیره اطلاعات برچسب وجود دارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return result;
		}
		/// <summary>
		/// Plate Type Change
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PlateTypeComboBox_SelectedIndexChanged (object sender, EventArgs e)
		{
			cityLabel.Visible = false;

			switch ((int)plateTypeComboBox.SelectedValue)
			{
				case ((int)enumPlateType.Personal) : 
						updatePlate (Color.White, Color.Black);	
					break;
				case ((int)enumPlateType.Taxi) :		
						updatePlate (Color.Yellow, Color.Black, "ت");					
					break;
				case ((int)enumPlateType.Polity) : 					
						updatePlate (Color.Red, Color.White, "الف");
					break;
				case ((int)enumPlateType.Malulin) : 
					{
						mainPlatePanel.Visible		= false;
						motorPlatePanel.Visible		= false;
						malulinPlatePanel.Visible	=  true ;
						malulinPlatePanel.Location	= new Point(mainPlatePanel.Location.X, mainPlatePanel.Location.Y);					

					}break;
				case ((int)enumPlateType.Motor) : // موتور سیکلت
					{
						mainPlatePanel.Visible		= false;
						malulinPlatePanel.Visible	= false;
						motorPlatePanel.Visible		= true;
						motorPlatePanel.Location	= new Point(mainPlatePanel.Location.X, mainPlatePanel.Location.Y);					
					}
					break;
				
				default:
					break;
			}
		}

		/// <summary>
		/// Upadte Panel Plate
		/// </summary>
		/// <param name="backColorPart"></param>
		/// <param name="foreColorPart"></param>
		/// <param name="character"></param>
		private void updatePlate (Color backColorPart, Color foreColorPart, string character = null)
		{
			mainPlatePanel.Visible		= true;
			malulinPlatePanel.Visible	= false;
			motorPlatePanel.Visible		= false;
			part1MainTextBox.BackColor	= 
			part2MainTextBox.BackColor	= backColorPart;
			part1MainTextBox.ForeColor	= 
			part2MainTextBox.ForeColor	= foreColorPart;
			characterTextBox.Text		= character;
			
		}		

		/// <summary>
		/// Add Car System
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CarSystemButton_Click (object sender, EventArgs e)
		{
			CarSystemForm	form	= new CarSystemForm();

			if (form.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
				reloadCombo();
		}

		/// <summary>
		/// Add Car Color
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CarColorButton_Click (object sender, EventArgs e)
		{
			CarColorForm	 form	= new CarColorForm ();

			if (form.ShowDialog () == System.Windows.Forms.DialogResult.Cancel)
				reloadCombo ();
		}

		/// <summary>
		/// Add Car Fuel
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CarFuelButton_Click (object sender, EventArgs e)
		{
			CarFuelForm	form	= new CarFuelForm();

			if (form.ShowDialog () ==  System.Windows.Forms.DialogResult.Cancel)
				reloadCombo();
		}

		/// <summary>
		/// Add Car Level
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CarLevelButton_Click (object sender, EventArgs e)
		{
			CarLevelForm	form	= new CarLevelForm();

			if (form.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
				reloadCombo();
		}

		/// <summary>
		/// Add Car Type
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CarTypeButton_Click (object sender, EventArgs e)
		{
			CarTypeForm		form	= new CarTypeForm();

			if (form.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
				reloadCombo();
		}
		/// <summary>
		/// Add Plate Type
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PlateTypeButton_Click (object sender, EventArgs e)
		{
			PlateTypeForm	form	= new PlateTypeForm();
			
			if (form.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
				reloadCombo();
		}
		/// <summary>
		/// Legal Owner Radio Button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LegalRadioButton_CheckedChanged (object sender, EventArgs e)
		{
			legalOwnerGroupBox.Visible	=	true;
		}

		/// <summary>
		/// MainTab ON Change
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void MainTabControl_SelectedIndexChanged (object sender, EventArgs e)
		{
			updateUi ();
		}

		/// <summary>
		/// Update UI
		/// </summary>
		private void updateUi ()
		{
			int	step	= mainTabControl.SelectedIndex;
			int	count	= mainTabControl.TabPages.Count;
			//(step > count -1)
			previousButton.Visible	= ((count-2) - step  > count-2);
			nextButton.Visible		= (step < count-2);
			registerButton.Visible	= (step == count-2);
		}		

		/// <summary>
		/// Next Button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void NextButton_Click (object sender, EventArgs e)
		{
			int				step		= 0;
			CommandResult	opResult	= null;

			// Get step
			step	= mainTabControl.SelectedIndex;

			// Validate step
			opResult	= validate (step);

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
			{
				switch (step)
				{
					case 0 :
						{ 
							// Fill owner Model
							BaseBLL.General.FormModelHelper<Common.BLL.Entity.GasStation.Owner>.fillModel (ownerDataGroupBox, ownerModel);
							ownerModel.nationalCode = "4324260869";
							enableTab(carTabPage, true);
						}
						break;
					case 1 :
						{ 
							// Fill car Model
							carModel.status = true;
							BaseBLL.General.FormModelHelper<Common.BLL.Entity.GasStation.Car>.fillModel (carDataGroupBox, carModel);
							enableTab(plateTabPage, true);							
						}
						break;
					case 2 :
						{
							//Fill plate Model								
							BaseBLL.General.FormModelHelper<Common.BLL.Entity.GasStation.Plate>.fillModel (plateDataGroupBox, plateModel);
							switch (plateModel.plateTypeId)
							{
								case ((int)enumPlateType.Personal) :
								case ((int)enumPlateType.Taxi) :
								case ((int)enumPlateType.Polity) :
									plateModel.plate = part1MainTextBox.Text + "_" +characterTextBox.Text + "_" + part2MainTextBox.Text + "_" + code1Numeric.Text;
									break;
								case ((int)enumPlateType.Malulin):
									plateModel.plate = part1MalulinTextBox.Text + "_" + part2MaluinTextBox.Text + "_" + code2Numeric.Text;
									break;
								case ((int)enumPlateType.Motor):
									plateModel.plate = part1MotorTextBox.Text + "_" + part2MotorTextBox.Text;
									break;
								default:
									break;
							}
							if (!exsistData())
								enableTab(ownerTypeTabPage, true);
							else
							{							
								MessageBox.Show("این شخص قبلا ثبت شده است", "هشدار",MessageBoxButtons.RetryCancel , MessageBoxIcon.Warning);
								//TODO: IF EXSIST DATA What do?
							}

						}
						break;
					case 3 :
						{
							//Fill owner Type Model
							if (legalRadioButton.Checked)
							{
								carOwnerModel.type = true;
								BaseBLL.General.FormModelHelper<Common.BLL.Entity.GasStation.LegalOwner>.fillModel (ownerTypeDataGroupBox, legalOwnerModel);
							}
								else 
								legalOwnerModel = null;
							enableTab(showInfoTabPage, true);
							listviewDetails();
						}
						break;						
					default:
						break;
				}
				nextStep (step);
			}
 				
			else
				MessageBox.Show (opResult.model.ToString (), "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private bool exsistData ()
		{
			bool result = false;
			Common.BLL.Entity.GasStation.Owner	model	= new Common.BLL.Entity.GasStation.Owner ()
			{
				nationalCode = ownerModel.nationalCode					
			};

			Common.BLL.Entity.GasStation.Car	modelCar	= new Common.BLL.Entity.GasStation.Car()
			{
				carTypeId	= carModel.carTypeId,
				carColorId	= carModel.carColorId,
				carSystemId = carModel.carSystemId,
				carLevelId  = carModel.carLevelId,
				carFuelId	= carModel.carFuelId
			};
			Common.BLL.Entity.GasStation.Plate	modelPlate	= new Common.BLL.Entity.GasStation.Plate()
			{
				plateTypeId = plateModel.plateTypeId,
				plateCityId = plateModel.plateCityId,
				plate = plateModel.plate
			};

			// Load model data from db

			Common.BLL.Logic.GasStation.Owner	lOwner	= new Common.BLL.Logic.GasStation.Owner(Common.Enum.EDatabase.GasStation);
			Common.BLL.Logic.GasStation.Car		lCar	= new Common.BLL.Logic.GasStation.Car(Common.Enum.EDatabase.GasStation);
			Common.BLL.Logic.GasStation.Plate	lPlate	= new Common.BLL.Logic.GasStation.Plate(Common.Enum.EDatabase.GasStation);
			
			CommandResult	opResultOwner		= lOwner.read(model);
			CommandResult	opResultCar			= lCar.read(modelCar);
			CommandResult	opResultPlate		= lCar.read(modelPlate);
			
			if (opResultOwner.status	== BaseDAL.Base.EnumCommandStatus.success
				&& opResultCar.status	== BaseDAL.Base.EnumCommandStatus.success
				&& opResultPlate.status == BaseDAL.Base.EnumCommandStatus.success)
				result = true;

			return  result;
		}		

		/// <summary>
		/// Previous Button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PreviousButton_Click (object sender, EventArgs e)
		{
			int				step		= 0;			
			step	= mainTabControl.SelectedIndex;
			// Get step
			previouseStep(step);			
		}
		
		/// <summary>
		/// Select next step
		/// </summary>
		/// <param name="step"></param>
		private void nextStep (int step)
		{
			if (step == mainTabControl.TabPages.Count -1)
			{ 
				//registerData ();
			}
			else if (++step < mainTabControl.TabPages.Count)
				mainTabControl.SelectedIndex	= step;
		}	
		

		/// <summary>
		/// Select previous step
		/// </summary>
		/// <param name="step"></param>
		private void previouseStep (int step)
		{
			if (--step > -1)
				mainTabControl.SelectedIndex	= step;
		}

		/// <summary>
		/// Validate
		/// </summary>
		/// <returns></returns>
		private CommandResult validate (int step)
		{
			CommandResult result	= null;

			switch (step)
			{
				case 0 :
					 result	= validateOwnerData ();
					break;
				case 1:
					result = validateCarData();
					break;
				case 2 :
					result = validatePlateData();
					break;
				case 3 :
					{ 
						if (legalRadioButton.Checked)
							result = validateTypeOwnerData();
						else 
							result = CommandResult.makeSuccessResult ("OK");
					}
					break;
				case 4 :					
						result = CommandResult.makeSuccessResult ("OK");
					break;
 				default :
					break;
			}

			return result;
		}		

		/// <summary>
		/// Validate Owner data
		/// </summary>
		/// <returns></returns>
		private CommandResult validateOwnerData ()
		{
			CommandResult	result;

			List<string>	err				= new List<string> ();
			string			name			= nameTextBox.Text.Trim ();
			string			lastName		= lastNameTextBox.Text.Trim ();
			string			nationalCode	= nationalCodeMaskedTextBox.Text.Trim();			
			string			gen				= genComboBox.Text.Trim();
			string			mobile			= mobileTextBox.Text.Trim();			
			string			birthdate		= birthdateMaskedTextBox.Text;
			string			birthdatelocal	= birthdatelocalTextBox.Text;
			string			phone			= phoneTextBox.Text.Trim();			
			string			address			= addressTextBox.Text.Trim();			

			#region Validate
			if (name.isNullOrEmptyOrWhiteSpaceOrLen (50))
				err.Add ("نام وارد شده نامعتبر می باشد");
			if (lastName.isNullOrEmptyOrWhiteSpaceOrLen (50))
				err.Add ("نام خانوادگی وارد شده نامعتبر می باشد");
			if (nationalCode.isNullOrEmptyOrWhiteSpaceOrLen(10))
				err.Add("کد ملی وارد شده نامعتبر می باشد");
			if (gen.isNullOrEmptyOrWhiteSpaceOrLen(10))
				err.Add("جنسیت نامعتبر می باشد");
			if (mobile.isNullOrEmptyOrWhiteSpaceOrLen(50))
				err.Add("تلفن همراه وارد شده نامعتبر می باشد");
			else if (mobile.Length != 11)
				err.Add("تلفن همراه وارد شده نامعتبر می باشد");

			if (null != birthdate && birthdate.Length > 8)
			{				
				if (!birthdate.isBirthDate(10))
					err.Add("تاریخ تولد وارد شده نامعتبر است");
			}			
			
			#endregion

			// Check for errors
			if (err.Count > 0)
				result	= CommandResult.makeErrorResult ("ERROR", String.Join ("\r\n", err.ToArray ()));
			else
				result	= CommandResult.makeSuccessResult ("OK");

			return result;
		}	

		/// <summary>
		/// Validate Car data
		/// </summary>
		/// <returns></returns>
		private CommandResult validateCarData ()
		{
			CommandResult	result;

			List<string>	err			= new List<string> ();
			string			carType		= carTypeComboBox.Text.Trim ();
			string			carSystem	= carSystemComboBox.Text.Trim ();
			string			carLevel	= carLevelComboBox.Text.Trim ();
			string			carColor	= carColorComboBox.Text.Trim ();
			string			carFuel		= carFuelComboBox.Text.Trim ();
			string			model		= modelNumeric.Text.Trim ();
			string			capacity	= capacityNumeric.Text.Trim ();
			string			engineCode	= engineCodeTextBox.Text.Trim ();
			string			chasisCode	= chasisCodeTextBox.Text.Trim ();

			#region Validate
			if (carType.isNullOrEmptyOrWhiteSpaceOrLen(50))
				err.Add("نوع خودرو انتخاب شده نامعتبر می باشد");
			if (carSystem.isNullOrEmptyOrWhiteSpaceOrLen(50))
				err.Add("سیستم خودرو انتخاب شده نامعتبر می باشد");
			if (carLevel.isNullOrEmptyOrWhiteSpaceOrLen(50))
				err.Add("تیپ خودرو انتخاب شده نامعتبر می باشد");
			if (carColor.isNullOrEmptyOrWhiteSpaceOrLen(50))
				err.Add("رنگ خودرو انتخاب شده نامعتبر می باشد");
			if (carFuel.isNullOrEmptyOrWhiteSpaceOrLen(50))
				err.Add("سوخت خودرو انتخاب شده نامعتبر می باشد");
			if (model.isNullOrEmptyOrWhiteSpaceOrLen(50))
				err.Add("مدل خودرو وارد شده نامعتبر می باشد");
			if (capacity.isNullOrEmptyOrWhiteSpaceOrLen(50))
				err.Add("ظرفیت وارد شده نامعتبر می باشد");
			if (engineCode.isNullOrEmptyOrWhiteSpaceOrLen(50))
				err.Add("شماره موتور وارد شده نامعتبر می باشد");
			if (chasisCode.isNullOrEmptyOrWhiteSpaceOrLen(50))
				err.Add("شماره شاسی وارد شده نامعتبر می باشد");

			#endregion

			// Check for errors
			if (err.Count > 0)
				result	= CommandResult.makeErrorResult ("ERROR", String.Join ("\r\n", err.ToArray ()));
			else
				result	= CommandResult.makeSuccessResult ("OK");

			return result;
		}
	
		/// <summary>
		/// Validate Plate data
		/// </summary>
		/// <returns></returns>
		private CommandResult validatePlateData ()
		{
			CommandResult	result;
			
			List<string>	err				= new List<string> ();
			string		part1Main		= part1MainTextBox.Text.Trim();
			string		part2Main		= part2MainTextBox.Text.Trim();
			string		code1			= code1Numeric.Text.Trim();
			string		character		= characterTextBox.Text.Trim();
			string		part1Malulin	= part1MalulinTextBox.Text.Trim();
			string		part2Maluin		= part2MaluinTextBox.Text.Trim();
			string		code2			= code2Numeric.Text.Trim();
			string		part1Motor		= part1MotorTextBox.Text.Trim();
			string		part2Motor		= part2MotorTextBox.Text.Trim();

			#region Validate
			switch ((int)plateTypeComboBox.SelectedValue)
			{
				case ((int)enumPlateType.Personal) :
				case ((int)enumPlateType.Taxi) :
				case ((int)enumPlateType.Polity) : 
					{
						if (part1Main.isNullOrEmptyOrWhiteSpaceOrLen(2))
							err.Add("بخش اول پلاک وارد شده نامعتبر می باشد");
						if (part2Main.isNullOrEmptyOrWhiteSpaceOrLen(3))
							err.Add("بخش دوم پلاک وارد شده نامعتبر می باشد");
						if (code1.isNullOrEmptyOrWhiteSpaceOrLen(2))
							err.Add("کد شهر پلاک وارد شده نامعتبر می باشد");
						else if (null == getNameCity(code1))
							err.Add("کد شهر پلاک وارد شده نامعتبر می باشد");
						if (character.isNullOrEmptyOrWhiteSpaceOrLen(3))
							err.Add("حرف وارد شده نامعتبر است");
					}
					break;								
						
				case ((int)enumPlateType.Malulin) : 
					{		
						if (part1Malulin.isNullOrEmptyOrWhiteSpaceOrLen(2))
							err.Add("بخش اول پلاک وارد شده نامعتبر می باشد");
						if (part2Maluin.isNullOrEmptyOrWhiteSpaceOrLen(3))
							err.Add("بخش دوم پلاک وارد شده نامعتبر می باشد");
						if (code2.isNullOrEmptyOrWhiteSpaceOrLen(2))
							err.Add("کد شهر پلاک وارد شده نامعتبر می باشد");
						else if (null == getNameCity(code2))
							err.Add("کد شهر پلاک وارد شده نامعتبر می باشد");						

					}break;
				case ((int)enumPlateType.Motor) : // موتور سیکلت
					{
						if (part1Motor.isNullOrEmptyOrWhiteSpaceOrLen(6))
							err.Add("بخش اول پلاک وارد شده نامعتبر می باشد");
						if (part2Motor.isNullOrEmptyOrWhiteSpaceOrLen(6))
							err.Add("بخش دوم پلاک وارد شده نامعتبر می باشد");	
					}
					break;
				
				default:
					break;
			}			
			#endregion

			// Check for errors
			if (err.Count > 0)
				result	= CommandResult.makeErrorResult ("ERROR", String.Join ("\r\n", err.ToArray ()));
			else
				result	= CommandResult.makeSuccessResult ("OK");

			return result;
		}	
			
		/// <summary>
		/// Validate Type Owner data
		/// </summary>
		/// <returns></returns>
		private CommandResult validateTypeOwnerData ()
		{
			CommandResult	result;

			List<string>	err				= new List<string> ();
			//Select legal RadioButton 
			string			OrganizationCode	= OrganizationCodeTextBox.Text.Trim ();
			string			orgName				= orgNameTextBox.Text.Trim ();
					

			#region Validate
			if (OrganizationCode.isNullOrEmptyOrWhiteSpaceOrLen (50))
				err.Add ("کد شناسایی سازمان وارد شده نامعتبر می باشد");
			if (orgName.isNullOrEmptyOrWhiteSpaceOrLen (50))
				err.Add ("نام سازمان وارد شده نامعتبر می باشد");
			
			#endregion

			// Check for errors
			if (err.Count > 0)
				result	= CommandResult.makeErrorResult ("ERROR", String.Join ("\r\n", err.ToArray ()));
			else
				result	= CommandResult.makeSuccessResult ("OK");

			return result;
		}		
			
		/// <summary>
		/// Close Success
		/// </summary>
		private void CloseSuccess ()
		{
			DialogResult	= System.Windows.Forms.DialogResult.OK;
			Close ();
		}

		
		/// <summary>
		/// Get Name City and Get cityId
		/// </summary>
		/// <param name="code"></param>
		/// <returns></returns>
		private string getNameCity(string code)
		{
			string result = null;
			Common.BLL.Logic.GasStation.Base__PlateCity		lPlateCity		= new Common.BLL.Logic.GasStation.Base__PlateCity (Common.Enum.EDatabase.GasStation);
			DataTable	resultPlateCity		= lPlateCity.allData("","", false).model as DataTable;
			
			var resultItem = (from myRow in resultPlateCity.AsEnumerable()
							where myRow.Field<string>("code") == code
							select myRow).FirstOrDefault();
			if (null != resultItem)
			{
				plateModel.plateCityId = (int)resultItem.ItemArray[0];
				result = resultItem.ItemArray[3].ToString();
			}			

			return  result;		
		}	

		 public void transmitprotocol()
        {
            BackgroundWorker bw = new BackgroundWorker();
			bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
            
            try
            {
                bw.RunWorkerAsync();//this will run all Transmitting protocol coding at background thread               
				loadingPictureBox.Image = Properties.Resources.loading25;
				loadingLabel.Visible = true;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

		void bw_DoWork(object sender, DoWorkEventArgs e)
		{
			System.Threading.Thread.Sleep(2 * 1000); //this code take 5 seconds to be passed
		}
        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            loadingPictureBox.Image = null;
			loadingLabel.Visible = false;
        }

		/// <summary>
		/// Get Tag Button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GetTagButton_Click (object sender, EventArgs e)
		{			
			//transmitprotocol();
			tagTextBox.Clear();
			Common.BLL.Entity.GasStation.UHF	model	= new Common.BLL.Entity.GasStation.UHF ()
				{
					id	= 1
				};

			Common.BLL.Logic.GasStation.UHF		lUHF	= new Common.BLL.Logic.GasStation.UHF (Common.Enum.EDatabase.GasStation);
			CommandResult opResult = lUHF.read(model);
			if (null != model)
			{				
				anntenaClient 	=  new AntennaClient (model.IP , model.Port, C_BufferSize);
				anntenaClient.onConnect		+= anntenaClient_onConnect;
				anntenaClient.onReceiveData	+= anntenaClient_onReceiveData;
				anntenaClient.onError		+= anntenaClient_onError;
				anntenaClient.connect();
			}				 
		}		

		/// <summary>
		/// On Connect
		/// </summary>
		/// <param name="sender"></param>
		private void anntenaClient_onConnect (NetTcpClient sender)
		{
			Invoke((Action)delegate
			{
				loadingPictureBox.Image = Properties.Resources.loading25;
				loadingLabel.Visible = true;
				loadingLabel.Text = "در حال دریافت اطلاعات از آنتن .....";
				getTagButton.Enabled = false;
			});
		}	
		/// <summary>
		/// On Error
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="data"></param>
		private void anntenaClient_onError (NetTcpClient sender, CommandResult data)
		{
			Invoke((Action)delegate
			{
				MessageBox.Show("خطا در ارتباط با آنتن","خطا",MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
			});
		}

		/// <summary>
		/// On Receive
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="data"></param>
		private void anntenaClient_onReceiveData (NetTcpClient sender, CommandResult data)
		{
			Invoke ((Action)delegate
			{
				tagTextBox.Text = Encoding.UTF8.GetString(data.model as byte[]);
				anntenaClient.disconnect();
				loadingPictureBox.Image		= null;
				loadingLabel.Visible		= false;
				getTagButton.Enabled		= true;

			});
		}

		#endregion		
	}
}