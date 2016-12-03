using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace System
{
	/// <summary>
	/// Date Extension
	/// </summary>
	public static class DateExtension
	{
		#region Methods

		/// <summary>
		/// Check Birth Date
		/// </summary>
		/// <param name="data"></param>
		/// <param name="len"></param>
		/// <returns></returns>
		public static bool isBirthDate (this string data, int len = 0)
		{
			bool result = false;

			string myString = data; 
			DateTime birthday = DateTime.ParseExact(myString, "dd/MM/yyyy", CultureInfo.InvariantCulture);

			int year = birthday.Year;
			int month = birthday.Month;
			int day = birthday.Day;
			
			if (month > 0 && month < 13)
			{
				if (month > 0 && month < 7)
				{
					if (day > 0 && day < 32)
						result = true;						
				}
				else if (month > 6 && month < 13)
				{
					if (day > 0 && day < 31)
						result = true;						
				}
			}

			return result;
		}


		#endregion
	}
}
