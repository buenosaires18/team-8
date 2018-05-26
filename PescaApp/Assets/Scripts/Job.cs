﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Job : MonoBehaviour
{
    public List<Interests> neededInterests;
    public string jobName;
    public string jobPosition;
    public bool active;
    public static User actuaUser;
    public DataBase dB;

    void Start()
    {
        this.gameObject.SetActive(active);
        dB = GameObject.Find("DataBase").GetComponent<DataBase>();
    }
    public void CheckIfShow()
    {
        
        if (actuaUser.type == TypeUser.Student)
        {
            int i=0;
            int j = 0;
            bool check = true;
            while (i<neededInterests.Count && check)
            {
                j = 0;
                while (j < dB.studentList[actuaUser.id].interests.Count && check)
                {
                    if (dB.studentList[actuaUser.id].interests[j] == neededInterests[i])
                    {
                        check = false;
                        return;
                    }
                    j++;
                }
                i++;
            }
        }
        this.gameObject.SetActive(false);
    }


	
}
