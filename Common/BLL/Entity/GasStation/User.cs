using System;
using System.Data;
using BaseDAL.Model;

namespace Common.BLL.Entity.GasStation
{
	[Serializable]
	public class User : BaseBLL.Entity.BaseByViewId
	{

	//
	// Genereted Property of Base__CarColor
	//
	#region Relation - Base__CarColor (Has-Many relation)
		private System.Data.DataTable _get_Base__CarColor_insertedById;
		public System.Data.DataTable getBase__CarColor_insertedById
		{
			get
			{
				if ((_get_Base__CarColor_insertedById == null) && (AutoLoadForeignKeys))
					loadBase__CarColor_insertedById ();

				return _get_Base__CarColor_insertedById;
			}
			set
			{
				_get_Base__CarColor_insertedById	= value;
			}
		}

		public void loadBase__CarColor_insertedById (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__CarColor	logic	= new BLL.Logic.GasStation.Base__CarColor (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("insertedById = @insertedById", "", false, true, new KeyValuePair ("@insertedById", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "insertedById = @insertedById", "", false, true, new KeyValuePair ("@insertedById", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__CarColor_insertedById	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Base__CarColor
	//
	#region Relation - Base__CarColor (Has-Many relation)
		private System.Data.DataTable _get_Base__CarColor_updatedById;
		public System.Data.DataTable getBase__CarColor_updatedById
		{
			get
			{
				if ((_get_Base__CarColor_updatedById == null) && (AutoLoadForeignKeys))
					loadBase__CarColor_updatedById ();

				return _get_Base__CarColor_updatedById;
			}
			set
			{
				_get_Base__CarColor_updatedById	= value;
			}
		}

		public void loadBase__CarColor_updatedById (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__CarColor	logic	= new BLL.Logic.GasStation.Base__CarColor (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("updatedById = @updatedById", "", false, true, new KeyValuePair ("@updatedById", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "updatedById = @updatedById", "", false, true, new KeyValuePair ("@updatedById", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__CarColor_updatedById	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Base__CarType
	//
	#region Relation - Base__CarType (Has-Many relation)
		private System.Data.DataTable _get_Base__CarType_insertedById;
		public System.Data.DataTable getBase__CarType_insertedById
		{
			get
			{
				if ((_get_Base__CarType_insertedById == null) && (AutoLoadForeignKeys))
					loadBase__CarType_insertedById ();

				return _get_Base__CarType_insertedById;
			}
			set
			{
				_get_Base__CarType_insertedById	= value;
			}
		}

		public void loadBase__CarType_insertedById (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__CarType	logic	= new BLL.Logic.GasStation.Base__CarType (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("insertedById = @insertedById", "", false, true, new KeyValuePair ("@insertedById", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "insertedById = @insertedById", "", false, true, new KeyValuePair ("@insertedById", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__CarType_insertedById	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Base__CarType
	//
	#region Relation - Base__CarType (Has-Many relation)
		private System.Data.DataTable _get_Base__CarType_updatedById;
		public System.Data.DataTable getBase__CarType_updatedById
		{
			get
			{
				if ((_get_Base__CarType_updatedById == null) && (AutoLoadForeignKeys))
					loadBase__CarType_updatedById ();

				return _get_Base__CarType_updatedById;
			}
			set
			{
				_get_Base__CarType_updatedById	= value;
			}
		}

		public void loadBase__CarType_updatedById (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__CarType	logic	= new BLL.Logic.GasStation.Base__CarType (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("updatedById = @updatedById", "", false, true, new KeyValuePair ("@updatedById", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "updatedById = @updatedById", "", false, true, new KeyValuePair ("@updatedById", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__CarType_updatedById	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Base__OwnerType
	//
	#region Relation - Base__OwnerType (Has-Many relation)
		private System.Data.DataTable _get_Base__OwnerType_insertedById;
		public System.Data.DataTable getBase__OwnerType_insertedById
		{
			get
			{
				if ((_get_Base__OwnerType_insertedById == null) && (AutoLoadForeignKeys))
					loadBase__OwnerType_insertedById ();

				return _get_Base__OwnerType_insertedById;
			}
			set
			{
				_get_Base__OwnerType_insertedById	= value;
			}
		}

		public void loadBase__OwnerType_insertedById (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__OwnerType	logic	= new BLL.Logic.GasStation.Base__OwnerType (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("insertedById = @insertedById", "", false, true, new KeyValuePair ("@insertedById", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "insertedById = @insertedById", "", false, true, new KeyValuePair ("@insertedById", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__OwnerType_insertedById	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Base__OwnerType
	//
	#region Relation - Base__OwnerType (Has-Many relation)
		private System.Data.DataTable _get_Base__OwnerType_updatedById;
		public System.Data.DataTable getBase__OwnerType_updatedById
		{
			get
			{
				if ((_get_Base__OwnerType_updatedById == null) && (AutoLoadForeignKeys))
					loadBase__OwnerType_updatedById ();

				return _get_Base__OwnerType_updatedById;
			}
			set
			{
				_get_Base__OwnerType_updatedById	= value;
			}
		}

		public void loadBase__OwnerType_updatedById (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__OwnerType	logic	= new BLL.Logic.GasStation.Base__OwnerType (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("updatedById = @updatedById", "", false, true, new KeyValuePair ("@updatedById", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "updatedById = @updatedById", "", false, true, new KeyValuePair ("@updatedById", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__OwnerType_updatedById	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Base__PlateCity
	//
	#region Relation - Base__PlateCity (Has-Many relation)
		private System.Data.DataTable _get_Base__PlateCity_insertedById;
		public System.Data.DataTable getBase__PlateCity_insertedById
		{
			get
			{
				if ((_get_Base__PlateCity_insertedById == null) && (AutoLoadForeignKeys))
					loadBase__PlateCity_insertedById ();

				return _get_Base__PlateCity_insertedById;
			}
			set
			{
				_get_Base__PlateCity_insertedById	= value;
			}
		}

		public void loadBase__PlateCity_insertedById (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__PlateCity	logic	= new BLL.Logic.GasStation.Base__PlateCity (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("insertedById = @insertedById", "", false, true, new KeyValuePair ("@insertedById", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "insertedById = @insertedById", "", false, true, new KeyValuePair ("@insertedById", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__PlateCity_insertedById	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Base__PlateCity
	//
	#region Relation - Base__PlateCity (Has-Many relation)
		private System.Data.DataTable _get_Base__PlateCity_updatedById;
		public System.Data.DataTable getBase__PlateCity_updatedById
		{
			get
			{
				if ((_get_Base__PlateCity_updatedById == null) && (AutoLoadForeignKeys))
					loadBase__PlateCity_updatedById ();

				return _get_Base__PlateCity_updatedById;
			}
			set
			{
				_get_Base__PlateCity_updatedById	= value;
			}
		}

		public void loadBase__PlateCity_updatedById (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__PlateCity	logic	= new BLL.Logic.GasStation.Base__PlateCity (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("updatedById = @updatedById", "", false, true, new KeyValuePair ("@updatedById", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "updatedById = @updatedById", "", false, true, new KeyValuePair ("@updatedById", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__PlateCity_updatedById	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Base__PlateCountry
	//
	#region Relation - Base__PlateCountry (Has-Many relation)
		private System.Data.DataTable _get_Base__PlateCountry_insertedById;
		public System.Data.DataTable getBase__PlateCountry_insertedById
		{
			get
			{
				if ((_get_Base__PlateCountry_insertedById == null) && (AutoLoadForeignKeys))
					loadBase__PlateCountry_insertedById ();

				return _get_Base__PlateCountry_insertedById;
			}
			set
			{
				_get_Base__PlateCountry_insertedById	= value;
			}
		}

		public void loadBase__PlateCountry_insertedById (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__PlateCountry	logic	= new BLL.Logic.GasStation.Base__PlateCountry (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("insertedById = @insertedById", "", false, true, new KeyValuePair ("@insertedById", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "insertedById = @insertedById", "", false, true, new KeyValuePair ("@insertedById", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__PlateCountry_insertedById	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Base__PlateCountry
	//
	#region Relation - Base__PlateCountry (Has-Many relation)
		private System.Data.DataTable _get_Base__PlateCountry_updatedById;
		public System.Data.DataTable getBase__PlateCountry_updatedById
		{
			get
			{
				if ((_get_Base__PlateCountry_updatedById == null) && (AutoLoadForeignKeys))
					loadBase__PlateCountry_updatedById ();

				return _get_Base__PlateCountry_updatedById;
			}
			set
			{
				_get_Base__PlateCountry_updatedById	= value;
			}
		}

		public void loadBase__PlateCountry_updatedById (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__PlateCountry	logic	= new BLL.Logic.GasStation.Base__PlateCountry (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("updatedById = @updatedById", "", false, true, new KeyValuePair ("@updatedById", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "updatedById = @updatedById", "", false, true, new KeyValuePair ("@updatedById", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__PlateCountry_updatedById	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Base__PlateLetter
	//
	#region Relation - Base__PlateLetter (Has-Many relation)
		private System.Data.DataTable _get_Base__PlateLetter_insertedById;
		public System.Data.DataTable getBase__PlateLetter_insertedById
		{
			get
			{
				if ((_get_Base__PlateLetter_insertedById == null) && (AutoLoadForeignKeys))
					loadBase__PlateLetter_insertedById ();

				return _get_Base__PlateLetter_insertedById;
			}
			set
			{
				_get_Base__PlateLetter_insertedById	= value;
			}
		}

		public void loadBase__PlateLetter_insertedById (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__PlateLetter	logic	= new BLL.Logic.GasStation.Base__PlateLetter (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("insertedById = @insertedById", "", false, true, new KeyValuePair ("@insertedById", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "insertedById = @insertedById", "", false, true, new KeyValuePair ("@insertedById", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__PlateLetter_insertedById	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Base__PlateLetter
	//
	#region Relation - Base__PlateLetter (Has-Many relation)
		private System.Data.DataTable _get_Base__PlateLetter_updatedById;
		public System.Data.DataTable getBase__PlateLetter_updatedById
		{
			get
			{
				if ((_get_Base__PlateLetter_updatedById == null) && (AutoLoadForeignKeys))
					loadBase__PlateLetter_updatedById ();

				return _get_Base__PlateLetter_updatedById;
			}
			set
			{
				_get_Base__PlateLetter_updatedById	= value;
			}
		}

		public void loadBase__PlateLetter_updatedById (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__PlateLetter	logic	= new BLL.Logic.GasStation.Base__PlateLetter (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("updatedById = @updatedById", "", false, true, new KeyValuePair ("@updatedById", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "updatedById = @updatedById", "", false, true, new KeyValuePair ("@updatedById", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__PlateLetter_updatedById	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Base__PlateType
	//
	#region Relation - Base__PlateType (Has-Many relation)
		private System.Data.DataTable _get_Base__PlateType_insertedById;
		public System.Data.DataTable getBase__PlateType_insertedById
		{
			get
			{
				if ((_get_Base__PlateType_insertedById == null) && (AutoLoadForeignKeys))
					loadBase__PlateType_insertedById ();

				return _get_Base__PlateType_insertedById;
			}
			set
			{
				_get_Base__PlateType_insertedById	= value;
			}
		}

		public void loadBase__PlateType_insertedById (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__PlateType	logic	= new BLL.Logic.GasStation.Base__PlateType (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("insertedById = @insertedById", "", false, true, new KeyValuePair ("@insertedById", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "insertedById = @insertedById", "", false, true, new KeyValuePair ("@insertedById", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__PlateType_insertedById	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Base__PlateType
	//
	#region Relation - Base__PlateType (Has-Many relation)
		private System.Data.DataTable _get_Base__PlateType_updatedById;
		public System.Data.DataTable getBase__PlateType_updatedById
		{
			get
			{
				if ((_get_Base__PlateType_updatedById == null) && (AutoLoadForeignKeys))
					loadBase__PlateType_updatedById ();

				return _get_Base__PlateType_updatedById;
			}
			set
			{
				_get_Base__PlateType_updatedById	= value;
			}
		}

		public void loadBase__PlateType_updatedById (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__PlateType	logic	= new BLL.Logic.GasStation.Base__PlateType (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("updatedById = @updatedById", "", false, true, new KeyValuePair ("@updatedById", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "updatedById = @updatedById", "", false, true, new KeyValuePair ("@updatedById", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__PlateType_updatedById	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of LegalOwner
	//
	#region Relation - LegalOwner (Has-Many relation)
		private System.Data.DataTable _get_LegalOwner_insertedById;
		public System.Data.DataTable getLegalOwner_insertedById
		{
			get
			{
				if ((_get_LegalOwner_insertedById == null) && (AutoLoadForeignKeys))
					loadLegalOwner_insertedById ();

				return _get_LegalOwner_insertedById;
			}
			set
			{
				_get_LegalOwner_insertedById	= value;
			}
		}

		public void loadLegalOwner_insertedById (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.LegalOwner	logic	= new BLL.Logic.GasStation.LegalOwner (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("insertedById = @insertedById", "", false, true, new KeyValuePair ("@insertedById", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "insertedById = @insertedById", "", false, true, new KeyValuePair ("@insertedById", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_LegalOwner_insertedById	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of LegalOwner
	//
	#region Relation - LegalOwner (Has-Many relation)
		private System.Data.DataTable _get_LegalOwner_updatedById;
		public System.Data.DataTable getLegalOwner_updatedById
		{
			get
			{
				if ((_get_LegalOwner_updatedById == null) && (AutoLoadForeignKeys))
					loadLegalOwner_updatedById ();

				return _get_LegalOwner_updatedById;
			}
			set
			{
				_get_LegalOwner_updatedById	= value;
			}
		}

		public void loadLegalOwner_updatedById (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.LegalOwner	logic	= new BLL.Logic.GasStation.LegalOwner (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("updatedById = @updatedById", "", false, true, new KeyValuePair ("@updatedById", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "updatedById = @updatedById", "", false, true, new KeyValuePair ("@updatedById", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_LegalOwner_updatedById	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Owner
	//
	#region Relation - Owner (Has-Many relation)
		private System.Data.DataTable _get_Owner_insertedById;
		public System.Data.DataTable getOwner_insertedById
		{
			get
			{
				if ((_get_Owner_insertedById == null) && (AutoLoadForeignKeys))
					loadOwner_insertedById ();

				return _get_Owner_insertedById;
			}
			set
			{
				_get_Owner_insertedById	= value;
			}
		}

		public void loadOwner_insertedById (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Owner	logic	= new BLL.Logic.GasStation.Owner (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("insertedById = @insertedById", "", false, true, new KeyValuePair ("@insertedById", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "insertedById = @insertedById", "", false, true, new KeyValuePair ("@insertedById", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Owner_insertedById	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Owner
	//
	#region Relation - Owner (Has-Many relation)
		private System.Data.DataTable _get_Owner_updatedById;
		public System.Data.DataTable getOwner_updatedById
		{
			get
			{
				if ((_get_Owner_updatedById == null) && (AutoLoadForeignKeys))
					loadOwner_updatedById ();

				return _get_Owner_updatedById;
			}
			set
			{
				_get_Owner_updatedById	= value;
			}
		}

		public void loadOwner_updatedById (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Owner	logic	= new BLL.Logic.GasStation.Owner (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("updatedById = @updatedById", "", false, true, new KeyValuePair ("@updatedById", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "updatedById = @updatedById", "", false, true, new KeyValuePair ("@updatedById", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Owner_updatedById	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Plate
	//
	#region Relation - Plate (Has-Many relation)
		private System.Data.DataTable _get_Plate_insertedById;
		public System.Data.DataTable getPlate_insertedById
		{
			get
			{
				if ((_get_Plate_insertedById == null) && (AutoLoadForeignKeys))
					loadPlate_insertedById ();

				return _get_Plate_insertedById;
			}
			set
			{
				_get_Plate_insertedById	= value;
			}
		}

		public void loadPlate_insertedById (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Plate	logic	= new BLL.Logic.GasStation.Plate (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("insertedById = @insertedById", "", false, true, new KeyValuePair ("@insertedById", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "insertedById = @insertedById", "", false, true, new KeyValuePair ("@insertedById", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Plate_insertedById	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Plate
	//
	#region Relation - Plate (Has-Many relation)
		private System.Data.DataTable _get_Plate_updatedById;
		public System.Data.DataTable getPlate_updatedById
		{
			get
			{
				if ((_get_Plate_updatedById == null) && (AutoLoadForeignKeys))
					loadPlate_updatedById ();

				return _get_Plate_updatedById;
			}
			set
			{
				_get_Plate_updatedById	= value;
			}
		}

		public void loadPlate_updatedById (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Plate	logic	= new BLL.Logic.GasStation.Plate (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("updatedById = @updatedById", "", false, true, new KeyValuePair ("@updatedById", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "updatedById = @updatedById", "", false, true, new KeyValuePair ("@updatedById", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Plate_updatedById	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of RealOwner
	//
	#region Relation - RealOwner (Has-Many relation)
		private System.Data.DataTable _get_RealOwner_insertedById;
		public System.Data.DataTable getRealOwner_insertedById
		{
			get
			{
				if ((_get_RealOwner_insertedById == null) && (AutoLoadForeignKeys))
					loadRealOwner_insertedById ();

				return _get_RealOwner_insertedById;
			}
			set
			{
				_get_RealOwner_insertedById	= value;
			}
		}

		public void loadRealOwner_insertedById (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.RealOwner	logic	= new BLL.Logic.GasStation.RealOwner (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("insertedById = @insertedById", "", false, true, new KeyValuePair ("@insertedById", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "insertedById = @insertedById", "", false, true, new KeyValuePair ("@insertedById", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_RealOwner_insertedById	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of RealOwner
	//
	#region Relation - RealOwner (Has-Many relation)
		private System.Data.DataTable _get_RealOwner_updatedById;
		public System.Data.DataTable getRealOwner_updatedById
		{
			get
			{
				if ((_get_RealOwner_updatedById == null) && (AutoLoadForeignKeys))
					loadRealOwner_updatedById ();

				return _get_RealOwner_updatedById;
			}
			set
			{
				_get_RealOwner_updatedById	= value;
			}
		}

		public void loadRealOwner_updatedById (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.RealOwner	logic	= new BLL.Logic.GasStation.RealOwner (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("updatedById = @updatedById", "", false, true, new KeyValuePair ("@updatedById", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "updatedById = @updatedById", "", false, true, new KeyValuePair ("@updatedById", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_RealOwner_updatedById	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Tag
	//
	#region Relation - Tag (Has-Many relation)
		private System.Data.DataTable _get_Tag_insertedById;
		public System.Data.DataTable getTag_insertedById
		{
			get
			{
				if ((_get_Tag_insertedById == null) && (AutoLoadForeignKeys))
					loadTag_insertedById ();

				return _get_Tag_insertedById;
			}
			set
			{
				_get_Tag_insertedById	= value;
			}
		}

		public void loadTag_insertedById (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Tag	logic	= new BLL.Logic.GasStation.Tag (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("insertedById = @insertedById", "", false, true, new KeyValuePair ("@insertedById", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "insertedById = @insertedById", "", false, true, new KeyValuePair ("@insertedById", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Tag_insertedById	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Tag
	//
	#region Relation - Tag (Has-Many relation)
		private System.Data.DataTable _get_Tag_updatedById;
		public System.Data.DataTable getTag_updatedById
		{
			get
			{
				if ((_get_Tag_updatedById == null) && (AutoLoadForeignKeys))
					loadTag_updatedById ();

				return _get_Tag_updatedById;
			}
			set
			{
				_get_Tag_updatedById	= value;
			}
		}

		public void loadTag_updatedById (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Tag	logic	= new BLL.Logic.GasStation.Tag (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("updatedById = @updatedById", "", false, true, new KeyValuePair ("@updatedById", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "updatedById = @updatedById", "", false, true, new KeyValuePair ("@updatedById", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Tag_updatedById	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Base__CarFuel
	//
	#region Relation - Base__CarFuel (Has-Many relation)
		private System.Data.DataTable _get_Base__CarFuel_insertedById;
		public System.Data.DataTable getBase__CarFuel_insertedById
		{
			get
			{
				if ((_get_Base__CarFuel_insertedById == null) && (AutoLoadForeignKeys))
					loadBase__CarFuel_insertedById ();

				return _get_Base__CarFuel_insertedById;
			}
			set
			{
				_get_Base__CarFuel_insertedById	= value;
			}
		}

		public void loadBase__CarFuel_insertedById (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__CarFuel	logic	= new BLL.Logic.GasStation.Base__CarFuel (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("insertedById = @insertedById", "", false, true, new KeyValuePair ("@insertedById", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "insertedById = @insertedById", "", false, true, new KeyValuePair ("@insertedById", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__CarFuel_insertedById	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Base__CarFuel
	//
	#region Relation - Base__CarFuel (Has-Many relation)
		private System.Data.DataTable _get_Base__CarFuel_updatedById;
		public System.Data.DataTable getBase__CarFuel_updatedById
		{
			get
			{
				if ((_get_Base__CarFuel_updatedById == null) && (AutoLoadForeignKeys))
					loadBase__CarFuel_updatedById ();

				return _get_Base__CarFuel_updatedById;
			}
			set
			{
				_get_Base__CarFuel_updatedById	= value;
			}
		}

		public void loadBase__CarFuel_updatedById (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__CarFuel	logic	= new BLL.Logic.GasStation.Base__CarFuel (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("updatedById = @updatedById", "", false, true, new KeyValuePair ("@updatedById", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "updatedById = @updatedById", "", false, true, new KeyValuePair ("@updatedById", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__CarFuel_updatedById	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of UHF
	//
	#region Relation - UHF (Has-Many relation)
		private System.Data.DataTable _get_UHF_insertedById;
		public System.Data.DataTable getUHF_insertedById
		{
			get
			{
				if ((_get_UHF_insertedById == null) && (AutoLoadForeignKeys))
					loadUHF_insertedById ();

				return _get_UHF_insertedById;
			}
			set
			{
				_get_UHF_insertedById	= value;
			}
		}

		public void loadUHF_insertedById (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.UHF	logic	= new BLL.Logic.GasStation.UHF (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("insertedById = @insertedById", "", false, true, new KeyValuePair ("@insertedById", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "insertedById = @insertedById", "", false, true, new KeyValuePair ("@insertedById", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_UHF_insertedById	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of UHF
	//
	#region Relation - UHF (Has-Many relation)
		private System.Data.DataTable _get_UHF_updatedById;
		public System.Data.DataTable getUHF_updatedById
		{
			get
			{
				if ((_get_UHF_updatedById == null) && (AutoLoadForeignKeys))
					loadUHF_updatedById ();

				return _get_UHF_updatedById;
			}
			set
			{
				_get_UHF_updatedById	= value;
			}
		}

		public void loadUHF_updatedById (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.UHF	logic	= new BLL.Logic.GasStation.UHF (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("updatedById = @updatedById", "", false, true, new KeyValuePair ("@updatedById", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "updatedById = @updatedById", "", false, true, new KeyValuePair ("@updatedById", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_UHF_updatedById	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Base__CarLevel
	//
	#region Relation - Base__CarLevel (Has-Many relation)
		private System.Data.DataTable _get_Base__CarLevel_insertedById;
		public System.Data.DataTable getBase__CarLevel_insertedById
		{
			get
			{
				if ((_get_Base__CarLevel_insertedById == null) && (AutoLoadForeignKeys))
					loadBase__CarLevel_insertedById ();

				return _get_Base__CarLevel_insertedById;
			}
			set
			{
				_get_Base__CarLevel_insertedById	= value;
			}
		}

		public void loadBase__CarLevel_insertedById (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__CarLevel	logic	= new BLL.Logic.GasStation.Base__CarLevel (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("insertedById = @insertedById", "", false, true, new KeyValuePair ("@insertedById", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "insertedById = @insertedById", "", false, true, new KeyValuePair ("@insertedById", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__CarLevel_insertedById	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Base__CarLevel
	//
	#region Relation - Base__CarLevel (Has-Many relation)
		private System.Data.DataTable _get_Base__CarLevel_updatedById;
		public System.Data.DataTable getBase__CarLevel_updatedById
		{
			get
			{
				if ((_get_Base__CarLevel_updatedById == null) && (AutoLoadForeignKeys))
					loadBase__CarLevel_updatedById ();

				return _get_Base__CarLevel_updatedById;
			}
			set
			{
				_get_Base__CarLevel_updatedById	= value;
			}
		}

		public void loadBase__CarLevel_updatedById (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__CarLevel	logic	= new BLL.Logic.GasStation.Base__CarLevel (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("updatedById = @updatedById", "", false, true, new KeyValuePair ("@updatedById", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "updatedById = @updatedById", "", false, true, new KeyValuePair ("@updatedById", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__CarLevel_updatedById	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Car
	//
	#region Relation - Car (Has-Many relation)
		private System.Data.DataTable _get_Car_insertedById;
		public System.Data.DataTable getCar_insertedById
		{
			get
			{
				if ((_get_Car_insertedById == null) && (AutoLoadForeignKeys))
					loadCar_insertedById ();

				return _get_Car_insertedById;
			}
			set
			{
				_get_Car_insertedById	= value;
			}
		}

		public void loadCar_insertedById (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Car	logic	= new BLL.Logic.GasStation.Car (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("insertedById = @insertedById", "", false, true, new KeyValuePair ("@insertedById", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "insertedById = @insertedById", "", false, true, new KeyValuePair ("@insertedById", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Car_insertedById	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Car
	//
	#region Relation - Car (Has-Many relation)
		private System.Data.DataTable _get_Car_updatedById;
		public System.Data.DataTable getCar_updatedById
		{
			get
			{
				if ((_get_Car_updatedById == null) && (AutoLoadForeignKeys))
					loadCar_updatedById ();

				return _get_Car_updatedById;
			}
			set
			{
				_get_Car_updatedById	= value;
			}
		}

		public void loadCar_updatedById (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Car	logic	= new BLL.Logic.GasStation.Car (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("updatedById = @updatedById", "", false, true, new KeyValuePair ("@updatedById", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "updatedById = @updatedById", "", false, true, new KeyValuePair ("@updatedById", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Car_updatedById	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Base__CarModel
	//
	#region Relation - Base__CarModel (Has-Many relation)
		private System.Data.DataTable _get_Base__CarModel_insertedById;
		public System.Data.DataTable getBase__CarModel_insertedById
		{
			get
			{
				if ((_get_Base__CarModel_insertedById == null) && (AutoLoadForeignKeys))
					loadBase__CarModel_insertedById ();

				return _get_Base__CarModel_insertedById;
			}
			set
			{
				_get_Base__CarModel_insertedById	= value;
			}
		}

		public void loadBase__CarModel_insertedById (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__CarModel	logic	= new BLL.Logic.GasStation.Base__CarModel (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("insertedById = @insertedById", "", false, true, new KeyValuePair ("@insertedById", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "insertedById = @insertedById", "", false, true, new KeyValuePair ("@insertedById", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__CarModel_insertedById	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Base__CarModel
	//
	#region Relation - Base__CarModel (Has-Many relation)
		private System.Data.DataTable _get_Base__CarModel_updatedById;
		public System.Data.DataTable getBase__CarModel_updatedById
		{
			get
			{
				if ((_get_Base__CarModel_updatedById == null) && (AutoLoadForeignKeys))
					loadBase__CarModel_updatedById ();

				return _get_Base__CarModel_updatedById;
			}
			set
			{
				_get_Base__CarModel_updatedById	= value;
			}
		}

		public void loadBase__CarModel_updatedById (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Base__CarModel	logic	= new BLL.Logic.GasStation.Base__CarModel (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("updatedById = @updatedById", "", false, true, new KeyValuePair ("@updatedById", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "updatedById = @updatedById", "", false, true, new KeyValuePair ("@updatedById", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Base__CarModel_updatedById	= opResult.model as System.Data.DataTable;
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
		public System.DateTime insertDate
		{
			get;
			set;
		}
	}
}