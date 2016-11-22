using System;
using BaseDAL.Model;

namespace Common.BLL.Logic.GasStation
{
	public class User : BaseBLL.Logic.Base<BLL.Entity.GasStation.User>
	{
		#region Constants
		public const string	C_spUserDelete	= "spUserDelete";
		#endregion

		#region Methods
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="type"></param>
		public User (object type) : base (type)
		{
		}
		#endregion

		#region Custom Methods
		/// <summary>
		/// Delete a user
		/// </summary>
		/// <param name="user">User Model</param>
		/// <returns></returns>
		public CommandResult deleteUser (Entity.GasStation.User user) 
		{
			CommandResult result;

			if (null != user)
				result	= BaseDAL.DBaseHelper.executeCommand (BaseDAL.Base.EnumExecuteType.procedureReader, connection, C_spUserDelete, true,
					new KeyValuePair ("@userId", user.id)
					);
			else
				result	= CommandResult.makeNullDataResult ();

			return result;
		}
		#endregion
	}
}