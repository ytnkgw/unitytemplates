using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace MyLib.Editor
{
	public class SymbolsEditor
	{
		[MenuItem("Window/Symbols Editor")]
		public static void Open()
		{
			EditorWindow.GetWindow(typeof(SymbolsEditorWindow), false, "Symbols Editor");
		}
	}
}