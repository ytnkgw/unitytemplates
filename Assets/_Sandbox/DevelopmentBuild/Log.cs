using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Template.DevelopmentBuildTest
{
	public class Log : MonoBehaviour
	{
		private Coroutine _coroutine;

		private void OnEnable()
		{
			_coroutine = StartCoroutine(LogCoroutine());
		}

		private void OnDisable()
		{
			StopCoroutine(_coroutine);
		}

		private IEnumerator LogCoroutine()
		{
			while (true)
			{
				Debug.Log("[DevelopmentBuildTest] DeltaTime : " + Time.deltaTime);

				yield return new WaitForSeconds(1.0f);
			}
		}
	}
}