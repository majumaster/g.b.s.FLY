using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] DataPlayer data;
    public float maxTime = 1;
    private float timer = 0;
    public GameObject pipe;
    public float height;
    int lvl = 0;
    int[] scoreToUnlock = { 5, 10, 15 };
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject newPipe = Instantiate(pipe);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (timer > maxTime)
        {
            GameObject newPipe = Instantiate(pipe);
            if (lvl == 2)
            {
                MovePipe movePipe = newPipe.GetComponent<MovePipe>();
                movePipe.highSpeed = Random.Range(-0.1f, 0.1f);
            }
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 10);
            timer = 0;
        }
        timer += Time.deltaTime;
        //level 2
        if (lvl == 0 && data.score > scoreToUnlock[lvl])
        {
            height += 0.5f;
            lvl ++;
        }
        //level 3
        if (lvl == 1 && data.score > scoreToUnlock[lvl])
        {
            height += 0.5f;
            lvl ++;
        }
    }
}
