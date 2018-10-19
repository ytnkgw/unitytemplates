using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEventController : MonoBehaviour
{
	public delegate void BtnEvent(string btnName);
	public BtnEvent OnClick;

	private Button _btn;

	// Use this for initialization
	void Start () {
		_btn = GetComponent<Button>();
		
		_btn.onClick.AddListener(OnClickBtn);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnClickBtn()
	{
		if (OnClick != null)
		{
			OnClick(gameObject.name);
		}
	}
}
