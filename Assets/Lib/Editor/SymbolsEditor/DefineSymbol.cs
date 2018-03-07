using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyLib.Editor.SymbolsEditor
{
	[System.Serializable]
	public class DefineSymbol
	{
		// ---------------------------------
		#region Public Properties
		// Symbol itself
		public string key
		{
			get { return _key; }
			set
			{
				if (_key != value) _edited = true;
				_key = value;
			}
		}

		// [SerializeField] // For debug use.
		private string _key;

		public bool enabled
		{
			get { return _enabled; }
			set
			{
				if (_enabled != value) _edited = true;
				_enabled = value;
			}
		}

		// [SerializeField] // For debug use.
		private bool _enabled;

		public bool edited { get { return _edited; } }

		// [SerializeField] // For debug use.
		private bool _edited = false;

		// Description to explain symbol
		//public string info
		//{
		//	get { return _info; }
		//}
		//private string _info;

		#endregion // Public Properties


		public DefineSymbol(string keyValue, bool isEnable, bool edited)
		{
			_key = keyValue;
			_enabled = isEnable;
			_edited = edited;
		}

		public void Save()
		{
			_edited = false;
		}
	}
}