using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GasStation
{
    static class __Program
    {
		public static int hasLogin;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			prepare ();
		
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

			while (hasLogin != 2)
			{
				Application.Run (new Forms.User.LoginForm ());

				if (hasLogin == 1)
					Application.Run (new Forms.Forms.MainForm ());				
			}
        }

		/// <summary>
		/// Prepare
		/// </summary>
		private static void prepare ()
		{
			// Prepare
			__Program.hasLogin	= 0;

			// Initilization
			Common.Initializer.init (Path.Combine (Application.StartupPath, "log.txt"));

			Common.BLL.Entity.GasStation.User	user	= new Common.BLL.Entity.GasStation.User ();
			Common.BLL.Logic.GasStation.User	luser	= new Common.BLL.Logic.GasStation.User (Common.Enum.EDatabase.GasStation);

			///FOR TEST
			//user.id	= 3;
			//BaseDAL.Model.CommandResult opResult =  luser.deleteUser (user);

			//Helper.GridHeaderMaker.makeHeaderCarFuel();
			//Helper.GridHeaderMaker.makeHeaderCarLevel();
			//Helper.GridHeaderMaker.makeHeaderCarSystem();
			//Helper.GridHeaderMaker.makeHeaderPlateType();
		}
    }
}
