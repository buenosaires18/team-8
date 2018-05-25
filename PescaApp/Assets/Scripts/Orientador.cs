using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orientador : MonoBehaviour 
{
	public int id;
	public string name, mail, cellphone;

	public Orientador (int id, string name, string mail, string cellphone)
	{
		this.id = id;
		this.name = name;
		this.mail = mail;
		this.cellphone = cellphone;
	}

}
