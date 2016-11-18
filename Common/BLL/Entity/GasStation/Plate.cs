using System;
using System.Data;
using BaseDAL.Model;

namespace Common.BLL.Entity.GasStation
{
	[Serializable]
	public class Plate : BaseBLL.Entity.BaseByViewId
	{
		
		//[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create)]
		//public System.Int32 id
		//{
		//	get;
		//	set;
		//}
//
	// Genereted Property of Car
	//
	#region Relation - Car (Has-Many relation)
		private System.Data.DataTable _get_Car_plateId;
		public System.Data.DataTable getCar_plateId
		{
			get
			{
				if ((_get_Car_plateId == null) && (AutoLoadForeignKeys))
					loadCar_plateId ();

				return _get_Car_plateId;
			}
			set
			{
				_get_Car_plateId	= value;
			}
		}

		public void loadCar_plateId (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Car	logic	= new BLL.Logic.GasStation.Car (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("plateId = @plateId", "", false, true, new KeyValuePair ("@plateId", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "plateId = @plateId", "", false, true, new KeyValuePair ("@plateId", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Car_plateId	= opResult.model as System.Data.DataTable;
		}
	#endregion

		//[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.UniqueIdentifier,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create)]
		//public System.Guid viewId
		//{
		//	get;
		//	set;
		//}

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,foreignLogicType=typeof (BLL.Logic.GasStation.Base__PlateType),foreignField="id")]
		public System.Int32 plateTypeId
		{
			get;
			set;
		}
//
	// Genereted Property of plateTypeId
	//
	#region Referenced Property - Base__PlateType
		BLL.Entity.GasStation.Base__PlateType _Base__PlateType_plateTypeId;
		public BLL.Entity.GasStation.Base__PlateType Base__PlateType_plateTypeId
		{
			get
			{
				if ((null == _Base__PlateType_plateTypeId) && (AutoLoadForeignKeys))
					load_Base__PlateType_plateTypeId ();
				return _Base__PlateType_plateTypeId;
			}
			set
			{
				_Base__PlateType_plateTypeId	= value;
			}
		}

		public void load_Base__PlateType_plateTypeId ()
		{ 
			BLL.Entity.GasStation.Base__PlateType	entity;
			BLL.Logic.GasStation.Base__PlateType	logic;

			entity	= new BLL.Entity.GasStation.Base__PlateType () { id = plateTypeId };
			logic	= new BLL.Logic.GasStation.Base__PlateType (Common.Enum.EDatabase.GasStation);
			logic.read (entity);

			_Base__PlateType_plateTypeId	= entity;
		}
	#endregion

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,foreignLogicType=typeof (BLL.Logic.GasStation.Base__PlateCity),foreignField="id")]
		public System.Int32 plateCityId
		{
			get;
			set;
		}
//
	// Genereted Property of plateCityId
	//
	#region Referenced Property - Base__PlateCity
		BLL.Entity.GasStation.Base__PlateCity _Base__PlateCity_plateCityId;
		public BLL.Entity.GasStation.Base__PlateCity Base__PlateCity_plateCityId
		{
			get
			{
				if ((null == _Base__PlateCity_plateCityId) && (AutoLoadForeignKeys))
					load_Base__PlateCity_plateCityId ();
				return _Base__PlateCity_plateCityId;
			}
			set
			{
				_Base__PlateCity_plateCityId	= value;
			}
		}

		public void load_Base__PlateCity_plateCityId ()
		{ 
			BLL.Entity.GasStation.Base__PlateCity	entity;
			BLL.Logic.GasStation.Base__PlateCity	logic;

			entity	= new BLL.Entity.GasStation.Base__PlateCity () { id = plateCityId };
			logic	= new BLL.Logic.GasStation.Base__PlateCity (Common.Enum.EDatabase.GasStation);
			logic.read (entity);

			_Base__PlateCity_plateCityId	= entity;
		}
	#endregion

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,foreignLogicType=typeof (BLL.Logic.GasStation.Base__PlateCountry),foreignField="id")]
		public System.Int32 plateCountryId
		{
			get;
			set;
		}
