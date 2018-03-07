using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace MyLib.Editor.SymbolsEditor
{
	public class SymbolsEditor
	{
		public static readonly char SYMBOL_SEPARATOR = ';';
		private static readonly string DATA_ASSET_NAME = "SymbolsModel";

		/*
		 * FIXME : Use automatic refarence.
		 * This still has a rick when user changed directionary structure.
		 */
		private static readonly string DATA_ASSET_PATH = "Assets/Lib/Editor/SymbolsEditor/Resources";

		public SymbolsModel model
		{
			get { return _model; }
		}

		private SymbolsModel _model = null;


		// ----------------------------
		#region Public methods
		// Constructor
		public SymbolsEditor()
		{
			/*
			 * QESTION : I don't know "Resources" directory is best in this case.
			 * Maybe I don't have to use "Resources" to load this scriptable object.
			 */
			_model = Resources.Load<SymbolsModel>(DATA_ASSET_NAME);

			// Create new scriptable asset in Resources folder of SymbolsEditor.
			if (_model == null)
			{
				Debug.Log("[MyLib.Editor.SymbolsEditor] New SymbolsData.asset was created in Resources directory.");
				_model = ScriptableObject.CreateInstance<SymbolsModel>();
				var assetPath = DATA_ASSET_PATH + "/" + DATA_ASSET_NAME + ".asset";

				AssetDatabase.CreateAsset(_model, assetPath);
				AssetDatabase.SaveAssets();
			}

			SyncWithPlayerSettings();
		}

		[MenuItem("Window/Symbols Editor")]
		public static void Open()
		{
			EditorWindow.GetWindow(typeof(SymbolsEditorWindow), false, "Symbols Editor");
		}

		public static string[] GetDefineSymbols()
		{
			var buildTarget = EditorUserBuildSettings.selectedBuildTargetGroup;
			return PlayerSettings.GetScriptingDefineSymbolsForGroup(buildTarget).Split(new[] { SYMBOL_SEPARATOR }, System.StringSplitOptions.None);
		}

		public List<string> GetModelSymbolsList()
		{
			List<string> list = new List<string>();
			foreach (var symbol in _model.symbols)
			{
				list.Add(symbol.key);
			}
			return list;
		}

		public void Save()
		{
			SaveToModel();
			SaveToPlayerSettings(_model.symbols);
		}
		#endregion // Public methods


		// ----------------------------
		#region Private methods
		// Sync Editor list with Scripting Define Symbols on PlayerSettings.
		private void SyncWithPlayerSettings()
		{
			var defineSymbols = GetDefineSymbols();
			var modelSymbols = GetModelSymbolsList();

			// Find unlisted define symbol on Symbols Editor list. 
			// And add it.
			foreach (var defineSymbol in defineSymbols)
			{
				if (!modelSymbols.Contains(defineSymbol) && !string.IsNullOrEmpty(defineSymbol))
				{
					_model.symbols.Add(new DefineSymbol(defineSymbol, true, false));
				}
			}

			SaveToModel();
		}

		private void SaveToModel()
		{
			// Preserve Symbols Editor list.
			foreach (var symbol in _model.symbols)
			{
				symbol.Save();
			}
			EditorUtility.SetDirty(_model);
			AssetDatabase.SaveAssets();
		}

		private void SaveToPlayerSettings(List<DefineSymbol> symbols)
		{
			var symbolsStr = string.Empty;
			foreach (var symbol in symbols)
			{
				if (symbol.enabled)
				{
					symbolsStr += string.IsNullOrEmpty(symbolsStr) ? symbol.key : ";" + symbol.key;
				}
			}
			var buildTarget = EditorUserBuildSettings.selectedBuildTargetGroup;
			PlayerSettings.SetScriptingDefineSymbolsForGroup(buildTarget, symbolsStr);
		}
		#endregion // Private methods
	}
}