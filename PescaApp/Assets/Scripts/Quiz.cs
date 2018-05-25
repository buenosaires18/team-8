using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{

    private GameObject questions;
    public List<string> answer = new List<string>();

    void Awake()
    {

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            for (int i = 0; i < answer.Count; i++)
            {
                print(answer[i]);
            }
        }
    }
}
