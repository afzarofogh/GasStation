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
		#region Methods
		/// <summary>
		/// Get Bytes
		/// </summary>
		/// <param name="data"></param>
		/// <param name="encoding"></param>
		/// <returns></returns>
		public static byte[] getBytes (this string data, Encoding encoding = null)
		{
			byte[] result;

			if (null == encoding)
				encoding    = System.Text.Encoding.UTF8;

			result  = encoding.GetBytes (data);

			return result;
		}

		/// <summary>
		/// Check for empty/null/white spaces string
		/// </summary>
		/// <param name="data"></param>
		/// <returns></returns>
		public static bool isNullOrEmptyOrWhiteSpaceOrLen (this string data, int len = 0)
		{
			bool result = false;

			result  = (data != null) && (data.Trim ().Length > 0);
			if (result && (len > 0))
				result  = result && (data.Length <= len);

			result  = !result;
			return result;
		}

		#endregion
	}
}
