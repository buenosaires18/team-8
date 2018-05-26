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
    private bool reset;
    public int saltear;

    // Use this for initialization
    void Start()
    {
        reset = false;
        YesAnswer();
    }
    private void Update()
    {
        if (reset)
        {
            if(answer== "Yes")
            {
                for (int i = 0; i < answerContainer.questions.Count - 1; i++)
                {
                    if (answerContainer.questions[i].activeSelf)
                    {
                        answerContainer.questions[i + 1].SetActive(true);
                        answerContainer.questions[i].SetActive(false);
                        i = answerContainer.questions.Count - 1;
                    }
                }
            }
            else
            {
                for (int i = 0; i < answerContainer.questions.Count - 1; i++)
                {
                    if (answerContainer.questions[i].activeSelf)
                    {
                        for (int j = i; j <= saltear; j++)
                        {
                            answerContainer.answer.Add("No contesto");
                        }
                        answerContainer.questions[i + saltear].SetActive(true);
                        answerContainer.questions[i].SetActive(false);
                        i = answerContainer.questions.Count - 1;
                    }
                }
            }
        }
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
    public void Work()
    {
        if (answer == "Yes")
        {
            answerContainer.student.working = true;
            answerContainer.student.score += 26;
        }
        else answerContainer.student.working = false;
        if (!reset)
        {
            reset = true;
            answerContainer.answer.Add(answer);
        }
    }
    public void Study()
    {
        if (answer == "Yes")
        {
            answerContainer.student.studying = true;
            answerContainer.student.score += 26;

        }
        else answerContainer.student.studying = false;
        if (!reset)
        {
            reset = true;
            answerContainer.answer.Add(answer);
        }
    }

}
