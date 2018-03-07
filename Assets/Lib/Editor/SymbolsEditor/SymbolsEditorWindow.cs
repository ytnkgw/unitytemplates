using UnityEditor;
using UnityEditorInternal;
using UnityEngine;

namespace MyLib.Editor.SymbolsEditor
{
	public class SymbolsEditorWindow : EditorWindow
	{
		// ----------------------------
		#region Private valiables
		private SymbolsEditor _editor;

		private ReorderableList _reorderableList;

		private bool _edited = false;
		#endregion


		// ----------------------------
		#region EditorWindow Behavior
		private void OnEnable()
		{
			_editor = new SymbolsEditor();
			_edited = false;

			InitList();
		}

		private void OnGUI()
		{
			// Draw symbols list
			DrawList();
			DrawMessages();
			DrawSave();
		}
		#endregion


		// ----------------------------
		#region Draw Compopnent method

		// ----------------------------
		#region List
		// TODO : Add paddings.
		private void InitList()
		{
			_reorderableList = new ReorderableList(_editor.model.symbols, typeof(string));
			_reorderableList.headerHeight = 1.0f; // Set header size.
			_reorderableList.drawElementCallback = DrawListCell;
			_reorderableList.onAddCallback = OnClickAddBtn;
			_reorderableList.onRemoveCallback = OnClickRemoveBtn;
		}

		private void DrawList()
		{
			if (_reorderableList == null) InitList();
			_reorderableList.DoLayoutList();
		}

		private void DrawListCell(Rect rect, int index, bool isActive, bool isFocused)
		{
			EditorGUILayout.BeginHorizontal();

			// Add textbox.
			var textFieldRect = rect;
			textFieldRect.width -= 14.0f;
			_editor.model.symbols[index].key = EditorGUI.TextField(textFieldRect, _editor.model.symbols[index].key);
			// Add checkbox.
			var toggleRect = rect;
			toggleRect.width = 10.0f;
			toggleRect.height = 10.0f;
			var togglePos = new Vector2(rect.position.x + rect.width - 12.0f, rect.position.y);
			toggleRect.position = togglePos;
			_editor.model.symbols[index].enabled = EditorGUI.Toggle(toggleRect, _editor.model.symbols[index].enabled);

			EditorGUILayout.EndHorizontal();

			// Check edited status.
			if (_editor.model.symbols[index].edited) _edited = true;
		}

		private void OnClickAddBtn(ReorderableList targetList)
		{
			_editor.model.symbols.Add(new DefineSymbol("NEW_SYMBOL", false, true));
		}

		private void OnClickRemoveBtn(ReorderableList targetList)
		{
			// Remove cell.
			_editor.model.symbols.RemoveAt(targetList.index);
			_edited = true;
		}
		#endregion // List


		private void DrawMessages()
		{
			if (_edited)
			{
				EditorGUILayout.HelpBox(
					"Please click the Save button below to preserve all the changes.",
					MessageType.Warning);
			}
		}

		private void DrawSave()
		{
			if (GUILayout.Button("Save"))
			{
				_editor.Save();
				_edited = false;
			}
		}
		#endregion
	}
}