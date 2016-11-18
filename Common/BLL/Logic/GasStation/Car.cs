using System;
using BaseDAL.Model;

namespace Common.BLL.Logic.GasStation
{
	public class Car : BaseBLL.Logic.Base<BLL.Entity.GasStation.Car>
	{
		public Car (object type) : base (type)
		{
		}
	}
}