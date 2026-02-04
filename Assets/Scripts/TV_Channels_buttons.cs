using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TV_Channels_buttons : MonoBehaviour
{
    public TMP_Text kanals;
    int currentKanals = 0;
    public GameObject[] KanaluPaneli;

    public GameObject togglePause;
    public Image PauseImg;

    public AudioSource musicSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Sākumā izslēdz visus kanālus, un ieslēdz pirmo kanālu.
        AtjaunoKanalu();
    }

    public void ButtonUp()
    {
        currentKanals++;

        // Ja esošais kanāls pārsniedz max kanālus, tad tas iet uz sākuma kanālu.
        if (currentKanals >= KanaluPaneli.Length)
            currentKanals = 0;

        // Atjauno tekstu uz jauno kanālu
        AtjaunoKanalu();
    }

    public void ButtonDown()
    {
        currentKanals--;

        // Ja esošais kanāls mazāks par 0, tad tas iet uz max kanālu.
        if (currentKanals < 0)
            currentKanals = KanaluPaneli.Length - 1;

        // Atjauno tekstu uz jauno kanālu
        AtjaunoKanalu();
    }

    // Metodi ko izsauc citas metodes, lai atjaunot tekstu un kanāla panelus
    void AtjaunoKanalu()
    {
        kanals.text = currentKanals.ToString();

        for(int i = 0;  i < KanaluPaneli.Length; i++)
        {
            KanaluPaneli[i].SetActive(false);
        }

        KanaluPaneli[currentKanals].SetActive(true);
    }

    public void TogglePause(bool value)
    {
        PauseImg.enabled = !value;

        if (togglePause.GetComponent<Toggle>().isOn)
        {
            if (musicSource.isPlaying)
                musicSource.Pause();
        }
        else
            musicSource.UnPause();

        
    }

}
