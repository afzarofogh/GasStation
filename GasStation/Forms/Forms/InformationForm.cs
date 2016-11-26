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
	public partial class InformationForm : Form
	{

		#region Properties
		#endregion

		#region Variable
		
		#endregion

		#region Methods		
		
		public InformationForm ()
		{
			InitializeComponent ();

			init ();
		}

		private void init ()
		{
			bindEvents ();
			prepare ();
		}

		private void prepare ()
		{
			throw new NotImplementedException ();
		}

		private void bindEvents ()
		{
			carTypeButton.Click		+= CarTypeButton_Click;
			carSystemButton.Click	+= CarSystemButton_Click;
			carLevelButton.Click	+= CarLevelButton_Click;
		}

		private void CarLevelButton_Click (object sender, EventArgs e)
		{
			
		}

		void CarSystemButton_Click (object sender, EventArgs e)
		{
			
		}

		private void CarTypeButton_Click (object sender, EventArgs e)
		{
			
		}	
		
		#endregion		
	}
}
