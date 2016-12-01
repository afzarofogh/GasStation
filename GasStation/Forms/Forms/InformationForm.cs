using BaseDAL.Model;
using GasStation.Enum;
using GasStation.Forms.Base;
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
	public partial class InformationForm : General.SuperForm
	{

		#region Properties
		#endregion

		#region Variable
		
		Common.BLL.Entity.GasStation.Owner 			ownerModel;	
		Common.BLL.Entity.GasStation.Car			carModel;		
		Common.BLL.Entity.GasStation.CarOwner		carOwnerModel;
		Common.BLL.Entity.GasStation.Plate			plateModel;		
		Common.BLL.Entity.GasStation.LegalOwner		legalOwnerModel;
		

		#endregion

		#region Methods		
		
		
		public InformationForm ()
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

			if (carOwnerModel.type)
				InfoListView.Items.Add(new ListViewItem(new string[]{   "نوع مالک", 	"حقیقی"},		ownerType_group));
			else
			{ 
				InfoListView.Items.Add(new ListViewItem(new string[]{   "نوع مالک", 	"حقوقی"},											ownerType_group));
				InfoListView.Items.Add(new ListViewItem(new string[]{   "کد شناسایی سازمان", 		legalOwnerModel.OrganizationCode},		ownerType_group));
				InfoListView.Items.Add(new ListViewItem(new string[]{   "نام سازمان", 				legalOwnerModel.name},					ownerType_group));
			}
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


			// Update ui
			updateUi ();

			enableTab(carTabPage, false);
			enableTab(plateTabPage, false);
			enableTab(ownerTypeTabPage, false);
			enableTab(showInfoTabPage, false);
			enableTab(tagTabPage, false);
	
			//TODO: Init value combo and get id value
			reloadCombo();

			listviewDetails();
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
			genComboBox.DataSource = System.Enum.GetValues(typeof(enumGenType));

			// Car Color
			Common.BLL.Logic.GasStation.Base__CarColor	lCarColor	= new Common.BLL.Logic.GasStation.Base__CarColor (Common.Enum.EDatabase.GasStation);
			CommandResult	opResultColor			= lCarColor.allData("", "color", false);			
			carColorComboBox.DataSource				= opResultColor.model;

			//Car Type
			Common.BLL.Logic.GasStation.Base__CarType	lCarType	= new Common.BLL.Logic.GasStation.Base__CarType (Common.Enum.EDatabase.GasStation);
			CommandResult	opResultType			= lCarType.allData("", "type", false);			
			carTypeComboBox.DataSource				= opResultType.model;

			//Car Fuel
			Common.BLL.Logic.GasStation.Base__CarFuel	lCarFuel	= new Common.BLL.Logic.GasStation.Base__CarFuel (Common.Enum.EDatabase.GasStation);
			CommandResult	opResultFuel			= lCarFuel.allData("", "fuel", false);			
			carFuelComboBox.DataSource				= opResultFuel.model;

			//Car Level
			Common.BLL.Logic.GasStation.Base__CarLevel	lCarLevel	= new Common.BLL.Logic.GasStation.Base__CarLevel (Common.Enum.EDatabase.GasStation);
			CommandResult	opResultLevel			= lCarLevel.allData("", "levelcar", false);			
			carLevelComboBox.DataSource				= opResultLevel.model;

			//Car System
			Common.BLL.Logic.GasStation.Base__CarSystem		lCarSystem	= new Common.BLL.Logic.GasStation.Base__CarSystem (Common.Enum.EDatabase.GasStation);
			CommandResult	opResultSystem			= lCarSystem.allData("", "system", false);			
			carSystemComboBox.DataSource			= opResultSystem.model;

			//Plate type 
			Common.BLL.Logic.GasStation.Base__PlateType		lPlateType		= new Common.BLL.Logic.GasStation.Base__PlateType (Common.Enum.EDatabase.GasStation);
			CommandResult	opResultPlateType		= lPlateType.allData("", "type", false);			
			plateTypeComboBox.DataSource			= opResultPlateType.model;

			//TODO: get code city from Database
			Common.BLL.Logic.GasStation.Base__PlateCity		lPlateCity		= new Common.BLL.Logic.GasStation.Base__PlateCity (Common.Enum.EDatabase.GasStation);
			CommandResult	opResultPlateCity		= lPlateType.allData("", "code", false);			
			code1Numeric.Items.Add(opResultPlateType.model);
			
		}

		/// <summary>
		/// Bind Events
		/// </summary>
		private void bindEvents ()
		{
			
			mainTabControl.SelectedIndexChanged		+= mainTabControl_SelectedIndexChanged;
			plateTypeComboBox.SelectedIndexChanged	+= plateTypeComboBox_SelectedIndexChanged;
			legalRadioButton.CheckedChanged			+= legalRadioButton_CheckedChanged;
			carTypeComboBox.SelectedIndexChanged	+= carTypeComboBox_SelectedIndexChanged;

			nextButton.Click						+= nextButton_Click;
			previousButton.Click					+= previousButton_Click;
			carTypeButton.Click						+= carTypeButton_Click;
			carSystemButton.Click					+= carSystemButton_Click;
			carColorButton.Click					+= carColorButton_Click;
			carFuelButton.Click						+= carFuelButton_Click;
			carLevelButton.Click					+= carLevelButton_Click;
			plateTypeButton.Click					+= plateTypeButton_Click;

			getTagButton.Click						+= getTagButton_Click;
			
		}

		private void getTagButton_Click (object sender, EventArgs e)
		{
			transmitprotocol();
		}	

		
		private void carTypeComboBox_SelectedIndexChanged (object sender, EventArgs e)
		{
			string type = carTypeComboBox.Text;
			Common.BLL.Entity.GasStation.Base__CarType  	typeModel = new Common.BLL.Entity.GasStation.Base__CarType ()
			{
				type = type
			};
			
			Common.BLL.Logic.GasStation.Base__CarType	lCartype	= new Common.BLL.Logic.GasStation.Base__CarType(Common.Enum.EDatabase.GasStation);
			CommandResult	opResult	= lCartype.read(typeModel);
			//MessageBox.Show( typeModel.id.ToString());			
		}

		

		/// <summary>
		/// Plate Type Change
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void plateTypeComboBox_SelectedIndexChanged (object sender, EventArgs e)
		{
			//TODO: Select Plate by type and Select Panel
		}		

		/// <summary>
		/// Add Car System
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void carSystemButton_Click (object sender, EventArgs e)
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
		private void carColorButton_Click (object sender, EventArgs e)
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
		private void carFuelButton_Click (object sender, EventArgs e)
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
		private void carLevelButton_Click (object sender, EventArgs e)
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
		private void carTypeButton_Click (object sender, EventArgs e)
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
		private void plateTypeButton_Click (object sender, EventArgs e)
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
		private void legalRadioButton_CheckedChanged (object sender, EventArgs e)
		{
			legalOwnerGroupBox.Visible	=	true;
		}

		/// <summary>
		/// MainTab ON Change
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void mainTabControl_SelectedIndexChanged (object sender, EventArgs e)
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

			previousButton.Visible		= (step > count-1);
			nextButton.Visible		= (step < count-2);
			registerButton.Visible	= (step == count-2);
		}		

		/// <summary>
		/// Next Button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void nextButton_Click (object sender, EventArgs e)
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
							enableTab(carTabPage, true);
						}
						break;
					case 1 :
						{ 
							// Fill car Model

							Common.BLL.Entity.GasStation.Base__CarColor 	colorModel	= new Common.BLL.Entity.GasStation.Base__CarColor ()
							{
								color = carColorComboBox.Text
							};
							Common.BLL.Entity.GasStation.Base__CarFuel  	fuelModel	= new Common.BLL.Entity.GasStation.Base__CarFuel ()
							{
								fuel = carFuelComboBox.Text
							};
							Common.BLL.Entity.GasStation.Base__CarLevel		levelModel	= new Common.BLL.Entity.GasStation.Base__CarLevel ()
							{
								levelcar = carLevelComboBox.Text
							};
							Common.BLL.Entity.GasStation.Base__CarSystem	systemModel	= new Common.BLL.Entity.GasStation.Base__CarSystem ()
							{
								 system = carSystemComboBox.Text
							};
							Common.BLL.Entity.GasStation.Base__CarType  	typeModel	= new Common.BLL.Entity.GasStation.Base__CarType ()
							{
								 type = carTypeComboBox.Text
							};


							carModel.carColorId		= colorModel.id;
							carModel.carFuelId		= fuelModel.id;
							carModel.carLevelId		= levelModel.id;
							carModel.carSystemId	= systemModel.id;
							carModel.carTypeId		= typeModel.id;

							BaseBLL.General.FormModelHelper<Common.BLL.Entity.GasStation.Car>.fillModel (carDataGroupBox, carModel);
							enableTab(plateTabPage, true);
							//TODO: status car = true
						}
						break;
					case 2 :
						{
							//Fill plate Model
							BaseBLL.General.FormModelHelper<Common.BLL.Entity.GasStation.Plate>.fillModel (plateDataGroupBox, plateModel);
							enableTab(ownerTypeTabPage, true);
						}
						break;
					case 3 :
						{
							//Fill owner Type Model
							if (legalRadioButton.Checked)
								BaseBLL.General.FormModelHelper<Common.BLL.Entity.GasStation.LegalOwner>.fillModel (ownerTypeDataGroupBox, legalOwnerModel);
							enableTab(ownerTypeTabPage, true);	
						}
						break;
					case 4 :
						{
							//Register Data

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

		/// <summary>
		/// Previous Button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void previousButton_Click (object sender, EventArgs e)
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
			string			nationalCode	= nationalCodeTextBox.Text.Trim();
			//TODO: get value gen
			string			gen				= genComboBox.Text.Trim();
			string			mobile			= mobileTextBox.Text.Trim();
			//TODO: get value birthdate
			//string			birthdate		= birthdateMaskedTextBox.Text;
			//string			birthdatelocal	= birthdatelocalTextBox.Text;
			//string			phone			= phoneTextBox.Text.Trim();
			
			//string			address			= addressTextBox.Text.Trim();			

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
			//if (birthdate.isNullOrEmptyOrWhiteSpaceOrLen(10))
			//	err.Add("تاریخ تولد وارد شده نامعتبر می باشد");
			//if (birthdatelocal.isNullOrEmptyOrWhiteSpaceOrLen(50))
			//	err.Add("محل تولد وارد شده نامعتبر می باشد");
			//if (phone.isNullOrEmptyOrWhiteSpaceOrLen(50))
			//	err.Add("تلفن ثابت وارد شده نامعتبر می باشد");			
			//if (address.isNullOrEmptyOrWhiteSpaceOrLen(1000))
			//	err.Add("آدرس وارد شده نامعتبر می باشد");
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

		//TODO : complate function validatePlateData

		/// <summary>
		/// Validate Plate data
		/// </summary>
		/// <returns></returns>
		private CommandResult validatePlateData ()
		{
			CommandResult	result;

			//TODO: By Combo Type textBoxs will check
			List<string>	err				= new List<string> ();			
			
			#region Validate
			
			
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

		#endregion		
	}
}
