using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections.Generic;

public class KeyboardManager : MonoBehaviour
{
    public List<Button> buttons;

    public TextMeshProUGUI title;

    private Button button;

    private string text;

    protected void Awake()
    {
        var textComp = button.GetComponentInChildren<TextMeshProUGUI>();
        var key = textComp.text;

        foreach (var button in buttons)
        {
            button.onClick.AddListener(
                () => { OnKey(key); }
                );
        }
    }

    public void OnKey(string key)
    {
        Debug.Log(key);
    }



}