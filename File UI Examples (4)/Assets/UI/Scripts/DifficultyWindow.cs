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
            for (int i = 0; i < toggles.Length && i < SaveLoadManager.Data.toggleStates.Length; i++)
            {
                toggles[i].isOn = SaveLoadManager.Data.toggleStates[i];
            }
        }
    }

    public override void Open()
    {
        base.Open();
        for (int i = 0; i < toggles.Length && i < SaveLoadManager.Data.toggleStates.Length; i++)
        {
            toggles[i].isOn = SaveLoadManager.Data.toggleStates[i];
        }
    }

    private void SaveToggleStates()
    {
        for (int i = 0; i < toggles.Length && i < SaveLoadManager.Data.toggleStates.Length; i++)
        {
            SaveLoadManager.Data.toggleStates[i] = toggles[i].isOn;
        }
    }

    public void OnClickEasy(bool value)
    {
        if (value)
        {
            Debug.Log("이지");
            SaveToggleStates();
        }
    }

    public void OnClickNormal(bool value)
    {
        if (value)
        {
            Debug.Log("노말");
            SaveToggleStates();
        }
    }

    public void OnClickHard(bool value)
    {
        if (value)
        {
            Debug.Log("하드");
            SaveToggleStates();
        }
    }

    public void OnClickBack()
    {
        SaveLoadManager.Save();
        manager.Open(Windows.Start);
    }
}