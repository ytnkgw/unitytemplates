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
			SceneManager.sceneLoaded += OnSceneLoaded;
			SceneManager.sceneUnloaded += OnSceneUnloaded;
			SceneManager.activeSceneChanged += OnActiveSceneChanged;
		}

		private void OnDisable()
		{
			SceneManager.sceneLoaded -= OnSceneLoaded;
			SceneManager.sceneUnloaded -= OnSceneUnloaded;
			SceneManager.activeSceneChanged -= OnActiveSceneChanged;
		}

		private void Update()
		{
			// ---------------------------------
			#region TEST
#if TEST
			T_Update();
#endif
			#endregion
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

		// ---------------------------------
		#region TEST
#if TEST
		private enum T_SceneControlState : int
		{
			Load = 0,
			Unload = 1,
			Active = 2
		}

		private T_SceneControlState t_controlState;
		private T_SceneControlState T_ControlState
		{
			get
			{
				return t_controlState;
			}
			set
			{
				t_controlState = value;
				Debug.Log("[TEST] ControlState is now " + t_controlState.ToString());
			}
		}


		private void T_Update()
		{
			// Scene control.
			if (Input.GetKeyUp(KeyCode.Alpha1))
			{
				switch (T_ControlState)
				{
					case T_SceneControlState.Load:
						SceneManager.LoadScene(0, LoadSceneMode.Additive);
						break;
					case T_SceneControlState.Unload:
						SceneManager.UnloadSceneAsync(0);
						break;
					case T_SceneControlState.Active:
						//SceneManager.SetActiveScene();
						break;
				}
			}
			else if (Input.GetKeyUp(KeyCode.Alpha2))
			{
				switch (T_ControlState)
				{
					case T_SceneControlState.Load:
						SceneManager.LoadScene(1, LoadSceneMode.Additive);
						break;
					case T_SceneControlState.Unload:
						SceneManager.UnloadSceneAsync(1);
						break;
					case T_SceneControlState.Active:
						//SceneManager.SetActiveScene();
						break;
				}
			}
			else if (Input.GetKeyUp(KeyCode.Alpha3))
			{
				switch (T_ControlState)
				{
					case T_SceneControlState.Load:
						SceneManager.LoadScene(2, LoadSceneMode.Additive);
						break;
					case T_SceneControlState.Unload:
						SceneManager.UnloadSceneAsync(2);
						break;
					case T_SceneControlState.Active:
						//SceneManager.SetActiveScene();
						break;
				}
			}

			// Change scene control state.
			if (Input.GetKeyUp(KeyCode.L))
			{
				T_ControlState = T_SceneControlState.Load;
			}
			else if (Input.GetKeyUp(KeyCode.U))
			{
				T_ControlState = T_SceneControlState.Unload;
			}
			else if (Input.GetKeyUp(KeyCode.A))
			{
				T_ControlState = T_SceneControlState.Active;
			}
		}
#endif
		#endregion
	}
}