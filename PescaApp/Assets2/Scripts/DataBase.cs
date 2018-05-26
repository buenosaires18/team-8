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
        for (int i = 0; i < auxUserList.Count; i++)
        {
            if (auxUserList[i].username == username)
            {
                return auxUserList[i];
            }
        }
        return null;
    }
}
