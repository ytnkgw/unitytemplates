using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyLib.Editor
{
	public class DefineSymbol
	{
		private const string SYMBOL_INFO_SAVE_KEY_FORMAT = "SymbolInfoKeyFor{0}";

		#region Public Properties
		// Symbol itself
		public string key
		{
			get { return _key; }
		}

		private string _key;

		// Description to explain symbol
		public string info
		{
			get { return _info; }
		}

		private string _info;

		public bool isEnabled
		{
			get { return _isEnabled; }
		}

		private bool _isEnabled = true;
		#endregion


		public DefineSymbol(string keyValue, bool isEnableFlag)
		{
			_key = keyValue;
			_isEnabled = isEnableFlag;
		}


		public void Save()
		{

		}

		public void Edit()
		{

		}

		public void DeleteInfo()
		{

		}

		#region Private methods
		private string GetSymbolInfoSaveKey(string symbol)
		{
			return string.Format(SYMBOL_INFO_SAVE_KEY_FORMAT, symbol);
		}
		#endregion
	}
}