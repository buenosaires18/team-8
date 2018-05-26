using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenProfile : MonoBehaviour {

	// Use this for initialization
	public GameObject studentProfile;
	public UserSaver uS;
    public DataBase dB;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void AddPoints(float points)
    {
        Student student = dB.studentList[uS.user.id];
        student.score += points;
    }
    public void OpenStudentProfile()
	{
		studentProfile.SetActive(true);
		studentProfile.SendMessage("SetUser", uS.user, SendMessageOptions.DontRequireReceiver);
	}
}
