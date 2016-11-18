using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GasStation
{
    static class __Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			prepare ();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GasStation.Forms.Base.CarFuelForm());
            //Application.Run(new GasStation.Forms.Base.CarColorEntryForm());
        }

		/// <summary>
		/// Prepare
		/// </summary>
		private static void prepare ()
		{
			// TODO: For Test, CLEAR AFTER CREATE LOGIN PAGE
			Common.GlobalData.UserManager.currentUser	= new Common.BLL.Entity.GasStation.User ()
			{
				id			= 1,
				name		= "Ali",
				lastname	= "Hasani",
				username	= "Ali.H",
				password	= "123"
			};

			Common.Initializer.init ();
		}
    }
}
