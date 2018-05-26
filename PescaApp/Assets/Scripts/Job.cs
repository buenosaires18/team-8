using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Job : MonoBehaviour
{
    public List<Interests> neededInterests;
    public string jobName;
    public string jobPosition;
    public bool active;
    public static User actuaUser;
    public DataBase dB;
	public Text jobText;

	public GameObject image;
	public GameObject name;

    void Start()
    {
        this.gameObject.SetActive(active);
        dB = GameObject.Find("DataBase").GetComponent<DataBase>();
		jobText = GetComponent<Text> ();

		jobText.text = "Nueva oferta de trabajo" + "\n" + "Empresa: " + jobName + "\n" + "Puesto: " + jobPosition + "\n" + "Tiempo: Full";

    }
    public void CheckIfShow()
    {
        
        if (actuaUser.type == TypeUser.Student)
        {
            int i=0;
            int j = 0;
            bool check = true;
            while (i<neededInterests.Count && check)
            {
                j = 0;
                while (j < dB.studentList[actuaUser.id].interests.Count && check)
                {
                    if (dB.studentList[actuaUser.id].interests[j] == neededInterests[i])
                    {
                        check = false;
						this.gameObject.SetActive(true);
						image.SetActive (true);
						name.SetActive (true);
                        return;
                    }
                    j++;
                }
                i++;
            }
        }
        this.gameObject.SetActive(false);
		image.SetActive (false);
		name.SetActive (false);

    }


	
}
