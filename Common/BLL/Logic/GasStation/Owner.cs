using System;
using BaseDAL.Model;

namespace Common.BLL.Logic.GasStation
{
	public class Owner : BaseBLL.Logic.Base<BLL.Entity.GasStation.Owner>
	{
		#region Methods
		public Owner (object type) : base (type)
		{
		}
		#endregion

		#region Custom Methods
		/// <summary>
		/// Load View Owner
		/// </summary>
		/// <returns></returns>
		public CommandResult loadViewOwner()
		{
			CommandResult result;
			string commandString	=	 "Select * from viewCustomer";
			result = BaseDAL.DBaseHelper.executeCommand(BaseDAL.Base.EnumExecuteType.reader, connection, commandString);

			return result;
		}
		#endregion
	}
}