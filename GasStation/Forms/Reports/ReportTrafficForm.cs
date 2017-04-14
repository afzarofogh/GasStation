using BaseDAL.Model;
using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GasStation.Forms.Reports
{
	public partial class ReportTrafficForm : General.SuperForm
	{
		#region Method		
		
		public ReportTrafficForm ()
		{
			InitializeComponent ();
			init();
		}

		/// <summary>
		/// Initilizer
		/// </summary>
		private void init ()
		{
			bindEvents();

			prepare();
		}
		/// <summary>
		/// Bind Events
		/// </summary>
		private void bindEvents ()
		{
			showButton.Click += showButton_Click;
			printButton.Click += printButton_Click;
			typeComboBox.SelectedIndexChanged += TypeComboBox_SelectedIndexChanged;
		}

		private void TypeComboBox_SelectedIndexChanged (object sender, EventArgs e)
		{
			if (typeComboBox.SelectedIndex == 1)
			{			
				nationalCodeMaskedTextBox.Visible = true;
				plateDataGroupBox.Visible = false;
				nationalCodeMaskedTextBox.Clear();
				nationalCodeMaskedTextBox.Focus();
			}
			else if (typeComboBox.SelectedIndex == 2)
			{			
				plateDataGroupBox.Visible = true;
				nationalCodeMaskedTextBox.Visible = false;
			}
		}
		
		/// <summary>
		/// Prepare
		/// </summary>
		private void prepare ()
		{
			dateStartMaskedTextBox.Text = 
			dateEndMaskedTextBox.Text = ExtensionsDateTime.toPersianDate(DateTime.Now);
			typeComboBox.SelectedIndex = 0;
		}

		DataTable 	result;
		/// <summary>
		/// Print Reoort
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void printButton_Click (object sender, EventArgs e)
		{
			StiReport mainreport = new StiReport ();
			
			mainreport.RegBusinessObject("traffic",result);
			mainreport.Load(Application.StartupPath + "\\Reports\\traffic.mrt");
			mainreport.Compile();
			mainreport["myDate"]= ExtensionsDateTime.toPersianDate(DateTime.Now);
			mainreport.Render();	
			mainreport.Show();
		}
		/// <summary>
		/// Show Report 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void showButton_Click (object sender, EventArgs e)
		{
			try
			{
				string dateStart= dateStartMaskedTextBox.Text.Trim();
				string dateEnd = dateEndMaskedTextBox.Text.Trim();				
				Common.BLL.Logic.GasStation.Traffic		lTraffic = new Common.BLL.Logic.GasStation.Traffic (Common.Enum.EDatabase.GasStation);
				if (ExtensionsDateTime.isValidDate(dateStart) && ExtensionsDateTime.isValidDate(dateEnd))
				{					
					DateTime date1 = ExtensionsDateTime.persianToMiladi(dateStart);
					DateTime date2 = ExtensionsDateTime.persianToMiladi(dateEnd).Add (new TimeSpan (23, 59, 59));

					if (typeComboBox.SelectedIndex == 0)
					{						
						CommandResult opResult = lTraffic.loadTraffic(date1, date2);		
						DataTable  resultData = opResult.model as DataTable;
						result = ExtensionsDateTable.makePersianDate(resultData);
						UserControls.StateTrafficUserControl  stateTraffic = new UserControls.StateTrafficUserControl (result);
						stateTabPage.Controls.Add(stateTraffic);
					}
					else if (typeComboBox.SelectedIndex == 1)
					{
						string nationalcode = nationalCodeMaskedTextBox.Text.Trim();
						
						CommandResult opResult = lTraffic.loadTrafficByNationalcode(date1, date2, nationalcode);		
						DataTable  resultData = opResult.model as DataTable;
						result = ExtensionsDateTable.makePersianDate(resultData);
						UserControls.StateTrafficUserControl  stateTraffic = new UserControls.StateTrafficUserControl (result);
						stateTabPage.Controls.Add(stateTraffic);
					}
					else if (typeComboBox.SelectedIndex == 2)
					{
						//TODO: fill plate
						string plate = string.Empty;
						
						CommandResult opResult = lTraffic.loadTrafficByPlate(date1, date2, plate);		
						DataTable  resultData = opResult.model as DataTable;
						result = ExtensionsDateTable.makePersianDate(resultData);
						UserControls.StateTrafficUserControl  stateTraffic = new UserControls.StateTrafficUserControl (result);
						stateTabPage.Controls.Add(stateTraffic);
					}				
					

					//resultGrid.DataSource = result;
					//resultGrid.loadHeader(this.GetType().Name);		

				}
				else
				{
					//TODO: Date isnot Valid
				}

			}
			catch (Exception ex)
			{				
				
			}
		}
		#endregion

		
	}
}
