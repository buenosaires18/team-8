using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StringQuestion : MonoBehaviour {

    public InputField inputTxt;
    public Quiz answerContainer;
    private bool reset;

	// Use this for initialization
	void Start ()
    {
        reset = false;
	}
	
	void Update () {
        if (reset)
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
	}
    public void Enter()
    {
        if (inputTxt.text != "" && !reset)
        {
            answerContainer.answer.Add(inputTxt.text);
            inputTxt.text = "";
            reset = true;

        }
    }
}
