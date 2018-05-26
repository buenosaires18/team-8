using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Job : MonoBehaviour
{
    public List<Interests> neededInterests;
    public string jobName;
    public string jobPosition;
    public bool active;

    void Start()
    {
        this.gameObject.SetActive(active);
    }



	
}
