using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StudentProfilManager : MonoBehaviour {

	public Text description;
	public Text name;

	public Image progressBar;
	public Image animal;
	public UserSaver uS;
	public DataBase dB;



	public Sprite[] animalsImages;

	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	public void Activate ()
	{
		Debug.Log (uS.user.id);
		Student student = dB.studentList[uS.user.id];

		name.text = student.name;
		string trabajo = "";
		string estudio = "";
		if (student.working)
		{
			trabajo = "Secretario-Fabregas";
		}
		if (student.studying) 
		{
			estudio = "Tecnicatura en Motores";
		}

		description.text = "e-mail: " + student.mail + "\n" + "Telefono: " + student.phone+
			"\n" + "Orientador: " + student.teacher + "\n" + "Anio" + student.year+ "\n" + "Perfil Linkedin: CarlosLinkedin"
			+ "\n" + "Trabajo: " + trabajo+ "\n" + "Estudio: " + estudio;

		progressBar.fillAmount = student.score / 100;
		var fill = progressBar.fillAmount;
		if (fill <= 0.25) 
		{
			animal.sprite = animalsImages [0];
			
		} else if (fill <= 0.5)
		{
			animal.sprite = animalsImages [1];

			
		} else if (fill <= 0.75)
		{
			animal.sprite = animalsImages [2];

		} else 
		{
			animal.sprite = animalsImages [3];

		}
		
	}
}
