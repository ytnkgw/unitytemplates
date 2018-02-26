using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;

namespace MyLib.Editor
{
	public class SymbolsEditorWindow : EditorWindow
	{
		// ---------------------------------------------
		#region Private valiables
		private ReorderableList _reorderableList;

		private bool _isToogleChecked = false;

		private List<string> _list = new List<string>() {"0", "1", "2", "3", "4"};
		#endregion


		// ---------------------------------------------
		#region EditorWindow Behavior
		private void OnEnable()
		{
			_reorderableList = new ReorderableList(_list, typeof(string));
			_reorderableList.headerHeight = 1.0f;
			_reorderableList.onAddCallback = (list) =>
			{
				_list.Add("New One");
			};
			_reorderableList.drawElementCallback = (rect, index, isActive, isFocused) =>
			{
				EditorGUILayout.BeginHorizontal();
				var textFieldRect = rect;
				textFieldRect.width -= 14.0f;
				_list[index] = EditorGUI.TextField(textFieldRect, _list[index]);
				var toggleRect = rect;
				toggleRect.width = 10.0f;
				toggleRect.height = 10.0f;
				//var togglePos = new Vector2(rect.position.x + rect.width - 12.0f, rect.position.y + ((rect.height - 10.0f) / 2));
				var togglePos = new Vector2(rect.position.x + rect.width - 12.0f, rect.position.y);
				toggleRect.position = togglePos;

				_isToogleChecked = EditorGUI.Toggle(toggleRect, _isToogleChecked);
				EditorGUILayout.EndHorizontal();
				//if (GUILayout.Button("Button " + element))
				//{
				//	Debug.Log("Tap Button " + element);
				//}
			};
		}

		private void OnGUI()
		{
			// Draw symbols list
			DrawList();
			DrawMessages();
			DrawSave();
		}
		#endregion


		// ---------------------------------------------
		#region Draw Compopnent method
		// TODO : Add paddings.
		private void DrawList()
		{
			//var windowRect = position;

			//var rect = new Rect();
			//rect.x = windowRect.x - 1.0f;
			//rect.y = windowRect.y;
			//rect.width = windowRect.width - 1.0f * 2.0f;
			//rect.height = windowRect.height;
			//_reorderableList.DoList(rect);

			//EditorGUILayout.BeginVertical("box");
			_reorderableList.DoLayoutList();
			//EditorGUILayout.EndVertical();
		}

		private void DrawMessages()
		{
			EditorGUILayout.HelpBox("Invalid symbol name", MessageType.Error);
		}

		private void DrawSave()
		{
			if (GUILayout.Button("Save"))
			{
				Debug.Log("click save btn.");
			}
		}
		#endregion
	}
}