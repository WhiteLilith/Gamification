using System;
using TMPro;
using UnityEngine;

public class TechCardChecker : MonoBehaviour
{
    [Serializable] struct InputField
    {
        public CheckInputField inputField;
        public string fieldName;
    }
    
    [Serializable] struct Dropdown
    {
        public CheckDropDown dropdown;
        public string fieldName;
    }

    [SerializeField] private InputField[] inputFields;
    [SerializeField] private Dropdown[] dropdowns;

    [SerializeField] private TextMeshProUGUI messageText;

    public void CreateMessage()
    {
        var message = "";
        
        foreach (var inputField in inputFields)
        {
            if (!inputField.inputField.CheckAnswer()) message += $"{inputField.fieldName}\n";
        }
        foreach (var dropdown in dropdowns)
        {
            if (!dropdown.dropdown.CheckAnswer()) message += $"{dropdown.fieldName}\n";
        }

        messageText.text = message;
    }

    public void CheckResult()
    {
        FindObjectOfType<Player>().ChangeScore(4, messageText.text == "" ? 12 : 6);
    }
}
