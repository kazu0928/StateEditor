using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CUEngine;
using CUEngine.Pattern;

public class CommandSystem : StateBaseScriptMonoBehaviour
{
    float frameGrace = 0;
    [SerializeField]
    private float frameGraceValue;
    private void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 60;
        UpdateManager.Instance.AddUpdate(this);
    }
    public override void UpdateGame()
    {
        frameGrace --;
        if(frameGrace<0)
        {
            frameGrace = 0;
        }
    }
    //猶予フレームが切れたら戻る
    public bool OutGrace()
    {
        if(frameGrace<=0)
        {
            return true;
        }
        return false;
    }
    public void StartGrace()
    {
        frameGrace = frameGraceValue;
    }
    public bool Key1()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            return true;
        }
        return false;
    }
    public bool Key2()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            return true;
        }
        return false;
    }
    public bool Key3()
    {
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            return true;
        }
        return false;
    }
    public bool Key4()
    {
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            return true;
        }
        return false;
    }
    public bool Key5()
    {
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            return true;
        }
        return false;
    }
    public bool Key6()
    {
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            return true;
        }
        return false;
    }
    public bool Key7()
    {
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            return true;
        }
        return false;
    }
    public bool Key8()
    {
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            return true;
        }
        return false;
    }
    public bool Key9()
    {
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            return true;
        }
        return false;
    }

}
