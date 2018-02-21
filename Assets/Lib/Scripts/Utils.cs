using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MyLib
{
	public static class Utils
	{
        /*
         * Return queries in URI with Dictionary type.
         */
		public static Dictionary<string, string> ParseQueryString(string queryStr)
		{
			Dictionary<string, string> queryDic = new Dictionary<string, string>();

			// Remove url part
			if (queryStr.Contains("?"))
			{
				queryStr = queryStr.Substring(queryStr.IndexOf('?')+ 1);
			}

			foreach (string pair in Regex.Split(queryStr, "&"))
			{
				string[] pairArr = Regex.Split(pair, "=");
				if (pairArr.Length == 2)
				{
					queryDic.Add(pairArr[0], pairArr[1]);
				}
				else
				{
					queryDic.Add(pairArr[0], string.Empty);
				}
			}

			return queryDic;
		}
	}
}