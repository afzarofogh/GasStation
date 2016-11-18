using System;
using System.Data;
using BaseDAL.Model;

namespace Common.BLL.Entity.GasStation
{
	[Serializable]
	public class Car : BaseBLL.Entity.BaseByViewId
	{

        //[BaseBLL.Base.Field(nullable = false, sqlDBType = System.Data.SqlDbType.Int, primary = false, usage = BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create)]
        //public System.Int32 id
        //{
        //    get;
        //    set;
        //}
//
	// Genereted Property of Owner
	//
	#region Relation - Owner (Has-Many relation)
		private System.Data.DataTable _get_Owner_carId;
		public System.Data.DataTable getOwner_carId
		{
			get
			{
				if ((_get_Owner_carId == null) && (AutoLoadForeignKeys))
					loadOwner_carId ();

				return _get_Owner_carId;
			}
			set
			{
				_get_Owner_carId	= value;
			}
		}

		public void loadOwner_carId (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Owner	logic	= new BLL.Logic.GasStation.Owner (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("carId = @carId", "", false, true, new KeyValuePair ("@carId", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "carId = @carId", "", false, true, new KeyValuePair ("@carId", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Owner_carId	= opResult.model as System.Data.DataTable;
		}
	#endregion

		//[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.UniqueIdentifier,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create)]
		//public System.Guid viewId
		//{
		//	get;
		//	set;
		//}

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,foreignLogicType=typeof (BLL.Logic.GasStation.Base__CarType),foreignField="id")]
		public System.Int32 carTypeId
		{
			get;
			set;
		}
//
	// Genereted Property of carTypeId
	//
	#region Referenced Property - Base__CarType
		BLL.Entity.GasStation.Base__CarType _Base__CarType_carTypeId;
		public BLL.Entity.GasStation.Base__CarType Base__CarType_carTypeId
		{
			get
			{
				if ((null == _Base__CarType_carTypeId) && (AutoLoadForeignKeys))
					load_Base__CarType_carTypeId ();
				return _Base__CarType_carTypeId;
			}
			set
			{
				_Base__CarType_carTypeId	= value;
			}
		}

		public void load_Base__CarType_carTypeId ()
		{ 
			BLL.Entity.GasStation.Base__CarType	entity;
			BLL.Logic.GasStation.Base__CarType	logic;

			entity	= new BLL.Entity.GasStation.Base__CarType () { id = carTypeId };
			logic	= new BLL.Logic.GasStation.Base__CarType (Common.Enum.EDatabase.GasStation);
			logic.read (entity);

			_Base__CarType_carTypeId	= entity;
		}
	#endregion

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,foreignLogicType=typeof (BLL.Logic.GasStation.Base__CarColor),foreignField="id")]
		public System.Int32 carColorId
		{
			get;
			set;
		}
//
	// Genereted Property of carColorId
	//
	#region Referenced Property - Base__CarColor
		BLL.Entity.GasStation.Base__CarColor _Base__CarColor_carColorId;
		public BLL.Entity.GasStation.Base__CarColor Base__CarColor_carColorId
		{
			get
			{
				if ((null == _Base__CarColor_carColorId) && (AutoLoadForeignKeys))
					load_Base__CarColor_carColorId ();
				return _Base__CarColor_carColorId;
			}
			set
			{
				_Base__CarColor_carColorId	= value;
			}
		}

		public void load_Base__CarColor_carColorId ()
		{ 
			BLL.Entity.GasStation.Base__CarColor	entity;
			BLL.Logic.GasStation.Base__CarColor	logic;

			entity	= new BLL.Entity.GasStation.Base__CarColor () { id = carColorId };
			logic	= new BLL.Logic.GasStation.Base__CarColor (Common.Enum.EDatabase.GasStation);
			logic.read (entity);

			_Base__CarColor_carColorId	= entity;
		}
	#endregion

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,foreignLogicType=typeof (BLL.Logic.GasStation.Base__CarModel),foreignField="id")]
		public System.Int32 carModelId
		{
			get;
			set;
		}
//
	// Genereted Property of carModelId
	//
	#region Referenced Property - Base__CarModel
		BLL.Entity.GasStation.Base__CarModel _Base__CarModel_carModelId;
		public BLL.Entity.GasStation.Base__CarModel Base__CarModel_carModelId
		{
			get
			{
				if ((null == _Base__CarModel_carModelId) && (AutoLoadForeignKeys))
					load_Base__CarModel_carModelId ();
				return _Base__CarModel_carModelId;
			}
			set
			{
				_Base__CarModel_carModelId	= value;
			}
		}

		public void load_Base__CarModel_carModelId ()
		{ 
			BLL.Entity.GasStation.Base__CarModel	entity;
			BLL.Logic.GasStation.Base__CarModel	logic;

			entity	= new BLL.Entity.GasStation.Base__CarModel () { id = carModelId };
			logic	= new BLL.Logic.GasStation.Base__CarModel (Common.Enum.EDatabase.GasStation);
			logic.read (entity);

			_Base__CarModel_carModelId	= entity;
		}
	#endregion

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,foreignLogicType=typeof (BLL.Logic.GasStation.Base__CarLevel),foreignField="id")]
		public System.Int32 carLevelId
		{
			get;
			set;
		}
