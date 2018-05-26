using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogInManager : MonoBehaviour {

    TypeUser _typeUser;
    string _username;
    string _password;

    public InputField _usernameField;
    public InputField _passwordField;

    public GameObject firstTimeLogIn;
    public GameObject normalLogIn;
    public GameObject orientatorLogIn;
    public GameObject adminLogIn;

    public DataBase dB;
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        _username = _usernameField.text;
        _password = _passwordField.text;
	}

    public void ChangeTypeOfUser(int typeUser)
    {
        switch (typeUser)
        {
            case 1:
                _typeUser = TypeUser.Student;
                break;
            case 2:
                _typeUser = TypeUser.Orientador;

                break;
            case 3:
                _typeUser = TypeUser.Admin;

                break;
        }
    }

    public void LogIn()
    {
		_usernameField.text = "";
		_passwordField.text = "";
        if(dB.LogIn(_username, _password, _typeUser) != null)
        {
            var sa = dB.LogIn(_username, _password, _typeUser);
            switch (_typeUser)
            {
                case TypeUser.Student:
                    if (dB.studentList[sa.id].fisrtTime)
                    {
                        if (firstTimeLogIn != null)
                        {
                            firstTimeLogIn.SetActive(true);
                            firstTimeLogIn.SendMessage("SetUser", sa, SendMessageOptions.DontRequireReceiver);
                        }
                    }
                    else
                    {
                        if (normalLogIn != null)
                        {
                            normalLogIn.SetActive(true);
                            normalLogIn.SendMessage("SetUser", sa, SendMessageOptions.DontRequireReceiver);
                        }


                    }
                    break;
                case TypeUser.Orientador:
                    if (orientatorLogIn != null)
                    {
                        orientatorLogIn.SetActive(true);
                        orientatorLogIn.SendMessage("SetUser", sa, SendMessageOptions.DontRequireReceiver);
                    }
                    break;
                case TypeUser.Admin:
                    if (adminLogIn != null)
                    {
                        adminLogIn.SetActive(true);
                        adminLogIn.SendMessage("SetUser", sa, SendMessageOptions.DontRequireReceiver);
                    }
                    break;
            }

            this.gameObject.SetActive(false);
        }


    }
}
