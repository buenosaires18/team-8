using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoolQuest : MonoBehaviour
{
  
    public Quiz answerContainer;
    public Image yes;
    public Image no;
    private string answer;

    // Use this for initialization
    void Start()
    {
        YesAnswer();
    }
    public void YesAnswer()
    {
        yes.color = Color.red;
        no.color = Color.white;
        answer = "Yes";
    }
    public void NoAnswer()
    {
        answer = "No";
        yes.color = Color.white;
        no.color = Color.red;
    }
    public void Enter()
    {
        answerContainer.answer.Add(answer);
    }

}
