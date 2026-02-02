using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GetName : MonoBehaviour
{
    private string text;
    private string[] input = {"Sveiks", "Jauku dienu", "Prieks tevi redzēt", "Uzredzēšanos", "Jauki, ka atnāci", "Tiksimies rīt"};
    private int rand;
    public TMP_InputField inputField;
    public TMP_Text textField;
    public GameObject reverseTextToggle;

    public void GetText()
    {
        rand = Random.Range(0, input.Length);
        text = inputField.GetComponent<TMP_InputField>().text;
        textField.GetComponent<TMP_Text>().text = input[rand] + " " + text + "!";

        if (inputField.GetComponent<TMP_InputField>().text == "")
        {
            text = "User";
            textField.GetComponent<TMP_Text>().text = input[rand] + " " + text + "!";
        }

        reverseTextToggle.GetComponent<Toggle>().interactable = true;

        if (reverseTextToggle.GetComponent<Toggle>().isOn)
        {
            ReverseText();
        }
    }

    public void ReverseText()
    {
        char[] charArray = textField.GetComponent<TMP_Text>().text.ToCharArray();
        System.Array.Reverse(charArray);
        textField.GetComponent<TMP_Text>().text = new string(charArray);
    }


}
