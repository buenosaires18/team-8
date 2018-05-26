using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogInManager : MonoBehaviour {

    TypeUser _typeUser;
    string _username;
    string _password;

    public GameObject firstTimeLogIn;
    public GameObject normalLogIn;
    public GameObject orientatorLogIn;
    public GameObject adminLogIn;

    public DataBase dB;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeTypeOfUser(TypeUser typeUser)
    {
        _typeUser = typeUser;
    }

    public void LogIn()
    {
        var sa = dB.LogIn(_username, _password, _typeUser);

        switch (_typeUser)
        {
            case TypeUser.Student:
                if (dB.studentList[sa.id].fisrtTime)
                {
                    firstTimeLogIn.SetActive(true);
                    firstTimeLogIn.SendMessage("SetUser", sa.id, SendMessageOptions.DontRequireReceiver);
                }
                else
                {
                    normalLogIn.SetActive(true);
                    normalLogIn.SendMessage("SetUser", sa.id, SendMessageOptions.DontRequireReceiver);


                }
                break;
            case TypeUser.Orientador:
                orientatorLogIn.SetActive(true);
                orientatorLogIn.SendMessage("SetUser", sa.id, SendMessageOptions.DontRequireReceiver);
                break;
            case TypeUser.Admin:
                adminLogIn.SetActive(true);
                adminLogIn.SendMessage("SetUser", sa.id, SendMessageOptions.DontRequireReceiver);
                break;
        }

        this.gameObject.SetActive(false);

    }
}
