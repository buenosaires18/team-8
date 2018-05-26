using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{

    public GameObject questionsContainer;
    [HideInInspector]
    public List<string> answer = new List<string>();
    [HideInInspector]
    public List<GameObject> questions = new List<GameObject>();

    void Awake()
    {
        for (int i = 0; i < questionsContainer.GetComponentInChildren<Transform>().childCount; i++)
        {
            questions.Add(questionsContainer.GetComponentInChildren<Transform>().GetChild(i).gameObject);
        }
        questions[0].SetActive(true);
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
