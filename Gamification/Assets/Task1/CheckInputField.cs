using TMPro;
using UnityEngine;

public class CheckInputField : MonoBehaviour
{
    private TMP_InputField _inputField;
    [SerializeField] private string rightVariant;

    private void Awake()
    {
        _inputField = GetComponent<TMP_InputField>();
    }

    public bool CheckAnswer()
    {
        return _inputField.text == rightVariant;
    }
}
