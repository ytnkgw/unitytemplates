using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Template.DesignPatterns.ScenesChain
{
	/*
	 * TODO : Editor extension.
	 * Set scenes extruct from PlayerSettings.
	 */
	public class SceneInterface : MonoBehaviour
	{
		private Scene _scene02;
		private Scene _scene03;

		// ---------------------------------
		#region MonoBehavior functions
		private void Awake()
		{
		}

		private void OnEnable()
		{
			SceneManager.activeSceneChanged += OnActiveSceneChanged;
			SceneManager.sceneLoaded += OnSceneLoaded;
			SceneManager.sceneUnloaded += OnSceneUnloaded;
		}

		private void OnDisable()
		{
			SceneManager.activeSceneChanged -= OnActiveSceneChanged;
			SceneManager.sceneLoaded -= OnSceneLoaded;
			SceneManager.sceneUnloaded -= OnSceneUnloaded;
		}

		private void Update()
		{
#if DEBUG_TEST
			// ---------------------------------
			#region TEST
			if (Input.GetKeyUp(KeyCode.Alpha1))
			{
				SceneManager.LoadScene(1, LoadSceneMode.Additive);
			}
			else if (Input.GetKeyUp(KeyCode.Alpha2))
			{
				SceneManager.LoadScene(2, LoadSceneMode.Additive);
			}
			#endregion
#endif
		}
		#endregion // MonoBehavior functions

		// ---------------------------------
		#region SceneManager Events
		private void OnActiveSceneChanged(Scene preScene, Scene nextScene)
		{
			Debug.Log("[OnActiveSceneChanged] preScene : " + preScene.name + ", nextScene : " + nextScene.name);
		}

		private void OnSceneLoaded(Scene loadedScene, LoadSceneMode mode)
		{
			Debug.Log("[OnSceneLoaded] Scene Name : " + loadedScene.name + ", Mode : " + mode.ToString());
		}

		private void OnSceneUnloaded(Scene unloadedScene)
		{
			Debug.Log("[OnSceneUnloaded] Scene Name : " + unloadedScene.name);
		}
		#endregion // SceneManager events

#if DEBUG_TEST
		// ---------------------------------
		#region TEST
		//private bool t_

		#endregion
#endif
	}
}