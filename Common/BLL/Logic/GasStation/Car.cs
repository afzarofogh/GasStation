using System;
using BaseDAL.Model;

namespace Common.BLL.Logic.GasStation
{
	public class Car : BaseBLL.Logic.Base<BLL.Entity.GasStation.Car>
	{
		#region Constants
		public const string C_spOwnerCarPlateSave = "spOwnerCarPlateSave";
		#endregion

		#region Methods
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="type"></param>
		public Car (object type) : base (type)
		{
		}

		#endregion
		#region Custom Methods

		public CommandResult saveData (Common.BLL.Entity.GasStation.Owner ownerModel, Common.BLL.Entity.GasStation.Car carModel, Common.BLL.Entity.GasStation.Plate plateModel, Common.BLL.Entity.GasStation.LegalOwner legalOwnerModel)
		{
			CommandResult result;

			if (null != ownerModel && null != carModel && null != plateModel)

				result = BaseDAL.DBaseHelper.executeCommand (BaseDAL.Base.EnumExecuteType.procedureReader, connection, C_spOwnerCarPlateSave, true,
					new KeyValuePair ("@nationalCode",		ownerModel.nationalCode),
					new KeyValuePair ("@name",				ownerModel.name),
					new KeyValuePair ("@lastname",			ownerModel.lastname),
					new KeyValuePair ("@birthdate",			ownerModel.birthdate),
					new KeyValuePair ("@birthdatelocal",	ownerModel.birthdatelocal),
					new KeyValuePair ("@gen", 				ownerModel.gen)
					);
			else
				result = CommandResult.makeNullDataResult ();

			return result;
		}

		#endregion
	}
}