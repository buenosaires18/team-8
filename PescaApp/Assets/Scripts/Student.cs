﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Student : MonoBehaviour
{

    public int id, year;
    public bool fisrtTime;
    public string name, mail, phone, teacher, job, knowlage, interest;


    public Student(int id,string name, string mail, string phone, string teacher, int year, string job, string knowlage, string interest)
    {
        this.id = id;
        this.year = year;
        this.name = name;
        this.mail = mail;
        this.phone = phone;
        this.teacher = teacher;
        this.job = job;
        this.knowlage = knowlage;
        this.interest = interest;
    }
}
