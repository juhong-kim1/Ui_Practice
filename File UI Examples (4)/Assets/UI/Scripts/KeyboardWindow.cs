using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Text;
using TMPro;

public class KeyboardWindow : GenericWindow
{
    public List<Button> buttons;
    public TextMeshProUGUI inputDisplay;

    private StringBuilder textBuilder = new StringBuilder();

    protected void Awake()
    {
        foreach (var button in buttons)
        {
            var textComp = button.GetComponentInChildren<TextMeshProUGUI>();
            if (textComp != null)
            {
                string key = textComp.text;
                button.onClick.AddListener(() => OnKey(key));
            }
        }
    }

    public void OnKey(string key)
    {
        if (textBuilder.Length > 0)
        {
            textBuilder.Append(" ");
        }
        textBuilder.Append(key);
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        inputDisplay.text = textBuilder.ToString();
    }
}
