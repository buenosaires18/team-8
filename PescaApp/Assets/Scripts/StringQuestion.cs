using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StringQuestion : MonoBehaviour {

    public InputField inputTxt;
    public Quiz answerContainer;

	// Use this for initialization
	void Start () {
		
	}
	
	void Update () {
		
	}
    public void Enter()
    {
        if (inputTxt.text != "")
        {
            answerContainer.answer.Add(inputTxt.text);
            inputTxt.text = "";
        }
    }
}
