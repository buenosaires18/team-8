using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBase : MonoBehaviour {

	int studentId;
    int orientatorId;
    public List<Student> studentList;
    public List<Orientador> orientatorList;
    public List<User> usersOrientador;
    public List<User> usersStudent;
    public List<User> usersAdmin;

    void Start ()
    {
	}
	
	void Update ()
    {
		
	}


    public User LogIn(string username,string password , TypeUser type)
    {
        List<User> auxUserList = new List<User>();
        switch (type)
        {
            case TypeUser.Student:
                auxUserList = usersStudent;
                break;
            case TypeUser.Orientador:
                auxUserList = usersOrientador;
                break;
            case TypeUser.Admin:
                auxUserList = usersAdmin;
                break;
        }
        bool finished = true;
        int i = 0;
        while (finished)
        {
            if (auxUserList[i].username == username)
            {
                finished = false;
                return auxUserList[i];
            }
            i++;
        }
        return null;
    }
}
