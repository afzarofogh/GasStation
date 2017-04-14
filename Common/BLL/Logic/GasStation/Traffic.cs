using System;
using BaseDAL.Model;

namespace Common.BLL.Logic.GasStation
{
	public class Traffic : BaseBLL.Logic.Base<BLL.Entity.GasStation.Traffic>
	{
		#region Constants
		private const string	C_spTrafficRegisterByService		= "spTrafficRegisterByService";
		private const string	C_spGetReportTraffic				= "spGetReportTraffic";	
		private const string	C_spGetReportTrafficByNationalcode	= "spGetReportTrafficByNationalcode";	
		private const string	C_spGetReportTrafficByPlate			= "spGetReportTrafficByPlate";	
		public const string		C_spGetTrafficSearchByNationalcode	= "spGetTrafficSearchByNationalcode";
		public const string		C_spGetTrafficSerachByPlate			= "spGetTrafficSerachByPlate";
														
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
		/// <summary>
		/// Load  Traffic
		/// </summary>
		/// <returns></returns>
		public CommandResult loadTraffic(DateTime startDate, DateTime endDate)
		{
			CommandResult result;
			result	= BaseDAL.DBaseHelper.executeCommand (BaseDAL.Base.EnumExecuteType.procedureReader, connection,C_spGetReportTraffic, true,
				new KeyValuePair ("@startDate", startDate),
				new KeyValuePair ("@endDate", endDate)
				);

			return result;
		}

		/// <summary>
		/// Load  Traffic by NationalCode
		/// </summary>
		/// <returns></returns>
		public CommandResult loadTrafficByNationalcode(DateTime startDate, DateTime endDate, string nationalcode)
		{
			CommandResult result;
			result	= BaseDAL.DBaseHelper.executeCommand (BaseDAL.Base.EnumExecuteType.procedureReader, connection,C_spGetReportTrafficByNationalcode, true,
				new KeyValuePair ("@startDate", startDate),
				new KeyValuePair ("@endDate", endDate),
				new KeyValuePair ("@nationalcode", nationalcode)
				);

			return result;
		}

		/// <summary>
		/// Load  Traffic by Plate
		/// </summary>
		/// <returns></returns>
		public CommandResult loadTrafficByPlate(DateTime startDate, DateTime endDate, string plate)
		{
			CommandResult result;
			result	= BaseDAL.DBaseHelper.executeCommand (BaseDAL.Base.EnumExecuteType.procedureReader, connection,C_spGetReportTrafficByPlate, true,
				new KeyValuePair ("@startDate", startDate),
				new KeyValuePair ("@endDate", endDate),
				new KeyValuePair ("@plate", plate)
				);

			return result;
		}

		/// <summary>
		/// Load  Traffic
		/// </summary>
		/// <returns></returns>
		public CommandResult loadViewTraffic()
		{
			CommandResult result;			

			string commandString = "SELECT *  from viewTraffic";
			result = BaseDAL.DBaseHelper.executeCommand(BaseDAL.Base.EnumExecuteType.reader, connection, commandString);					

			return result;
		}

		/// <summary>
		/// Search Owner By Nationalcode for Info Car
		/// </summary>
		/// <returns></returns>
		public CommandResult	searchTraffic(string nationalcode)
		{
			CommandResult result;
			
			result	= BaseDAL.DBaseHelper.executeCommand(BaseDAL.Base.EnumExecuteType.procedureReader,connection, C_spGetTrafficSearchByNationalcode, true,
				new KeyValuePair ("@nationalCode",		nationalcode)
				);			
	
			return result;
		}

		/// <summary>
		/// Search Owner By Nationalcode for Info Car
		/// </summary>
		/// <returns></returns>
		public CommandResult	searchTrafficByPlate(string plate)
		{
			CommandResult result;
			
			result	= BaseDAL.DBaseHelper.executeCommand(BaseDAL.Base.EnumExecuteType.procedureReader,connection, C_spGetTrafficSerachByPlate, true,
				new KeyValuePair ("@plate",		plate)
				);			
	
			return result;
		}
		#endregion
	}
}