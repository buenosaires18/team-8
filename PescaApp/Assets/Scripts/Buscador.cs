using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buscador : MonoBehaviour
{
	public GameObject menu;
	public InputField search;
	public Image[] images;
	public Text[] texts;

	void Start ()
	{
		images [0].enabled = false;
		texts [0].enabled = false;

		images [1].enabled = false;
		texts [1].enabled = false;
	}
	

	public void Search ()
	{
		if (search.text.ToLower() == "carlos")
		{
			images [0].enabled = true;
			texts [0].enabled = true;

			images [1].enabled = false;
			texts [1].enabled = false;
			return;
		}
	


		if (search.text.ToLower() == "sofia")
		{
			images [1].enabled = true;
			texts [1].enabled = true;	

			images [0].enabled = false;
			texts [0].enabled = false;
			return;

		}

		images [0].enabled = false;
		texts [0].enabled = false;

		images [1].enabled = false;
		texts [1].enabled = false;
	}

	public void ChangeActive()
	{
		menu.SetActive (!menu.activeSelf);
	}


}
