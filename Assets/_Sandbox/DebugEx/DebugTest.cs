using MyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log(DebugEx.defaultLogPath);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.Space))
		{
			DebugEx.LogExport("Test Export");
		}
	}
}
