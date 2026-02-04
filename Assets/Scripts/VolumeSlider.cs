using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    public AudioSource audioS;
    public Slider volumeSlider;

    void Start()
    {
        // Seto skaņu, tādu kāds ir audio source skaņa
        volumeSlider.value = audioS.volume;

        volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    public void SetVolume(float value)
    {
        audioS.volume = value;
    }
}