//
	// Genereted Property of carLevelId
	//
	#region Referenced Property - Base__CarLevel
		BLL.Entity.GasStation.Base__CarLevel _Base__CarLevel_carLevelId;
		public BLL.Entity.GasStation.Base__CarLevel Base__CarLevel_carLevelId
		{
			get
			{
				if ((null == _Base__CarLevel_carLevelId) && (AutoLoadForeignKeys))
					load_Base__CarLevel_carLevelId ();
				return _Base__CarLevel_carLevelId;
			}
			set
			{
				_Base__CarLevel_carLevelId	= value;
			}
		}

		public void load_Base__CarLevel_carLevelId ()
		{ 
			BLL.Entity.GasStation.Base__CarLevel	entity;
			BLL.Logic.GasStation.Base__CarLevel	logic;

			entity	= new BLL.Entity.GasStation.Base__CarLevel () { id = carLevelId };
			logic	= new BLL.Logic.GasStation.Base__CarLevel (Common.Enum.EDatabase.GasStation);
			logic.read (entity);

			_Base__CarLevel_carLevelId	= entity;
		}
	#endregion

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,foreignLogicType=typeof (BLL.Logic.GasStation.Base__CarFuel),foreignField="id")]
		public System.Int32 carFuelId
		{
			get;
			set;
		}
//
	// Genereted Property of carFuelId
	//
	#region Referenced Property - Base__CarFuel
		BLL.Entity.GasStation.Base__CarFuel _Base__CarFuel_carFuelId;
		public BLL.Entity.GasStation.Base__CarFuel Base__CarFuel_carFuelId
		{
			get
			{
				if ((null == _Base__CarFuel_carFuelId) && (AutoLoadForeignKeys))
					load_Base__CarFuel_carFuelId ();
				return _Base__CarFuel_carFuelId;
			}
			set
			{
				_Base__CarFuel_carFuelId	= value;
			}
		}

		public void load_Base__CarFuel_carFuelId ()
		{ 
			BLL.Entity.GasStation.Base__CarFuel	entity;
			BLL.Logic.GasStation.Base__CarFuel	logic;

			entity	= new BLL.Entity.GasStation.Base__CarFuel () { id = carFuelId };
			logic	= new BLL.Logic.GasStation.Base__CarFuel (Common.Enum.EDatabase.GasStation);
			logic.read (entity);

			_Base__CarFuel_carFuelId	= entity;
		}
	#endregion

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,foreignLogicType=typeof (BLL.Logic.GasStation.Plate),foreignField="id")]
		public System.Int32 plateId
		{
			get;
			set;
		}
//
	// Genereted Property of plateId
	//
	#region Referenced Property - Plate
		BLL.Entity.GasStation.Plate _Plate_plateId;
		public BLL.Entity.GasStation.Plate Plate_plateId
		{
			get
			{
				if ((null == _Plate_plateId) && (AutoLoadForeignKeys))
					load_Plate_plateId ();
				return _Plate_plateId;
			}
			set
			{
				_Plate_plateId	= value;
			}
		}

		public void load_Plate_plateId ()
		{ 
			BLL.Entity.GasStation.Plate	entity;
			BLL.Logic.GasStation.Plate	logic;

			entity	= new BLL.Entity.GasStation.Plate () { id = plateId };
			logic	= new BLL.Logic.GasStation.Plate (Common.Enum.EDatabase.GasStation);
			logic.read (entity);

			_Plate_plateId	= entity;
		}
	#endregion

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,foreignLogicType=typeof (BLL.Logic.GasStation.Tag),foreignField="id")]
		public System.Int32 tagId
		{
			get;
			set;
		}
//
	// Genereted Property of tagId
	//
	#region Referenced Property - Tag
		BLL.Entity.GasStation.Tag _Tag_tagId;
		public BLL.Entity.GasStation.Tag Tag_tagId
		{
			get
			{
				if ((null == _Tag_tagId) && (AutoLoadForeignKeys))
					load_Tag_tagId ();
				return _Tag_tagId;
			}
			set
			{
				_Tag_tagId	= value;
			}
		}

		public void load_Tag_tagId ()
		{ 
			BLL.Entity.GasStation.Tag	entity;
			BLL.Logic.GasStation.Tag	logic;

			entity	= new BLL.Entity.GasStation.Tag () { id = tagId };
			logic	= new BLL.Logic.GasStation.Tag (Common.Enum.EDatabase.GasStation);
			logic.read (entity);

			_Tag_tagId	= entity;
		}
	#endregion

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Bit,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create)]
		public System.Boolean status
		{
			get;
			set;
		}

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.SmallInt,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create)]
		public System.Int16 capacity
		{
			get;
			set;
		}

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.VarChar,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,size=50)]
		public System.String chasisCode
		{
			get;
			set;
		}

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.VarChar,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,size=50)]
		public System.String engineCode
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