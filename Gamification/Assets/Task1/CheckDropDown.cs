using TMPro;
using UnityEngine;

public class CheckDropDown : MonoBehaviour
{
    private TMP_Dropdown _dropdown;
    [SerializeField] private string rightVariant;

    private void Awake()
    {
        _dropdown = GetComponent<TMP_Dropdown>();
    }

    public bool CheckAnswer()
    {
        return _dropdown.options[_dropdown.value].text == rightVariant;
    }
    
    public bool CheckAnswer(string answer)
    {
        return _dropdown.options[_dropdown.value].text == answer;
    }
}