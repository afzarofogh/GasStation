using BaseDAL.Model;
using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GasStation.Helper
{
	/// <summary>
	/// Grid header maker class
	/// </summary>
	class GridHeaderMaker
	{
		#region Methods
		/// <summary>
		/// Make header CarTypeForm
		/// </summary>
		public static CommandResult makeHeaderCarType ()
		{
			CommandResult				result;
			GridColumnCollectionModel	gridCols	= new GridColumnCollectionModel ();

			// Add fields
			gridCols.columns.AddRange (new GridColumnModel[]
				{
					new GridColumnModel ("id",              "id",           false, true, 0),
					new GridColumnModel ("viewId",          "viewId",       false, true, 0),
					new GridColumnModel ("insertedById",    "viewId",       false, true, 0),
					new GridColumnModel ("insertDate",      "viewId",       false, true, 0),
					new GridColumnModel ("updatedById",     "viewId",       false, true, 0),
					new GridColumnModel ("updateDate",      "viewId",       false, true, 0),
					new GridColumnModel ("type",            "نوع خودرو",    true, true, 1),
				});

			// Save to db
			result  = gridCols.saveToDB ("CarTypeForm");

			return result;
		} 

		/// <summary>
		/// Make header Plate City
		/// </summary>
		public static CommandResult makeHeaderPlateCity ()
		{
			CommandResult				result;
			GridColumnCollectionModel	gridCols	= new GridColumnCollectionModel ();

			// Add fields
			gridCols.columns.AddRange (new GridColumnModel[]
				{
					new GridColumnModel ("id",              "id",           false, true, 0),
					new GridColumnModel ("viewId",          "viewId",       false, true, 0),
					new GridColumnModel ("insertedById",    "viewId",       false, true, 0),
					new GridColumnModel ("insertDate",      "viewId",       false, true, 0),
					new GridColumnModel ("updatedById",     "viewId",       false, true, 0),
					new GridColumnModel ("updateDate",      "viewId",       false, true, 0),
					new GridColumnModel ("city",            "شهر",			true, true, 1),
				});

			// Save to db
			result  = gridCols.saveToDB ("PlateCityForm");

			return result;
		}
		#endregion
	}
}
