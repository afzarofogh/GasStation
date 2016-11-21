using BaseDAL.Model;
using Common.Helper.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
	public class Initializer
	{
		/// <summary>
		/// Init
		/// </summary>
		public static void init (string loggerFilename)
		{
			///TODO: READ CONFIG FILE
			ConnectionModel	cm	= new ConnectionModel ()
			{
				dataSource	= ".",
				initCatalog	= "GasStation",
				userId		= "admin",
				password	= "12345"
			};

			Logger.logger	= new Helper.Logger.Logger(loggerFilename);
			BaseDAL.Base.Connection.dataSources.Add (Common.Enum.EDatabase.GasStation.ToString (), cm);
		}
	}
}
