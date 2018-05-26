using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JobManager : MonoBehaviour {

    public List<Job> jobs;
	void Start ()
    {

	}
	
	// Update is called once per frame
	
    public void Activate()
    {
        for (int i = 0; i < jobs.Count; i++)
        {
            jobs[i].CheckIfShow();
        }
    }
}
