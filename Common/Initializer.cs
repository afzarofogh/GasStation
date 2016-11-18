using BaseDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
	public class Initializer
	{
		public static void init ()
		{
			///TODO: READ CONFIG FILE
			ConnectionModel	cm	= new ConnectionModel ()
			{
				dataSource	= ".",
				initCatalog	= "GasStation",
				userId		= "admin",
				password	= "12345"
			};

			BaseDAL.Base.Connection.dataSources.Add (Common.Enum.EDatabase.GasStation.ToString (), cm);
		}
	}
}
