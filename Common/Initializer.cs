﻿using BaseDAL.Model;
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
		public static void init (string loggerFilename, string exePath)
		{						
			ConnectionModel res = Common.Helper.Setting.SettingHelper.readConfigData(exePath);			
			ConnectionModel	cm	= new ConnectionModel ()
			{
				dataSource	= res.dataSource,
				initCatalog	= res.initCatalog,
				userId		= res.userId,
				password	= res.password
			};

			Logger.logger	= new Helper.Logger.Logger(loggerFilename);
			BaseDAL.Base.Connection.dataSources.Add (Common.Enum.EDatabase.GasStation.ToString (), cm);
		}
	}
}
