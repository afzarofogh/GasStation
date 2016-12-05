using System;
using BaseDAL.Model;

namespace Common.BLL.Logic.GasStation
{
	public class Traffic : BaseBLL.Logic.Base<BLL.Entity.GasStation.Traffic>
	{
		#region Constants
		private const string	C_spTrafficRegisterByService	= "spTrafficRegisterByService";
		#endregion

		#region Methods
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="type"></param>
		public Traffic (object type) : base (type)
		{
		} 

		/// <summary>
		/// Insert tag
		/// </summary>
		/// <returns></returns>
		public CommandResult insertTagByService (Common.BLL.Entity.GasStation.Tag tag,
			Common.BLL.Entity.GasStation.User user, DateTime regDate, int intervalTime)
		{
			CommandResult result	= null;

			if ((null != tag) && (null != user))
			{	
				// Register new traffic
				result	= BaseDAL.DBaseHelper.executeCommand (BaseDAL.Base.EnumExecuteType.procedureNonQuery, connection, C_spTrafficRegisterByService, true,
					new KeyValuePair ("@tagData", tag.tag),
					new KeyValuePair ("@insertedById", user.id),
					new KeyValuePair ("@trafficDate", regDate),
					new KeyValuePair ("@intervalTime", intervalTime)
					);
			}
			else
				result	= CommandResult.makeNullDataResult ();

			return result;
		}
		#endregion
	}
}