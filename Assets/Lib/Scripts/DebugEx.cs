/*
 * DebugEx is for logging message to mainly external file beside logging to unity console.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace MyLib
{
	public static class DebugEx
	{
		private static readonly string NEW_LINE_CODE = "\r\n";

		public static string defaultLogPath
		{
			get
			{
				var defaultLogDir = Application.streamingAssetsPath + "/Log";
				if (!Directory.Exists(defaultLogDir))
					Directory.CreateDirectory(defaultLogDir);

				var path = defaultLogDir + "/" + DateTime.Today.ToString("yyyy-MM-dd") + ".txt";

				return path;
			}
		}


		public static void LogExport(string message, string path = "")
		{
			path = (string.IsNullOrEmpty(path)) ? defaultLogPath : path;
			message = 
				DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + NEW_LINE_CODE + 
				message + NEW_LINE_CODE + NEW_LINE_CODE;

			// TODO :: Find better way not to waste resource. 
			// ISSUE :: Everr time write line, it creates StreamWriter.
			var sw = new StreamWriter(path, true);
			try
			{
				sw.Write(message);
			}
			catch (Exception e)
			{
				Debug.LogAssertion(e.Message);
			}
			finally
			{
				sw.Close();
				sw = null;
			}
			
			Debug.Log(message);
		}
	}
}