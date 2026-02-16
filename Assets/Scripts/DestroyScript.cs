using TMPro;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    SFX_Script sfx;
    public TMP_Text counterText;
    private int destroyedObjects = 0;

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
            destroyedObjects++;
            sfx.PlaySFX(4);
            counterText.text = "Objects Destroyed: " + destroyedObjects;
        }

        if (collision.CompareTag("Evil"))
        {
            Destroy(collision.gameObject);
            destroyedObjects++;
            sfx.PlaySFX(4);
            counterText.text = "Objects Destroyed: " + destroyedObjects;
        }
    }

}
