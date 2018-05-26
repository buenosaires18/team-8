using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginScreen : MonoBehaviour {

	public GameObject canvas;
	public InputField username;
	public InputField password;

	public bool fieldsCompleted;

	void Start ()
	{
		canvas.SetActive (true);
		fieldsCompleted = false;
	}
	

	void Update ()
	{
		if (username.text != null && password.text != null )
		{
			fieldsCompleted = true;
		}
	}
}
