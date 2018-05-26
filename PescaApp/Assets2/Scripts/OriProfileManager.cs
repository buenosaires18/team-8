using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OriProfileManager : MonoBehaviour {

	public Text description;
	public Text name;

	public Image progressBar;
	public Image animal;
	public UserSaver uS;
	public DataBase dB;

	public GameObject logMenu;

	public Sprite[] animalsImages;

	void Start () 
	{
	}

	// Update is called once per frame
	void Update () 
	{

	}

	public void LogOut()
	{
		logMenu.SetActive(true);
		this.gameObject.SetActive(false);
	}
	public void LoadData(Orientador orientador)
	{

		name.text = orientador.name;

		description.text = "e-mail: " + orientador.mail + "\n" + "Telefono: " + orientador.cellphone+ "\n" + "Perfil Linkedin: CarlosLinkedin";

	}
	public void Activate ()
	{
		Orientador orientator = dB.orientatorList[uS.user.id];

		LoadData (orientator);
	}
}
