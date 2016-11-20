using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
	/// <summary>
	/// JsonExtension
	/// </summary>
	public static class JsonExtension
	{
		/// <summary>
		/// To Model
		/// </summary>
		/// <param name="data"></param>
		/// <returns></returns>
		public static object toModel (this string data)
		{
			object result	= null;

			result	= Newtonsoft.Json.JsonConvert.DeserializeObject (data);

			return result;
		}

		/// <summary>
		/// To Json
		/// </summary>
		/// <param name="data"></param>
		/// <returns></returns>
		public static object toJson (this object data)
		{
			string result	= "";

			result	= Newtonsoft.Json.JsonConvert.SerializeObject (data);

			return result;
		}
	}
}
