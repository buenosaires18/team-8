using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostJob : MonoBehaviour {

    public DataBase dB;
    public Job job;
    public UserSaver uS;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public bool PostAJob()
    {
        var student = dB.studentList[uS.user.id];
        int j = 0;
        for (int i = 0; i < job.neededInterests.Count; i++)
        {

            while (j < student.interests.Count)
            {
                if (student.interests[j] == job.neededInterests[i])
                {
                    j = student.interests.Count;
                    return true;
                }
                j++;
            }
        }

        return false;

    }
}
