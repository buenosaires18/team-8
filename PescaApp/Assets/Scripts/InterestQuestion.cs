using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterestQuestion : MonoBehaviour
{
    public Quiz answerContainer;
    public Image tecButton;
    public Image maButton;
    public Image adButton;

    private List<Interests> interests;
    private bool tecnology;
    private bool fisicalWork;
    private bool administration;

    // Use this for initialization
    void Start ()
    {
        tecButton.color = Color.white;
        maButton.color = Color.white;
        adButton.color = Color.white;
        tecnology = false;
        administration = false;
        fisicalWork = false;
		
	}
	
	// Update is called once per frame
	void Update ()
    {

	}
    public void Tecnology()
    {
        tecnology = !tecnology;
        if (tecnology) tecButton.color = Color.red;
        else tecButton.color = Color.white;
    }
    public void FisicalWork()
    {
        fisicalWork = !fisicalWork;
        if (fisicalWork) maButton.color = Color.red;
        else maButton.color = Color.white;
    }
    public void Administration()
    {
        administration = !administration;
        if (administration) adButton.color = Color.red;
        else adButton.color = Color.white;
    }
    public void Enter()
    {
        if (tecnology) answerContainer.student.interests.Add(Interests.Tecnology);
        if (fisicalWork) answerContainer.student.interests.Add(Interests.FisicalWork);
        if (administration) answerContainer.student.interests.Add(Interests.Administration);
		answerContainer.student.fisrtTime = false;
    }
}
