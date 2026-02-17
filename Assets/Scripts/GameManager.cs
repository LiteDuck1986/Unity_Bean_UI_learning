using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TubeMove tubeScript;
    public DonutBaker bakerScript;
    public GameObject startButton; // Start poga
    public TextMeshProUGUI timerText;

    private float time = 0f;
    private bool gameRunning = false;

    // Update is called once per frame
    void Update()
    {
        // restartēt spēli
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (gameRunning)
        {
            time += Time.deltaTime;
            timerText.text = "Time: " + time.ToString("F1") + "s"; // F1 ir numuru formāts lai būtu piemēram 12.3s
        }
    }

    // Sākt spēliti metode
    public void StartGame()
    {
        gameRunning = true;
        startButton.SetActive(false); // Paslēpj start pogu
        
        if(tubeScript != null) tubeScript.isGameActive = true;
        if(bakerScript != null) bakerScript.BakeDonut(true);
    }
}
