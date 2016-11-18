using System;
using System.Data;
using BaseDAL.Model;

namespace Common.BLL.Entity.GasStation
{
	[Serializable]
	public class LegalOwner : BaseBLL.Entity.BaseByViewId
	{
		
		//[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create)]
		//public System.Int32 id
		//{
		//	get;
		//	set;
		//}
//
	// Genereted Property of Owner
	//
	#region Relation - Owner (Has-Many relation)
		private System.Data.DataTable _get_Owner_legalOwnerId;
		public System.Data.DataTable getOwner_legalOwnerId
		{
			get
			{
				if ((_get_Owner_legalOwnerId == null) && (AutoLoadForeignKeys))
					loadOwner_legalOwnerId ();

				return _get_Owner_legalOwnerId;
			}
			set
			{
				_get_Owner_legalOwnerId	= value;
			}
		}

		public void loadOwner_legalOwnerId (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Owner	logic	= new BLL.Logic.GasStation.Owner (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("legalOwnerId = @legalOwnerId", "", false, true, new KeyValuePair ("@legalOwnerId", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "legalOwnerId = @legalOwnerId", "", false, true, new KeyValuePair ("@legalOwnerId", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Owner_legalOwnerId	= opResult.model as System.Data.DataTable;
		}
	#endregion

		//[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.UniqueIdentifier,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create)]
		//public System.Guid viewId
		//{
		//	get;
		//	set;
		//}

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.VarChar,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,size=50)]
		public System.String OrganizationCode
		{
			get;
			set;
		}

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