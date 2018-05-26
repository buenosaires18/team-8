using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserSaver : MonoBehaviour {

    public static User user;
	public void SetUser(User usr)
    {
        user = usr;
        Job.actuaUser = user;
        SendMessage("Activate", SendMessageOptions.DontRequireReceiver);
    }
}
