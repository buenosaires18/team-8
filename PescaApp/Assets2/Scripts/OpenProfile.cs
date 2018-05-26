using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenProfile : MonoBehaviour {

	// Use this for initialization
	public GameObject studentProfile;
	public GameObject oriProfile;
	public UserSaver uS;
    public DataBase dB;
	public Buscador button;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void AddPoints(float points)
    {
		Debug.Log (5);
        Student student = dB.studentList[uS.user.id];

        student.score += points;
    }
    public void OpenStudentProfile()
	{
		button.images [0].enabled = false;
		button.texts [0].enabled = false;

		button.images [1].enabled = false;
		button.texts [1].enabled = false;
		button.texts[2].enabled = false;


		button.search.text = "";
		button.menu.SetActive (false);
		studentProfile.SetActive(true);

		studentProfile.SendMessage("SetUser", uS.user, SendMessageOptions.DontRequireReceiver);
	}

	public void OpenOrientatorProfile()
	{
		button.images [0].enabled = false;
		button.texts [0].enabled = false;

		button.images [1].enabled = false;
		button.texts [1].enabled = false;
		button.texts[2].enabled = false;


		button.search.text = "";
		button.menu.SetActive (false);
		oriProfile.SetActive (true);
		oriProfile.SendMessage("SetUser", uS.user, SendMessageOptions.DontRequireReceiver);
	}
}
