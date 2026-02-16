using UnityEngine;

public class TubeMove : MonoBehaviour
{
    public float minX = -5f; // Kreisais limits
    public float maxX = 5f; // labais limits

    public float minSpeed = 2f; // Min speed
    public float maxSpeed = 8f; // Max speed

    private float targetX;
    private float moveSpeed;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetNewTarget();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(targetX, transform.position.y, transform.position.z), moveSpeed * Time.deltaTime);

        if (Mathf.Abs(transform.position.x - targetX) < 0.1f)
        {
            SetNewTarget();
        }
    }

    void SetNewTarget()
    {
        targetX = Random.Range(minX, maxX);
        moveSpeed = Random.Range(minSpeed, maxSpeed);
    }
}
