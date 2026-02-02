using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void OnClickHome()
    {
        SceneManager.LoadScene("Menu");
    }

    public void OnClickStart()
    {
        SceneManager.LoadScene("UI_Scene");
    }

    public void OnClickTV()
    {
        SceneManager.LoadScene("TV_Scene");
    }

}
