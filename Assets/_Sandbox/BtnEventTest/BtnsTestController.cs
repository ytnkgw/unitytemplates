using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnsTestController : MonoBehaviour
{
	[SerializeField]
	private ButtonEventController _btn1;
	[SerializeField]
	private ButtonEventController _btn2;
	[SerializeField]
	private ButtonEventController _btn3;


	private void OnClickBtn(string btnName)
	{
		Debug.Log("Clicked btn name : " + btnName);
	}


	private void OnEnable()
	{
		_btn1.OnClick += OnClickBtn;
		_btn2.OnClick += OnClickBtn;
		_btn3.OnClick += OnClickBtn;
	}

	private void OnDisable()
	{
		_btn1.OnClick -= OnClickBtn;
		_btn2.OnClick -= OnClickBtn;
		_btn3.OnClick -= OnClickBtn;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
