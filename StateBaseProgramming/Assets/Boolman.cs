using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CUEngine;
using CUEngine.Pattern;

public class Boolman : StateBaseScriptMonoBehaviour
{
    [SerializeField]
    public Boolman boolman;
	[SerializeField]
	char t;
	[SerializeField]
	int a = 0;


    public bool boolmanGod()
	{
        if (Input.GetKeyDown(KeyCode.A))
        {
			Debug.Log((name));
            return true;
        }
        return false;
	}
    public bool boolmanA()
    {
        //if (GetKeyboardValue.DownKeyCheck() == "a")
        //{
        //    return true;
        //}
        return false;
    }

    public void aae()
	{
		a++;
	}

}
