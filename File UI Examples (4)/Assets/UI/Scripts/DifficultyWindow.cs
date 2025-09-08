using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class DifficultyWindow : GenericWindow
{
    public int index = 1;

    public ToggleGroup toggleGroup;
    public Toggle[] toggles;

    private void Start()
    {
        if (SaveLoadManager.Load())
        {
            toggles = SaveLoadManager.Data.toggles;
        }
    }

    public override void Open()
    {
        base.Open();
        //toggles[index].isOn = true;

        //for (int i = 0; i < toggles.Length; ++i)
        //{
        //    if (toggles[i].isOn)
        //    {
        //        toggles[i].isOn = SaveLoadManager.Data.toggles[i].isOn;
        //        break;
        //    }
        //}
    }


    public void OnClickEasy(bool value)
    {
        if (value)
        {
            Debug.Log("이지");

           SaveLoadManager.Data.toggles = toggles;

            SaveLoadManager.Save();
        }
    }

    public void OnClickNormal(bool value)
    {
        if (value)
        {
            Debug.Log("노말");

            SaveLoadManager.Data.toggles = toggles;
            SaveLoadManager.Save();
        }
    }

    public void OnClickHard(bool value)
    {
        if (value)
        {
            Debug.Log("하드");

            SaveLoadManager.Data.toggles = toggles;
            SaveLoadManager.Save();
        }
    }

}