//
	// Genereted Property of plateCountryId
	//
	#region Referenced Property - Base__PlateCountry
		BLL.Entity.GasStation.Base__PlateCountry _Base__PlateCountry_plateCountryId;
		public BLL.Entity.GasStation.Base__PlateCountry Base__PlateCountry_plateCountryId
		{
			get
			{
				if ((null == _Base__PlateCountry_plateCountryId) && (AutoLoadForeignKeys))
					load_Base__PlateCountry_plateCountryId ();
				return _Base__PlateCountry_plateCountryId;
			}
			set
			{
				_Base__PlateCountry_plateCountryId	= value;
			}
		}

		public void load_Base__PlateCountry_plateCountryId ()
		{ 
			BLL.Entity.GasStation.Base__PlateCountry	entity;
			BLL.Logic.GasStation.Base__PlateCountry	logic;

			entity	= new BLL.Entity.GasStation.Base__PlateCountry () { id = plateCountryId };
			logic	= new BLL.Logic.GasStation.Base__PlateCountry (Common.Enum.EDatabase.GasStation);
			logic.read (entity);

			_Base__PlateCountry_plateCountryId	= entity;
		}
	#endregion

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,foreignLogicType=typeof (BLL.Logic.GasStation.Base__PlateLetter),foreignField="id")]
		public System.Int32 plateLetterId
		{
			get;
			set;
		}
//
	// Genereted Property of plateLetterId
	//
	#region Referenced Property - Base__PlateLetter
		BLL.Entity.GasStation.Base__PlateLetter _Base__PlateLetter_plateLetterId;
		public BLL.Entity.GasStation.Base__PlateLetter Base__PlateLetter_plateLetterId
		{
			get
			{
				if ((null == _Base__PlateLetter_plateLetterId) && (AutoLoadForeignKeys))
					load_Base__PlateLetter_plateLetterId ();
				return _Base__PlateLetter_plateLetterId;
			}
			set
			{
				_Base__PlateLetter_plateLetterId	= value;
			}
		}

		public void load_Base__PlateLetter_plateLetterId ()
		{ 
			BLL.Entity.GasStation.Base__PlateLetter	entity;
			BLL.Logic.GasStation.Base__PlateLetter	logic;

			entity	= new BLL.Entity.GasStation.Base__PlateLetter () { id = plateLetterId };
			logic	= new BLL.Logic.GasStation.Base__PlateLetter (Common.Enum.EDatabase.GasStation);
			logic.read (entity);

			_Base__PlateLetter_plateLetterId	= entity;
		}
	#endregion

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.VarChar,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,size=50)]
		public System.String plate
		{
			get;
			set;
		}

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,foreignLogicType=typeof (BLL.Logic.GasStation.User),foreignField="id")]
		public System.Int32 insertedBy
		{
			get;
			set;
		}
//
	// Genereted Property of insertedBy
	//
	#region Referenced Property - User
		BLL.Entity.GasStation.User _User_insertedBy;
		public BLL.Entity.GasStation.User User_insertedBy
		{
			get
			{
				if ((null == _User_insertedBy) && (AutoLoadForeignKeys))
					load_User_insertedBy ();
				return _User_insertedBy;
			}
			set
			{
				_User_insertedBy	= value;
			}
		}

		public void load_User_insertedBy ()
		{ 
			BLL.Entity.GasStation.User	entity;
			BLL.Logic.GasStation.User	logic;

			entity	= new BLL.Entity.GasStation.User () { id = insertedBy };
			logic	= new BLL.Logic.GasStation.User (Common.Enum.EDatabase.GasStation);
			logic.read (entity);

			_User_insertedBy	= entity;
		}
	#endregion

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.DateTime,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create)]
		public System.DateTime insertDate
		{
			get;
			set;
		}

		[BaseBLL.Base.Field(nullable=true,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,foreignLogicType=typeof (BLL.Logic.GasStation.User),foreignField="id")]
		public Nullable<System.Int32> updatedBy
		{
			get;
			set;
		}
//
	// Genereted Property of updatedBy
	//
	#region Referenced Property - User
		BLL.Entity.GasStation.User _User_updatedBy;
		public BLL.Entity.GasStation.User User_updatedBy
		{
			get
			{
				if ((null == _User_updatedBy) && (updatedBy.HasValue) && (AutoLoadForeignKeys))
					load_User_updatedBy ();
				return _User_updatedBy;
			}
			set
			{
				_User_updatedBy	= value;
			}
		}

		public void load_User_updatedBy ()
		{ 
			BLL.Entity.GasStation.User	entity;
			BLL.Logic.GasStation.User	logic;

			entity	= new BLL.Entity.GasStation.User () { id = updatedBy.Value };
			logic	= new BLL.Logic.GasStation.User (Common.Enum.EDatabase.GasStation);
			logic.read (entity);

			_User_updatedBy	= entity;
		}
	#endregion

		[BaseBLL.Base.Field(nullable=true,sqlDBType=System.Data.SqlDbType.DateTime,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create)]
		public Nullable<System.DateTime> updateDate
		{
			get;
			set;
		}
	}
}