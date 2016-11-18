using System;
using System.Data;
using BaseDAL.Model;

namespace Common.BLL.Entity.GasStation
{
	[Serializable]
	public class User : BaseBLL.Entity.BaseByViewId
	{

		//[BaseBLL.Base.Field(nullable = false, sqlDBType = System.Data.SqlDbType.Int, primary = false, usage = BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create)]
		//public System.Int32 id
		//{
		//	get;
		//	set;
		//}
//
	// Genereted Property of Base__CarColor
	//
	#region Relation - Base__CarColor (Has-Many relation)
		private System.Data.DataTable _get_Base__CarColor_insertedBy;
		public System.Data.DataTable getBase__CarColor_insertedBy
		{
			get
			{
				if ((_get_Base__CarColor_insertedBy == null) && (AutoLoadForeignKeys))
					loadBase__CarColor_insertedBy ();

				return _get_Base__CarColor_insertedBy;
			}
			set
			{
				_get_Base__CarColor_insertedBy	= value;
			}
		}

		public void loadBase__CarColor_insertedBy (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__CarColor	logic	= new BLL.Logic.GasStation.Base__CarColor (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("insertedBy = @insertedBy", "", false, true, new KeyValuePair ("@insertedBy", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "insertedBy = @insertedBy", "", false, true, new KeyValuePair ("@insertedBy", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__CarColor_insertedBy	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Base__CarColor
	//
	#region Relation - Base__CarColor (Has-Many relation)
		private System.Data.DataTable _get_Base__CarColor_updatedBy;
		public System.Data.DataTable getBase__CarColor_updatedBy
		{
			get
			{
				if ((_get_Base__CarColor_updatedBy == null) && (AutoLoadForeignKeys))
					loadBase__CarColor_updatedBy ();

				return _get_Base__CarColor_updatedBy;
			}
			set
			{
				_get_Base__CarColor_updatedBy	= value;
			}
		}

		public void loadBase__CarColor_updatedBy (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__CarColor	logic	= new BLL.Logic.GasStation.Base__CarColor (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("updatedBy = @updatedBy", "", false, true, new KeyValuePair ("@updatedBy", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "updatedBy = @updatedBy", "", false, true, new KeyValuePair ("@updatedBy", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__CarColor_updatedBy	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Base__CarType
	//
	#region Relation - Base__CarType (Has-Many relation)
		private System.Data.DataTable _get_Base__CarType_insertedBy;
		public System.Data.DataTable getBase__CarType_insertedBy
		{
			get
			{
				if ((_get_Base__CarType_insertedBy == null) && (AutoLoadForeignKeys))
					loadBase__CarType_insertedBy ();

				return _get_Base__CarType_insertedBy;
			}
			set
			{
				_get_Base__CarType_insertedBy	= value;
			}
		}

		public void loadBase__CarType_insertedBy (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__CarType	logic	= new BLL.Logic.GasStation.Base__CarType (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("insertedBy = @insertedBy", "", false, true, new KeyValuePair ("@insertedBy", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "insertedBy = @insertedBy", "", false, true, new KeyValuePair ("@insertedBy", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__CarType_insertedBy	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Base__CarType
	//
	#region Relation - Base__CarType (Has-Many relation)
		private System.Data.DataTable _get_Base__CarType_updatedBy;
		public System.Data.DataTable getBase__CarType_updatedBy
		{
			get
			{
				if ((_get_Base__CarType_updatedBy == null) && (AutoLoadForeignKeys))
					loadBase__CarType_updatedBy ();

				return _get_Base__CarType_updatedBy;
			}
			set
			{
				_get_Base__CarType_updatedBy	= value;
			}
		}

		public void loadBase__CarType_updatedBy (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__CarType	logic	= new BLL.Logic.GasStation.Base__CarType (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("updatedBy = @updatedBy", "", false, true, new KeyValuePair ("@updatedBy", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "updatedBy = @updatedBy", "", false, true, new KeyValuePair ("@updatedBy", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__CarType_updatedBy	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Base__OwnerType
	//
	#region Relation - Base__OwnerType (Has-Many relation)
		private System.Data.DataTable _get_Base__OwnerType_insertedBy;
		public System.Data.DataTable getBase__OwnerType_insertedBy
		{
			get
			{
				if ((_get_Base__OwnerType_insertedBy == null) && (AutoLoadForeignKeys))
					loadBase__OwnerType_insertedBy ();

				return _get_Base__OwnerType_insertedBy;
			}
			set
			{
				_get_Base__OwnerType_insertedBy	= value;
			}
		}

		public void loadBase__OwnerType_insertedBy (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__OwnerType	logic	= new BLL.Logic.GasStation.Base__OwnerType (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("insertedBy = @insertedBy", "", false, true, new KeyValuePair ("@insertedBy", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "insertedBy = @insertedBy", "", false, true, new KeyValuePair ("@insertedBy", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__OwnerType_insertedBy	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Base__OwnerType
	//
	#region Relation - Base__OwnerType (Has-Many relation)
		private System.Data.DataTable _get_Base__OwnerType_updatedBy;
		public System.Data.DataTable getBase__OwnerType_updatedBy
		{
			get
			{
				if ((_get_Base__OwnerType_updatedBy == null) && (AutoLoadForeignKeys))
					loadBase__OwnerType_updatedBy ();

				return _get_Base__OwnerType_updatedBy;
			}
			set
			{
				_get_Base__OwnerType_updatedBy	= value;
			}
		}

		public void loadBase__OwnerType_updatedBy (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__OwnerType	logic	= new BLL.Logic.GasStation.Base__OwnerType (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("updatedBy = @updatedBy", "", false, true, new KeyValuePair ("@updatedBy", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "updatedBy = @updatedBy", "", false, true, new KeyValuePair ("@updatedBy", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__OwnerType_updatedBy	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Base__PlateCity
	//
	#region Relation - Base__PlateCity (Has-Many relation)
		private System.Data.DataTable _get_Base__PlateCity_insertedBy;
		public System.Data.DataTable getBase__PlateCity_insertedBy
		{
			get
			{
				if ((_get_Base__PlateCity_insertedBy == null) && (AutoLoadForeignKeys))
					loadBase__PlateCity_insertedBy ();

				return _get_Base__PlateCity_insertedBy;
			}
			set
			{
				_get_Base__PlateCity_insertedBy	= value;
			}
		}

		public void loadBase__PlateCity_insertedBy (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__PlateCity	logic	= new BLL.Logic.GasStation.Base__PlateCity (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("insertedBy = @insertedBy", "", false, true, new KeyValuePair ("@insertedBy", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "insertedBy = @insertedBy", "", false, true, new KeyValuePair ("@insertedBy", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__PlateCity_insertedBy	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Base__PlateCity
	//
	#region Relation - Base__PlateCity (Has-Many relation)
		private System.Data.DataTable _get_Base__PlateCity_updatedBy;
		public System.Data.DataTable getBase__PlateCity_updatedBy
		{
			get
			{
				if ((_get_Base__PlateCity_updatedBy == null) && (AutoLoadForeignKeys))
					loadBase__PlateCity_updatedBy ();

				return _get_Base__PlateCity_updatedBy;
			}
			set
			{
				_get_Base__PlateCity_updatedBy	= value;
			}
		}

		public void loadBase__PlateCity_updatedBy (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__PlateCity	logic	= new BLL.Logic.GasStation.Base__PlateCity (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("updatedBy = @updatedBy", "", false, true, new KeyValuePair ("@updatedBy", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "updatedBy = @updatedBy", "", false, true, new KeyValuePair ("@updatedBy", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__PlateCity_updatedBy	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Base__PlateCountry
	//
	#region Relation - Base__PlateCountry (Has-Many relation)
		private System.Data.DataTable _get_Base__PlateCountry_insertedBy;
		public System.Data.DataTable getBase__PlateCountry_insertedBy
		{
			get
			{
				if ((_get_Base__PlateCountry_insertedBy == null) && (AutoLoadForeignKeys))
					loadBase__PlateCountry_insertedBy ();

				return _get_Base__PlateCountry_insertedBy;
			}
			set
			{
				_get_Base__PlateCountry_insertedBy	= value;
			}
		}

		public void loadBase__PlateCountry_insertedBy (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__PlateCountry	logic	= new BLL.Logic.GasStation.Base__PlateCountry (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("insertedBy = @insertedBy", "", false, true, new KeyValuePair ("@insertedBy", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "insertedBy = @insertedBy", "", false, true, new KeyValuePair ("@insertedBy", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__PlateCountry_insertedBy	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Base__PlateCountry
	//
	#region Relation - Base__PlateCountry (Has-Many relation)
		private System.Data.DataTable _get_Base__PlateCountry_updatedBy;
		public System.Data.DataTable getBase__PlateCountry_updatedBy
		{
			get
			{
				if ((_get_Base__PlateCountry_updatedBy == null) && (AutoLoadForeignKeys))
					loadBase__PlateCountry_updatedBy ();

				return _get_Base__PlateCountry_updatedBy;
			}
			set
			{
				_get_Base__PlateCountry_updatedBy	= value;
			}
		}

		public void loadBase__PlateCountry_updatedBy (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__PlateCountry	logic	= new BLL.Logic.GasStation.Base__PlateCountry (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("updatedBy = @updatedBy", "", false, true, new KeyValuePair ("@updatedBy", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "updatedBy = @updatedBy", "", false, true, new KeyValuePair ("@updatedBy", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__PlateCountry_updatedBy	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Base__PlateLetter
	//
	#region Relation - Base__PlateLetter (Has-Many relation)
		private System.Data.DataTable _get_Base__PlateLetter_insertedBy;
		public System.Data.DataTable getBase__PlateLetter_insertedBy
		{
			get
			{
				if ((_get_Base__PlateLetter_insertedBy == null) && (AutoLoadForeignKeys))
					loadBase__PlateLetter_insertedBy ();

				return _get_Base__PlateLetter_insertedBy;
			}
			set
			{
				_get_Base__PlateLetter_insertedBy	= value;
			}
		}

		public void loadBase__PlateLetter_insertedBy (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__PlateLetter	logic	= new BLL.Logic.GasStation.Base__PlateLetter (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("insertedBy = @insertedBy", "", false, true, new KeyValuePair ("@insertedBy", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "insertedBy = @insertedBy", "", false, true, new KeyValuePair ("@insertedBy", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__PlateLetter_insertedBy	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Base__PlateLetter
	//
	#region Relation - Base__PlateLetter (Has-Many relation)
		private System.Data.DataTable _get_Base__PlateLetter_updatedBy;
		public System.Data.DataTable getBase__PlateLetter_updatedBy
		{
			get
			{
				if ((_get_Base__PlateLetter_updatedBy == null) && (AutoLoadForeignKeys))
					loadBase__PlateLetter_updatedBy ();

				return _get_Base__PlateLetter_updatedBy;
			}
			set
			{
				_get_Base__PlateLetter_updatedBy	= value;
			}
		}

		public void loadBase__PlateLetter_updatedBy (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__PlateLetter	logic	= new BLL.Logic.GasStation.Base__PlateLetter (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("updatedBy = @updatedBy", "", false, true, new KeyValuePair ("@updatedBy", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "updatedBy = @updatedBy", "", false, true, new KeyValuePair ("@updatedBy", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__PlateLetter_updatedBy	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Base__PlateType
	//
	#region Relation - Base__PlateType (Has-Many relation)
		private System.Data.DataTable _get_Base__PlateType_insertedBy;
		public System.Data.DataTable getBase__PlateType_insertedBy
		{
			get
			{
				if ((_get_Base__PlateType_insertedBy == null) && (AutoLoadForeignKeys))
					loadBase__PlateType_insertedBy ();

				return _get_Base__PlateType_insertedBy;
			}
			set
			{
				_get_Base__PlateType_insertedBy	= value;
			}
		}

		public void loadBase__PlateType_insertedBy (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__PlateType	logic	= new BLL.Logic.GasStation.Base__PlateType (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("insertedBy = @insertedBy", "", false, true, new KeyValuePair ("@insertedBy", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "insertedBy = @insertedBy", "", false, true, new KeyValuePair ("@insertedBy", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__PlateType_insertedBy	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Base__PlateType
	//
	#region Relation - Base__PlateType (Has-Many relation)
		private System.Data.DataTable _get_Base__PlateType_updatedBy;
		public System.Data.DataTable getBase__PlateType_updatedBy
		{
			get
			{
				if ((_get_Base__PlateType_updatedBy == null) && (AutoLoadForeignKeys))
					loadBase__PlateType_updatedBy ();

				return _get_Base__PlateType_updatedBy;
			}
			set
			{
				_get_Base__PlateType_updatedBy	= value;
			}
		}

		public void loadBase__PlateType_updatedBy (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__PlateType	logic	= new BLL.Logic.GasStation.Base__PlateType (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("updatedBy = @updatedBy", "", false, true, new KeyValuePair ("@updatedBy", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "updatedBy = @updatedBy", "", false, true, new KeyValuePair ("@updatedBy", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__PlateType_updatedBy	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of LegalOwner
	//
	#region Relation - LegalOwner (Has-Many relation)
		private System.Data.DataTable _get_LegalOwner_insertedBy;
		public System.Data.DataTable getLegalOwner_insertedBy
		{
			get
			{
				if ((_get_LegalOwner_insertedBy == null) && (AutoLoadForeignKeys))
					loadLegalOwner_insertedBy ();

				return _get_LegalOwner_insertedBy;
			}
			set
			{
				_get_LegalOwner_insertedBy	= value;
			}
		}

		public void loadLegalOwner_insertedBy (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.LegalOwner	logic	= new BLL.Logic.GasStation.LegalOwner (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("insertedBy = @insertedBy", "", false, true, new KeyValuePair ("@insertedBy", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "insertedBy = @insertedBy", "", false, true, new KeyValuePair ("@insertedBy", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_LegalOwner_insertedBy	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of LegalOwner
	//
	#region Relation - LegalOwner (Has-Many relation)
		private System.Data.DataTable _get_LegalOwner_updatedBy;
		public System.Data.DataTable getLegalOwner_updatedBy
		{
			get
			{
				if ((_get_LegalOwner_updatedBy == null) && (AutoLoadForeignKeys))
					loadLegalOwner_updatedBy ();

				return _get_LegalOwner_updatedBy;
			}
			set
			{
				_get_LegalOwner_updatedBy	= value;
			}
		}

		public void loadLegalOwner_updatedBy (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.LegalOwner	logic	= new BLL.Logic.GasStation.LegalOwner (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("updatedBy = @updatedBy", "", false, true, new KeyValuePair ("@updatedBy", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "updatedBy = @updatedBy", "", false, true, new KeyValuePair ("@updatedBy", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_LegalOwner_updatedBy	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Owner
	//
	#region Relation - Owner (Has-Many relation)
		private System.Data.DataTable _get_Owner_insertedBy;
		public System.Data.DataTable getOwner_insertedBy
		{
			get
			{
				if ((_get_Owner_insertedBy == null) && (AutoLoadForeignKeys))
					loadOwner_insertedBy ();

				return _get_Owner_insertedBy;
			}
			set
			{
				_get_Owner_insertedBy	= value;
			}
		}

		public void loadOwner_insertedBy (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Owner	logic	= new BLL.Logic.GasStation.Owner (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("insertedBy = @insertedBy", "", false, true, new KeyValuePair ("@insertedBy", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "insertedBy = @insertedBy", "", false, true, new KeyValuePair ("@insertedBy", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Owner_insertedBy	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Owner
	//
	#region Relation - Owner (Has-Many relation)
		private System.Data.DataTable _get_Owner_updatedBy;
		public System.Data.DataTable getOwner_updatedBy
		{
			get
			{
				if ((_get_Owner_updatedBy == null) && (AutoLoadForeignKeys))
					loadOwner_updatedBy ();

				return _get_Owner_updatedBy;
			}
			set
			{
				_get_Owner_updatedBy	= value;
			}
		}

		public void loadOwner_updatedBy (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Owner	logic	= new BLL.Logic.GasStation.Owner (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("updatedBy = @updatedBy", "", false, true, new KeyValuePair ("@updatedBy", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "updatedBy = @updatedBy", "", false, true, new KeyValuePair ("@updatedBy", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Owner_updatedBy	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Plate
	//
	#region Relation - Plate (Has-Many relation)
		private System.Data.DataTable _get_Plate_insertedBy;
		public System.Data.DataTable getPlate_insertedBy
		{
			get
			{
				if ((_get_Plate_insertedBy == null) && (AutoLoadForeignKeys))
					loadPlate_insertedBy ();

				return _get_Plate_insertedBy;
			}
			set
			{
				_get_Plate_insertedBy	= value;
			}
		}

		public void loadPlate_insertedBy (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Plate	logic	= new BLL.Logic.GasStation.Plate (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("insertedBy = @insertedBy", "", false, true, new KeyValuePair ("@insertedBy", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "insertedBy = @insertedBy", "", false, true, new KeyValuePair ("@insertedBy", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Plate_insertedBy	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Plate
	//
	#region Relation - Plate (Has-Many relation)
		private System.Data.DataTable _get_Plate_updatedBy;
		public System.Data.DataTable getPlate_updatedBy
		{
			get
			{
				if ((_get_Plate_updatedBy == null) && (AutoLoadForeignKeys))
					loadPlate_updatedBy ();

				return _get_Plate_updatedBy;
			}
			set
			{
				_get_Plate_updatedBy	= value;
			}
		}

		public void loadPlate_updatedBy (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Plate	logic	= new BLL.Logic.GasStation.Plate (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("updatedBy = @updatedBy", "", false, true, new KeyValuePair ("@updatedBy", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "updatedBy = @updatedBy", "", false, true, new KeyValuePair ("@updatedBy", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Plate_updatedBy	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of RealOwner
	//
	#region Relation - RealOwner (Has-Many relation)
		private System.Data.DataTable _get_RealOwner_insertedBy;
		public System.Data.DataTable getRealOwner_insertedBy
		{
			get
			{
				if ((_get_RealOwner_insertedBy == null) && (AutoLoadForeignKeys))
					loadRealOwner_insertedBy ();

				return _get_RealOwner_insertedBy;
			}
			set
			{
				_get_RealOwner_insertedBy	= value;
			}
		}

		public void loadRealOwner_insertedBy (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.RealOwner	logic	= new BLL.Logic.GasStation.RealOwner (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("insertedBy = @insertedBy", "", false, true, new KeyValuePair ("@insertedBy", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "insertedBy = @insertedBy", "", false, true, new KeyValuePair ("@insertedBy", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_RealOwner_insertedBy	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of RealOwner
	//
	#region Relation - RealOwner (Has-Many relation)
		private System.Data.DataTable _get_RealOwner_updatedBy;
		public System.Data.DataTable getRealOwner_updatedBy
		{
			get
			{
				if ((_get_RealOwner_updatedBy == null) && (AutoLoadForeignKeys))
					loadRealOwner_updatedBy ();

				return _get_RealOwner_updatedBy;
			}
			set
			{
				_get_RealOwner_updatedBy	= value;
			}
		}

		public void loadRealOwner_updatedBy (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.RealOwner	logic	= new BLL.Logic.GasStation.RealOwner (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("updatedBy = @updatedBy", "", false, true, new KeyValuePair ("@updatedBy", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "updatedBy = @updatedBy", "", false, true, new KeyValuePair ("@updatedBy", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_RealOwner_updatedBy	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Tag
	//
	#region Relation - Tag (Has-Many relation)
		private System.Data.DataTable _get_Tag_insertedBy;
		public System.Data.DataTable getTag_insertedBy
		{
			get
			{
				if ((_get_Tag_insertedBy == null) && (AutoLoadForeignKeys))
					loadTag_insertedBy ();

				return _get_Tag_insertedBy;
			}
			set
			{
				_get_Tag_insertedBy	= value;
			}
		}

		public void loadTag_insertedBy (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Tag	logic	= new BLL.Logic.GasStation.Tag (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("insertedBy = @insertedBy", "", false, true, new KeyValuePair ("@insertedBy", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "insertedBy = @insertedBy", "", false, true, new KeyValuePair ("@insertedBy", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Tag_insertedBy	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Tag
	//
	#region Relation - Tag (Has-Many relation)
		private System.Data.DataTable _get_Tag_updatedBy;
		public System.Data.DataTable getTag_updatedBy
		{
			get
			{
				if ((_get_Tag_updatedBy == null) && (AutoLoadForeignKeys))
					loadTag_updatedBy ();

				return _get_Tag_updatedBy;
			}
			set
			{
				_get_Tag_updatedBy	= value;
			}
		}

		public void loadTag_updatedBy (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Tag	logic	= new BLL.Logic.GasStation.Tag (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("updatedBy = @updatedBy", "", false, true, new KeyValuePair ("@updatedBy", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "updatedBy = @updatedBy", "", false, true, new KeyValuePair ("@updatedBy", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Tag_updatedBy	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Base__CarFuel
	//
	#region Relation - Base__CarFuel (Has-Many relation)
		private System.Data.DataTable _get_Base__CarFuel_insertedBy;
		public System.Data.DataTable getBase__CarFuel_insertedBy
		{
			get
			{
				if ((_get_Base__CarFuel_insertedBy == null) && (AutoLoadForeignKeys))
					loadBase__CarFuel_insertedBy ();

				return _get_Base__CarFuel_insertedBy;
			}
			set
			{
				_get_Base__CarFuel_insertedBy	= value;
			}
		}

		public void loadBase__CarFuel_insertedBy (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__CarFuel	logic	= new BLL.Logic.GasStation.Base__CarFuel (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("insertedBy = @insertedBy", "", false, true, new KeyValuePair ("@insertedBy", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "insertedBy = @insertedBy", "", false, true, new KeyValuePair ("@insertedBy", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__CarFuel_insertedBy	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Base__CarFuel
	//
	#region Relation - Base__CarFuel (Has-Many relation)
		private System.Data.DataTable _get_Base__CarFuel_updatedBy;
		public System.Data.DataTable getBase__CarFuel_updatedBy
		{
			get
			{
				if ((_get_Base__CarFuel_updatedBy == null) && (AutoLoadForeignKeys))
					loadBase__CarFuel_updatedBy ();

				return _get_Base__CarFuel_updatedBy;
			}
			set
			{
				_get_Base__CarFuel_updatedBy	= value;
			}
		}

		public void loadBase__CarFuel_updatedBy (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__CarFuel	logic	= new BLL.Logic.GasStation.Base__CarFuel (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("updatedBy = @updatedBy", "", false, true, new KeyValuePair ("@updatedBy", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "updatedBy = @updatedBy", "", false, true, new KeyValuePair ("@updatedBy", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__CarFuel_updatedBy	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of UHF
	//
	#region Relation - UHF (Has-Many relation)
		private System.Data.DataTable _get_UHF_insertedBy;
		public System.Data.DataTable getUHF_insertedBy
		{
			get
			{
				if ((_get_UHF_insertedBy == null) && (AutoLoadForeignKeys))
					loadUHF_insertedBy ();

				return _get_UHF_insertedBy;
			}
			set
			{
				_get_UHF_insertedBy	= value;
			}
		}

		public void loadUHF_insertedBy (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.UHF	logic	= new BLL.Logic.GasStation.UHF (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("insertedBy = @insertedBy", "", false, true, new KeyValuePair ("@insertedBy", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "insertedBy = @insertedBy", "", false, true, new KeyValuePair ("@insertedBy", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_UHF_insertedBy	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of UHF
	//
	#region Relation - UHF (Has-Many relation)
		private System.Data.DataTable _get_UHF_updatedBy;
		public System.Data.DataTable getUHF_updatedBy
		{
			get
			{
				if ((_get_UHF_updatedBy == null) && (AutoLoadForeignKeys))
					loadUHF_updatedBy ();

				return _get_UHF_updatedBy;
			}
			set
			{
				_get_UHF_updatedBy	= value;
			}
		}

		public void loadUHF_updatedBy (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.UHF	logic	= new BLL.Logic.GasStation.UHF (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("updatedBy = @updatedBy", "", false, true, new KeyValuePair ("@updatedBy", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "updatedBy = @updatedBy", "", false, true, new KeyValuePair ("@updatedBy", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_UHF_updatedBy	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Base__CarLevel
	//
	#region Relation - Base__CarLevel (Has-Many relation)
		private System.Data.DataTable _get_Base__CarLevel_insertedBy;
		public System.Data.DataTable getBase__CarLevel_insertedBy
		{
			get
			{
				if ((_get_Base__CarLevel_insertedBy == null) && (AutoLoadForeignKeys))
					loadBase__CarLevel_insertedBy ();

				return _get_Base__CarLevel_insertedBy;
			}
			set
			{
				_get_Base__CarLevel_insertedBy	= value;
			}
		}

		public void loadBase__CarLevel_insertedBy (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__CarLevel	logic	= new BLL.Logic.GasStation.Base__CarLevel (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("insertedBy = @insertedBy", "", false, true, new KeyValuePair ("@insertedBy", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "insertedBy = @insertedBy", "", false, true, new KeyValuePair ("@insertedBy", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__CarLevel_insertedBy	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Base__CarLevel
	//
	#region Relation - Base__CarLevel (Has-Many relation)
		private System.Data.DataTable _get_Base__CarLevel_updatedBy;
		public System.Data.DataTable getBase__CarLevel_updatedBy
		{
			get
			{
				if ((_get_Base__CarLevel_updatedBy == null) && (AutoLoadForeignKeys))
					loadBase__CarLevel_updatedBy ();

				return _get_Base__CarLevel_updatedBy;
			}
			set
			{
				_get_Base__CarLevel_updatedBy	= value;
			}
		}

		public void loadBase__CarLevel_updatedBy (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__CarLevel	logic	= new BLL.Logic.GasStation.Base__CarLevel (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("updatedBy = @updatedBy", "", false, true, new KeyValuePair ("@updatedBy", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "updatedBy = @updatedBy", "", false, true, new KeyValuePair ("@updatedBy", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__CarLevel_updatedBy	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Car
	//
	#region Relation - Car (Has-Many relation)
		private System.Data.DataTable _get_Car_insertedBy;
		public System.Data.DataTable getCar_insertedBy
		{
			get
			{
				if ((_get_Car_insertedBy == null) && (AutoLoadForeignKeys))
					loadCar_insertedBy ();

				return _get_Car_insertedBy;
			}
			set
			{
				_get_Car_insertedBy	= value;
			}
		}

		public void loadCar_insertedBy (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Car	logic	= new BLL.Logic.GasStation.Car (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("insertedBy = @insertedBy", "", false, true, new KeyValuePair ("@insertedBy", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "insertedBy = @insertedBy", "", false, true, new KeyValuePair ("@insertedBy", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Car_insertedBy	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Car
	//
	#region Relation - Car (Has-Many relation)
		private System.Data.DataTable _get_Car_updatedBy;
		public System.Data.DataTable getCar_updatedBy
		{
			get
			{
				if ((_get_Car_updatedBy == null) && (AutoLoadForeignKeys))
					loadCar_updatedBy ();

				return _get_Car_updatedBy;
			}
			set
			{
				_get_Car_updatedBy	= value;
			}
		}

		public void loadCar_updatedBy (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Car	logic	= new BLL.Logic.GasStation.Car (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("updatedBy = @updatedBy", "", false, true, new KeyValuePair ("@updatedBy", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "updatedBy = @updatedBy", "", false, true, new KeyValuePair ("@updatedBy", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Car_updatedBy	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Base__CarModel
	//
	#region Relation - Base__CarModel (Has-Many relation)
		private System.Data.DataTable _get_Base__CarModel_insertedBy;
		public System.Data.DataTable getBase__CarModel_insertedBy
		{
			get
			{
				if ((_get_Base__CarModel_insertedBy == null) && (AutoLoadForeignKeys))
					loadBase__CarModel_insertedBy ();

				return _get_Base__CarModel_insertedBy;
			}
			set
			{
				_get_Base__CarModel_insertedBy	= value;
			}
		}

		public void loadBase__CarModel_insertedBy (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__CarModel	logic	= new BLL.Logic.GasStation.Base__CarModel (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("insertedBy = @insertedBy", "", false, true, new KeyValuePair ("@insertedBy", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "insertedBy = @insertedBy", "", false, true, new KeyValuePair ("@insertedBy", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__CarModel_insertedBy	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Base__CarModel
	//
	#region Relation - Base__CarModel (Has-Many relation)
		private System.Data.DataTable _get_Base__CarModel_updatedBy;
		public System.Data.DataTable getBase__CarModel_updatedBy
		{
			get
			{
				if ((_get_Base__CarModel_updatedBy == null) && (AutoLoadForeignKeys))
					loadBase__CarModel_updatedBy ();

				return _get_Base__CarModel_updatedBy;
			}
			set
			{
				_get_Base__CarModel_updatedBy	= value;
			}
		}

		public void loadBase__CarModel_updatedBy (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__CarModel	logic	= new BLL.Logic.GasStation.Base__CarModel (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("updatedBy = @updatedBy", "", false, true, new KeyValuePair ("@updatedBy", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "updatedBy = @updatedBy", "", false, true, new KeyValuePair ("@updatedBy", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__CarModel_updatedBy	= opResult.model as System.Data.DataTable;
		}
	#endregion

		//[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.UniqueIdentifier,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create)]
		//public System.Guid viewId
		//{
		//	get;
		//	set;
		//}

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.VarChar,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,size=50)]
		public System.String name
		{
			get;
			set;
		}

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.VarChar,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,size=50)]
		public System.String lastname
		{
			get;
			set;
		}

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.VarChar,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,size=50)]
		public System.String username
		{
			get;
			set;
		}

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.VarChar,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,size=50)]
		public System.String password
		{
			get;
			set;
		}

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Date,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create)]
		public System.DateTime createdate
		{
			get;
			set;
		}
	}
}