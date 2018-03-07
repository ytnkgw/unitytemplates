using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyLib.Editor.SymbolsEditor
{
	public class SymbolsModel : ScriptableObject
	{
		private List<DefineSymbol> _symbols;
		public List<DefineSymbol> symbols
		{
			get { return _symbols; }
			set { _symbols = value; }
		}
	}
}