using System;
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

    public string CreateMessage()
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

        return message;
    }
}
