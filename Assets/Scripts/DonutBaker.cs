using System.Collections;
using UnityEngine;

public class DonutBaker : MonoBehaviour
{
    public GameObject[] donutPrefabs;
    public float bakeInterval = 1.2f;
    float minPoz, maxPoz;
    Transform ovenTransform;
    public float offset = 0.7f;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ovenTransform = GetComponent<Transform>(); // uzzinam kur atrodas oven objekts, kur mes spawnosim donut objektus.
    }

    public void BakeDonut(bool state)
    {
        if (state) 
            StartCoroutine(Bake());

        else
            StopAllCoroutines();
    }

    IEnumerator Bake()
    {
        while(true)
        {
            minPoz = ovenTransform.position.x - offset;
            maxPoz = ovenTransform.position.x + offset;
            float randPoz = Random.Range(minPoz, maxPoz);
            Vector2 spawnPoz = new Vector2(randPoz, ovenTransform.position.y);

            int donutIndex = Random.Range(0, donutPrefabs.Length);
            Instantiate(donutPrefabs[donutIndex], spawnPoz, Quaternion.identity, ovenTransform);
            yield return new WaitForSeconds(bakeInterval);
        }
    }
}
