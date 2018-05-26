using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{
    public GameObject homeMenu;
    public Student student;
    public DataBase dB;
    public UserSaver usv;
    public GameObject questionsContainer;
    [HideInInspector]
    public List<string> answer = new List<string>();
    [HideInInspector]
    public List<GameObject> questions = new List<GameObject>();
    public List<Interests> interest = new List<Interests>();
    public bool working, studying;

    void Awake()
    {
        for (int i = 0; i < questionsContainer.GetComponentInChildren<Transform>().childCount; i++)
        {
            questions.Add(questionsContainer.GetComponentInChildren<Transform>().GetChild(i).gameObject);
        }
        questions[0].SetActive(true);
        usv = GetComponent<UserSaver>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            for (int i = 0; i < answer.Count; i++)
            {
                print(answer[i]);
            }
        }
    }
    public void Activate()
    {
        student = dB.studentList[usv.user.id];
    }
    public void SetStudentValues()
    {
        student.fisrtTime = false;
		student.satisfaction = answer [6];
        homeMenu.SetActive(true);
        homeMenu.SendMessage("SetUser", usv.user,SendMessageOptions.DontRequireReceiver);
        gameObject.SetActive(false);
    }
}
