using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedSpawner : MonoBehaviour
{
    [SerializeField] DataPlayer data;
    public float maxTime = 1;
    private float timer = 0;
    public GameObject seed;
    public float height;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newPipe = Instantiate(seed);
    }

    // Update is called once per frame
    void Update()
    {

        if (timer > maxTime)
        {
            GameObject newSeed = Instantiate(seed);
            newSeed.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newSeed, 10);
            timer = 0;
        }
        timer += Time.deltaTime;

    }
}
