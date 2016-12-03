using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AntennaServiceInstaller.Forms
{
	public partial class ServiceControllerForm : Form
	{
		#region Constants
		private string	serviceName;
		private string	serverName;
		#endregion

		#region Methods
		/// <summary>
		/// Constructor
		/// </summary>
		public ServiceControllerForm ()
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
		/// Bind Events
		/// </summary>
		private void bindEvents ()
		{
			startServiceButton.Click    += StartServiceButton_Click;
			stopServiceButton.Click     += StopServiceButton_Click;
			pauseServiceButton.Click    += PauseServiceButton_Click;
		}

		/// <summary>
		/// Puase Service
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PauseServiceButton_Click (object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Stop Service
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void StopServiceButton_Click (object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Start Service
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void StartServiceButton_Click (object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Prepare
		/// </summary>
		private void prepare ()
		{
			serverName	= System.Configuration.ConfigurationSettings.AppSettings["serviceName"];
		}

		/// <summary>
		/// Get Service status
		/// </summary>
		private void updateStatus ()
		{
		}
		#endregion
		
	}
}
