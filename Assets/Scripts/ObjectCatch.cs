using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectCatch : MonoBehaviour
{
    public float sizeIncrease = 0.5f;
    public float massIncrease = 1f;

    public float sizeDecrease = 0.5f;
    public float massDecrease = 1f;

    private Rigidbody2D rb;
    SFX_Script sfx;

    public TMP_Text eatenCounterText;
    private int eatenDonuts = 0;

    public TMP_Text HPCount;
    private int Health = 3;

    private bool GameEnded = false;

    void Start()
    {
        sfx = FindFirstObjectByType<SFX_Script>();
        rb = GetComponent<Rigidbody2D>();

        HPCount.text = "HP: " + Health;
        eatenCounterText.text = "Score: 0";
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.IsChildOf(transform))
            return;

        if(collision.CompareTag("Donut"))
        {
            sfx.PlaySFX(3);
            Destroy(collision.gameObject);
            eatenDonuts++;
            transform.localScale += new Vector3(sizeIncrease, sizeIncrease, 0);
            rb.mass += massIncrease;
            eatenCounterText.text = "Score: " + eatenDonuts;
        }

        if (collision.CompareTag("Evil"))
        {
            sfx.PlaySFX(5);
            Destroy(collision.gameObject);

            Health--;
            HPCount.text = "HP: " + Health;

            transform.localScale -= new Vector3(sizeDecrease, sizeDecrease, 0);
            rb.mass -= massDecrease;
            
            // Pārbauda vai spēlētājs vel ir dzīvs, pēc HP zaudēšanas, ja ir 0 tad restartē ainu
            if (Health <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}
