using System;
using BaseDAL.Model;

namespace Common.BLL.Logic.GasStation
{
	public class Traffic : BaseBLL.Logic.Base<BLL.Entity.GasStation.Traffic>
	{
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
		public CommandResult insertTag (Common.BLL.Entity.GasStation.Tag tag)
		{
			CommandResult result	= null;

			if (null != tag)
			{

			}
			else
				result	= CommandResult.makeNullDataResult ();

			return result;
		}
		#endregion
	}
}