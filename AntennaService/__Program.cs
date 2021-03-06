﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace AntennaService
{
	static class __Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main ()
		{
			string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
			Common.Initializer.init ("log.txt", path);

			ServiceBase[] ServicesToRun;
			ServicesToRun = new ServiceBase[]
			{
				new AntennaService()
			};
			ServiceBase.Run (ServicesToRun);
		}
	}
}
