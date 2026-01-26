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
    }


}
