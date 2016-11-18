using System;
using System.Data;
using BaseDAL.Model;

namespace Common.BLL.Entity.GasStation
{
	[Serializable]
	public class Owner : BaseBLL.Entity.BaseByViewId
	{
		
		//[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create)]
		//public System.Int32 id
		//{
		//	get;
		//	set;
		//}

		//[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.UniqueIdentifier,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create)]
		//public System.Guid viewId
		//{
		//	get;
		//	set;
		//}

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,foreignLogicType=typeof (BLL.Logic.GasStation.Base__OwnerType),foreignField="id")]
		public System.Int32 ownerTypeId
		{
			get;
			set;
		}
//
	// Genereted Property of ownerTypeId
	//
	#region Referenced Property - Base__OwnerType
		BLL.Entity.GasStation.Base__OwnerType _Base__OwnerType_ownerTypeId;
		public BLL.Entity.GasStation.Base__OwnerType Base__OwnerType_ownerTypeId
		{
			get
			{
				if ((null == _Base__OwnerType_ownerTypeId) && (AutoLoadForeignKeys))
					load_Base__OwnerType_ownerTypeId ();
				return _Base__OwnerType_ownerTypeId;
			}
			set
			{
				_Base__OwnerType_ownerTypeId	= value;
			}
		}

		public void load_Base__OwnerType_ownerTypeId ()
		{ 
			BLL.Entity.GasStation.Base__OwnerType	entity;
			BLL.Logic.GasStation.Base__OwnerType	logic;

			entity	= new BLL.Entity.GasStation.Base__OwnerType () { id = ownerTypeId };
			logic	= new BLL.Logic.GasStation.Base__OwnerType (Common.Enum.EDatabase.GasStation);
			logic.read (entity);

			_Base__OwnerType_ownerTypeId	= entity;
		}
	#endregion

		[BaseBLL.Base.Field(nullable=true,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,foreignLogicType=typeof (BLL.Logic.GasStation.RealOwner),foreignField="id")]
		public Nullable<System.Int32> realOwnerId
		{
			get;
			set;
		}
//
	// Genereted Property of realOwnerId
	//
	#region Referenced Property - RealOwner
		BLL.Entity.GasStation.RealOwner _RealOwner_realOwnerId;
		public BLL.Entity.GasStation.RealOwner RealOwner_realOwnerId
		{
			get
			{
				if ((null == _RealOwner_realOwnerId) && (realOwnerId.HasValue) && (AutoLoadForeignKeys))
					load_RealOwner_realOwnerId ();
				return _RealOwner_realOwnerId;
			}
			set
			{
				_RealOwner_realOwnerId	= value;
			}
		}

		public void load_RealOwner_realOwnerId ()
		{ 
			BLL.Entity.GasStation.RealOwner	entity;
			BLL.Logic.GasStation.RealOwner	logic;

			entity	= new BLL.Entity.GasStation.RealOwner () { id = realOwnerId.Value };
			logic	= new BLL.Logic.GasStation.RealOwner (Common.Enum.EDatabase.GasStation);
			logic.read (entity);

			_RealOwner_realOwnerId	= entity;
		}
	#endregion

		[BaseBLL.Base.Field(nullable=true,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,foreignLogicType=typeof (BLL.Logic.GasStation.LegalOwner),foreignField="id")]
		public Nullable<System.Int32> legalOwnerId
		{
			get;
			set;
		}
//
	// Genereted Property of legalOwnerId
	//
	#region Referenced Property - LegalOwner
		BLL.Entity.GasStation.LegalOwner _LegalOwner_legalOwnerId;
		public BLL.Entity.GasStation.LegalOwner LegalOwner_legalOwnerId
		{
			get
			{
				if ((null == _LegalOwner_legalOwnerId) && (legalOwnerId.HasValue) && (AutoLoadForeignKeys))
					load_LegalOwner_legalOwnerId ();
				return _LegalOwner_legalOwnerId;
			}
			set
			{
				_LegalOwner_legalOwnerId	= value;
			}
		}

		public void load_LegalOwner_legalOwnerId ()
		{ 
			BLL.Entity.GasStation.LegalOwner	entity;
			BLL.Logic.GasStation.LegalOwner	logic;

			entity	= new BLL.Entity.GasStation.LegalOwner () { id = legalOwnerId.Value };
			logic	= new BLL.Logic.GasStation.LegalOwner (Common.Enum.EDatabase.GasStation);
			logic.read (entity);

			_LegalOwner_legalOwnerId	= entity;
		}
	#endregion

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,foreignLogicType=typeof (BLL.Logic.GasStation.Car),foreignField="id")]
		public System.Int32 carId
		{
			get;
			set;
		}
//
	// Genereted Property of carId
	//
	#region Referenced Property - Car
		BLL.Entity.GasStation.Car _Car_carId;
		public BLL.Entity.GasStation.Car Car_carId
		{
			get
			{
				if ((null == _Car_carId) && (AutoLoadForeignKeys))
					load_Car_carId ();
				return _Car_carId;
			}
			set
			{
				_Car_carId	= value;
			}
		}

		public void load_Car_carId ()
		{ 
			BLL.Entity.GasStation.Car	entity;
			BLL.Logic.GasStation.Car	logic;

			entity	= new BLL.Entity.GasStation.Car () { id = carId };
			logic	= new BLL.Logic.GasStation.Car (Common.Enum.EDatabase.GasStation);
			logic.read (entity);

			_Car_carId	= entity;
		}
	#endregion

		[BaseBLL.Base.Field(nullable=true,sqlDBType=System.Data.SqlDbType.VarChar,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,size=50)]
		public System.String phone
		{
			get;
			set;
		}

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.VarChar,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,size=50)]
		public System.String mobile
		{
			get;
			set;
		}

		[BaseBLL.Base.Field(nullable=true,sqlDBType=System.Data.SqlDbType.VarChar,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,size=50)]
		public System.String address
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