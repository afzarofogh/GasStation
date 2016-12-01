using BaseDAL.Model;
using Common.Helper.Antenna;
using Common.Network.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;

namespace AntennaService
{
	public partial class AntennaService : ServiceBase
	{
		/*
			Serivce Arguments:	[Antenna Host] [Antenna Port] [Server Port]
		*/

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
		private EventLog eventLog;

		private byte	tag_flag		= 0;
		private int		tagCount		= 0;
		private int		lastStatus		= 0;
		private byte[,]	tagData			= null;

		private MR6100				antennaWrapper	= null;
		private NetTcpServer		tcpServer		= null;
		private ManualResetEvent	mrs				= null;
		private Thread				tagReadThread	= null;

		private const int		C_BufferSize	= 1024;
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
			mrs	= new ManualResetEvent (true);
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
			{
				log	+= "\r\n" + DateTime.Now.ToString ("yyyy/MM/dd HH:mm:ss");
				eventLog.WriteEntry (log);
			}
		}
		
        /// <summary>
        /// On Start 
        /// </summary>
        /// <param name="args"></param>
        protected override void OnStart (string[] args)
		{
			bool	hasError	= false;
			string	antHost		= "";
			int		antPort		= 0;
			int		sPort		= 0;

			#region Parse Args
			if (args.Length > 2)
			{
				antHost	= args[0];
				antPort	= args[1].toInt (0);
				sPort	= args[2].toInt (0);
			}
			else
				hasError = true;
			#endregion

			#region Validate / Run Service
			if (hasError)
				writeLog ("ERR: INVALID ARGUMENTS, Use : ServiceName {ant host} {ant port} {server port}");
			else
			{
				// Try to connect to Antenna
				hasError    = connectToAntenna (antHost, antPort);

				// Try to start client listener
				if (!hasError)
					startClientListener (sPort);

				// Stop service on fail
				if (hasError)
					stop ();					
			} 
			#endregion
		}

		/// <summary>
		/// On Stop 
		/// </summary>
		protected override void OnStop ()
		{
			stop ();	
		}
		
		/// <summary>
		/// On Stop 
		/// </summary>
		private void stop ()
		{
			if (null != antennaWrapper)
				antennaWrapper.CloseCommPort ();
			stopClientListener ();

			writeLog ("INF: Service Stopped successfully");			
		}
		
		/// <summary>
		/// On Continue
		/// </summary>
		protected override void OnContinue ()
		{
			resume ();
			base.OnContinue ();
		}

		/// <summary>
		/// On Pause
		/// </summary>
		protected override void OnPause ()
		{
			pause ();

			base.OnPause ();
		}

		/// <summary>
		/// Pause
		/// </summary>
		private void pause ()
		{
			if (null != mrs)
				mrs.Reset ();
		}

		/// <summary>
		/// Resume
		/// </summary>
		private void resume ()
		{
			if (null != mrs)
				mrs.Set ();
		}


		/// <summary>
		/// Start Tag Listen Thread
		/// </summary>
		private void startTagListenThread ()
		{
			tagReadThread	= new Thread (new ThreadStart (delegate
			{
				try
				{
					while (null != antennaWrapper)
					{
						// Wait - if need
						mrs.WaitOne ();

						lastStatus = antennaWrapper.EpcMultiTagIdentify (255, ref tagData, ref tagCount, ref tag_flag);

						if (lastStatus == MR6100.SUCCESS_RETURN)
						{
							#region Parse ID
							string strAnteNo = "", strID = "", strTemp = "";
							int j = 0;

							for (int i = 0; i < tagCount; i++)
							{
								j           = 0;
								strID       = "";
								strAnteNo   = string.Format ("{0:X2}", tagData[i, 1]);

								// update: 0->2, 12->14
								for (j = 2; j < 14; j++)
								{
									strTemp = string.Format ("{0:X2}", tagData[i, j]);
									strID	+= strTemp;
								}

								if (strID != "000000000000000000000000")
									tagDetected (strID);
							} 
							#endregion
						}
					}
				}
				catch (Exception ex)
				{
					///TODO: LOG ERROR
				}
			}));

			tagReadThread.Start ();
		}

		/// <summary>
		/// Tag Detected
		/// </summary>
		/// <param name="tagId"></param>
		private void tagDetected (string tagId)
		{
			Helper.ClientMethodParser.writeTag (tcpServer, tagId);
		}

		/// <summary>
		/// Connect to antenna
		/// </summary>
		private bool connectToAntenna (string host, int port)
		{
			bool hasError = false;

			if (null == antennaWrapper)
				antennaWrapper	= new MR6100 ();

			tag_flag	= 0;
			tagCount	= 0;
			tagData		= new byte[500, 14];

			// Start Reader
			lastStatus	= antennaWrapper.TcpConnectReader (host, port);
	
			// Check result
			if (lastStatus != MR6100.SUCCESS_RETURN)
			{
				hasError = true;
				writeLog ("ERR: Connect to antenna failed");
			}
			else
			{
				startTagListenThread ();

				writeLog ("INF: Service Started Successfully");
			}

			return !hasError;
		}

		/// <summary>
		/// Start Client Listener
		/// </summary>
		private void startClientListener (int port)
		{
			if (null == tcpServer)
			{
				tcpServer = new NetTcpServer (port, C_BufferSize);

				tcpServer.onReceiveData  += TcpServer_onReceiveData;
			}
		}

		/// <summary>
		/// Stop Client Listener
		/// </summary>
		private void stopClientListener ()
		{
			if (null != tcpServer)
				tcpServer.stop ();
			tcpServer	= null;
		}

		/// <summary>
		/// TcpServer 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="client"></param>
		/// <param name="data"></param>
		private void TcpServer_onReceiveData (NetTcpServer sender, NetTcpClient client, CommandResult data)
		{
			Helper.ClientMethodParser.parseCmd (client, data);
		}
		#endregion
	}
}
