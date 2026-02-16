using UnityEngine;
using UnityEngine.EventSystems;

public class PogasHoverEfekts : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    // Publiskie float
    public float hoverIzmers = 1.1f;
    public float atrums = 10f;

    private Vector2 originalIzmers;
    private Vector2 targetIzmers;

    // Sākuma iestata oriģinālo izmēru
    void Start()
    {
        originalIzmers = transform.localScale;
        targetIzmers = originalIzmers;
    }

    // Katru frame izsauc Update metodo, lai notiktu šis hover efekts.
    void Update()
    {
        transform.localScale = Vector2.Lerp(
            transform.localScale,
            targetIzmers,
            Time.deltaTime * atrums
        );
    }

    // OnPointer metodes
    public void OnPointerEnter(PointerEventData eventData)
    {
        targetIzmers = originalIzmers * hoverIzmers;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        targetIzmers = originalIzmers;
    }
}
