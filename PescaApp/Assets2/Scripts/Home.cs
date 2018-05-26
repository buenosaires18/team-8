using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Home : MonoBehaviour {

	public GameObject perfil;
	public GameObject home;


	void Start () {
		
	}
	
	// Update is called once per frame
	public void ActivateHome()
	{
		perfil.SetActive (false);
		home.SetActive (true);
	}
}
