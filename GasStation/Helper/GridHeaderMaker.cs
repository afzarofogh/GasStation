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
					new GridColumnModel ("id",              "id",				false, true, 0, 150),
					new GridColumnModel ("viewId",          "viewId",			false, true, 0, 150),
					new GridColumnModel ("insertedById",    "insertedById",     false, true, 0, 150),
					new GridColumnModel ("insertDate",      "insertDate",       false, true, 0, 150),
					new GridColumnModel ("updatedById",     "updatedById",      false, true, 0, 150),
					new GridColumnModel ("updateDate",      "updateDate",       false, true, 0, 150),
					new GridColumnModel ("type",            "نوع خودرو",		true, true, 1, 150),
				});

			// Save to db
			result  = gridCols.saveToDB ("CarTypeForm");

			return result;
		} 
		
		/// <summary>
		/// Make header Car Color Form
		/// </summary>
		public static CommandResult makeHeaderCarColor ()
		{
			CommandResult				result;
			GridColumnCollectionModel	gridCols	= new GridColumnCollectionModel ();

			// Add fields
			gridCols.columns.AddRange (new GridColumnModel[]
				{
					new GridColumnModel ("id",              "id",				false, true, 0, 150),
					new GridColumnModel ("viewId",          "viewId",			false, true, 0, 150),
					new GridColumnModel ("insertedById",    "insertedById",     false, true, 0, 150),
					new GridColumnModel ("insertDate",      "insertDate",       false, true, 0, 150),
					new GridColumnModel ("updatedById",     "updatedById",      false, true, 0, 150),
					new GridColumnModel ("updateDate",      "updateDate",       false, true, 0, 150),
					new GridColumnModel ("color",            "رنگ",				true, true, 1, 150),
				});

			// Save to db
			result  = gridCols.saveToDB ("CarColorForm");

			return result;
		} 

		/// <summary>
		/// Make header Car Fuel Form
		/// </summary>
		public static CommandResult makeHeaderCarFuel ()
		{
			CommandResult				result;
			GridColumnCollectionModel	gridCols	= new GridColumnCollectionModel ();

			// Add fields
			gridCols.columns.AddRange (new GridColumnModel[]
				{
					new GridColumnModel ("id",              "id",				false, true, 0, 150),
					new GridColumnModel ("viewId",          "viewId",			false, true, 0, 150),
					new GridColumnModel ("insertedById",    "insertedById",     false, true, 0, 150),
					new GridColumnModel ("insertDate",      "insertDate",       false, true, 0, 150),
					new GridColumnModel ("updatedById",     "updatedById",      false, true, 0, 150),
					new GridColumnModel ("updateDate",      "updateDate",       false, true, 0, 150),
					new GridColumnModel ("fuel",            "سوخت",				true, true, 1, 150),
				});

			// Save to db
			result  = gridCols.saveToDB ("CarFuelForm");

			return result;
		} 

		/// <summary>
		/// Make header Car Level Form
		/// </summary>
		public static CommandResult makeHeaderCarLevel ()
		{
			CommandResult				result;
			GridColumnCollectionModel	gridCols	= new GridColumnCollectionModel ();

			// Add fields
			gridCols.columns.AddRange (new GridColumnModel[]
				{
					new GridColumnModel ("id",              "id",				false, true, 0, 150),
					new GridColumnModel ("viewId",          "viewId",			false, true, 0, 150),
					new GridColumnModel ("insertedById",    "insertedById",     false, true, 0, 150),
					new GridColumnModel ("insertDate",      "insertDate",       false, true, 0, 150),
					new GridColumnModel ("updatedById",     "updatedById",      false, true, 0, 150),
					new GridColumnModel ("updateDate",      "updateDate",       false, true, 0, 150),
					new GridColumnModel ("levelcar",            "تیپ",			true, true, 1, 150),
				});

			// Save to db
			result  = gridCols.saveToDB ("CarLevelForm");

			return result;
		} 

		/// <summary>
		/// Make header Car System Form
		/// </summary>
		public static CommandResult makeHeaderCarSystem ()
		{
			CommandResult				result;
			GridColumnCollectionModel	gridCols	= new GridColumnCollectionModel ();

			// Add fields
			gridCols.columns.AddRange (new GridColumnModel[]
				{
					new GridColumnModel ("id",              "id",				 false, true, 0, 150),
					new GridColumnModel ("viewId",          "viewId",			 false, true, 0, 150),
					new GridColumnModel ("insertedById",    "insertedById",      false, true, 0, 150),
					new GridColumnModel ("insertDate",      "insertDate",		 false, true, 0, 150),
					new GridColumnModel ("updatedById",     "updatedById",       false, true, 0, 150),
					new GridColumnModel ("updateDate",      "updateDate",		 false, true, 0, 150),
					new GridColumnModel ("system",          "سیستم خودرو",		 true, true, 1, 150),
				});

			// Save to db
			result  = gridCols.saveToDB ("CarSystemForm");

			return result;
		} 

		/// <summary>
		/// Make header Plate Type Form
		/// </summary>
		public static CommandResult makeHeaderPlateType ()
		{
			CommandResult				result;
			GridColumnCollectionModel	gridCols	= new GridColumnCollectionModel ();

			// Add fields
			gridCols.columns.AddRange (new GridColumnModel[]
				{
					new GridColumnModel ("id",              "id",				false, true, 0, 150),
					new GridColumnModel ("viewId",          "viewId",			false, true, 0, 150),
					new GridColumnModel ("insertedById",    "insertedById",     false, true, 0, 150),
					new GridColumnModel ("insertDate",      "insertDate",       false, true, 0, 150),
					new GridColumnModel ("updatedById",     "updatedById",      false, true, 0, 150),
					new GridColumnModel ("updateDate",      "updateDate",       false, true, 0, 150),
					new GridColumnModel ("type",            "نوع پلاک",			true, true, 1, 150),
				});

			// Save to db
			result  = gridCols.saveToDB ("PlateTypeForm");

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
					new GridColumnModel ("id",              "id",           false, true, 0, 150),
					new GridColumnModel ("viewId",          "viewId",       false, true, 0, 150),
					new GridColumnModel ("insertedById",    "insertedById", false, true, 0, 150),
					new GridColumnModel ("insertDate",      "insertDate",	false, true, 0, 150),
					new GridColumnModel ("updatedById",     "updatedById",	false, true, 0, 150),
					new GridColumnModel ("updateDate",      "updateDate",	false, true, 0, 150),
					new GridColumnModel ("city",            "شهر",			true, true, 1, 150),
					new GridColumnModel ("code",            "کد استان",		true, true, 1, 150),
				});

			// Save to db
			result  = gridCols.saveToDB ("PlateCityForm");

			return result;
		}

		/// <summary>
		/// Make header Customer View Form
		/// </summary>
		public static CommandResult makeHeaderOwner ()
		{
			CommandResult				result;
			GridColumnCollectionModel	gridCols	= new GridColumnCollectionModel ();

			// Add fields
			gridCols.columns.AddRange (new GridColumnModel[]
				{
					new GridColumnModel ("id",              "id",				false, true, 0, 150),
					new GridColumnModel ("viewId",          "viewId",			false, true, 0, 150),
					new GridColumnModel ("idCar",			"idCar",			false, true, 0, 150),
					new GridColumnModel ("nationalCode",    "کد ملی",			true, true, 1, 150),
					new GridColumnModel ("name",            "نام",				true, true, 2, 150),
					new GridColumnModel ("lastname",        "نام خانوادگی",	true, true, 3, 150),
					new GridColumnModel ("mobile",	        "موبایل",			true, true, 4, 150),
					new GridColumnModel ("plate",           "شماره پلاک",		true, true, 5, 150),
					new GridColumnModel ("type",			"نوع پلاک",			true, true, 6, 150),
					new GridColumnModel ("city",			"شهر پلاک",			true, true, 7, 150),
					new GridColumnModel ("typeCar",			"نوع خودرو",		true, true, 8, 150),
					new GridColumnModel ("system",	        "سیستم خودرو",		true, true, 9, 150),
					new GridColumnModel ("color",	        "رنگ خودرو",		true, true, 10, 150),
					new GridColumnModel ("levelcar",	    "تیپ خودرو",		true, true, 11, 150),
					new GridColumnModel ("model",	        "مدل خودرو",		true, true, 12, 150)			
					

				});

			// Save to db
			result  = gridCols.saveToDB ("CustomerViewForm");

			return result;
		}
		
		#endregion
	}
}
