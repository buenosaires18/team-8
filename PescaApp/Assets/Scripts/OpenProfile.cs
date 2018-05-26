using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenProfile : MonoBehaviour {

	// Use this for initialization
	public GameObject studentProfile;
	public UserSaver uS;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OpenStudentProfile()
	{
		studentProfile.SetActive(true);
		studentProfile.SendMessage("SetUser", uS.user, SendMessageOptions.DontRequireReceiver);
	}
}
