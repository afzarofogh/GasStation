using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace AntennaService
{
	public partial class AntennaService : ServiceBase
	{
		#region Constants
		/// <summary>
        /// Antenna Event Source name 
        /// </summary>
		public const string C_ANTENNA_EVENT_SOURCE	= "AntennaService";
		
		/// <summary>
        /// Antenna Event Log name 
        /// </summary>
		public const string C_ANTENNA_EVENT_LOG	= "AntennaLog";

		public const string C_CONF_FILENAME			= "";
		#endregion

		#region	Variables
		/// <summary>
        /// Event Log 
        /// </summary>
		EventLog eventLog;
		#endregion

		#region Methods
		/// <summary>
        /// Constrcutor 
        /// </summary>
		public AntennaService ()
		{
			InitializeComponent ();

			init ();
		}

        /// <summary>
        /// On Start 
        /// </summary>
        /// <param name="args"></param>
        protected override void OnStart (string[] args)
		{
			writeLog ("SERVICE STARTED");

			/// TODO: Try to Connect to antenna
		}

		/// <summary>
        /// On Stop 
        /// </summary>
		protected override void OnStop ()
		{
			writeLog ("SERVICE STOPPED");			
		}

		/// <summary>
        /// Initialize 
        /// </summary>
        private void init()
        {
            prepare ();
        }

		/// <summary>
        /// Prepare 
        /// </summary>
		private void prepare ()
		{
			makeEventLog ();
		}

		/// <summary>
        /// Make event log 
        /// </summary>
		private void makeEventLog ()
		{
			eventLog	= new EventLog ();
			if (!EventLog.Exists (C_ANTENNA_EVENT_SOURCE))
				EventLog.CreateEventSource (C_ANTENNA_EVENT_SOURCE, C_ANTENNA_EVENT_SOURCE);
			eventLog.Source	= C_ANTENNA_EVENT_SOURCE;
			eventLog.Log	= C_ANTENNA_EVENT_LOG;
		}

		/// <summary>
        /// Write log 
        /// </summary>
        /// <param name="log"></param>
		private void writeLog (string log)
		{
			if (null != eventLog)
				eventLog.WriteEntry (log);
		}
		#endregion
	}
}
