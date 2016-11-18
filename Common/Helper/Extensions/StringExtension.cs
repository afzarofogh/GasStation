using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
	/// <summary>
	/// String Extension
	/// </summary>
	public static class StringExtension
	{
		/// <summary>
		/// Check for empty/null/white spaces string
		/// </summary>
		/// <param name="data"></param>
		/// <returns></returns>
		public static bool isNullOrEmptyOrWhiteSpaceOrLen (this string data, int len = 0)
		{ 
			bool result	= false;

			result	= (data != null) && (data.Trim ().Length > 0);
			if (result && (len > 0))
				result	= result && (data.Length <= len);

			result	= !result;
			return result;
		}
	}
}
