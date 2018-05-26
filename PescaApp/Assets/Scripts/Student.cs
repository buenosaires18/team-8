using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Student : MonoBehaviour
{

    public int id, year;
	public float score;
    public bool fisrtTime,working,studying;
    public string name, mail, phone, teacher, job, knowlage, satisfaction;
    public List<Interests> interests;


    public Student(int id,string name, string mail, string phone, string teacher, int year, string job, string knowlage, List<Interests> interest)
    {
        this.id = id;
        this.year = year;
        this.name = name;
        this.mail = mail;
        this.phone = phone;
        this.teacher = teacher;
        this.job = job;
        this.knowlage = knowlage;
        this.interests = interest;
    }
}
