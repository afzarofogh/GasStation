using System;
using System.Data;
using BaseDAL.Model;

namespace Common.BLL.Entity.GasStation
{
	[Serializable]
	public class System__Data : BaseBLL.Entity.BaseByViewId
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

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.VarChar,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,size=50)]
		public System.String name
		{
			get;
			set;
		}

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Text,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,size=2147483647)]
		public System.String value
		{
			get;
			set;
		}

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Text,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,size=2147483647)]
		public System.String version
		{
			get;
			set;
		}
	}
}