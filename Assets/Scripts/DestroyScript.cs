using TMPro;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    SFX_Script sfx;
    public TMP_Text counterText;
    private int destroyedDonuts = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sfx = FindFirstObjectByType<SFX_Script>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Donut"))
        {
            Destroy(collision.gameObject);
            destroyedDonuts++;
            sfx.PlaySFX(2);
            counterText.text = "Donuts Destroyed:\n" + destroyedDonuts;
        }
    }

}
