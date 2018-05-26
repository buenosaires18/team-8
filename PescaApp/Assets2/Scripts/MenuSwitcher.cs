using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MenuSwitcher : MonoBehaviour {

	public GameObject menu;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChangeActive()
	{
		menu.SetActive (!menu.activeSelf);
	}

}
