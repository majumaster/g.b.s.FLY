using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
    public float speed;
    public float highSpeed=0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        //Transform transform = GetComponentInChildren<Transform>();
        //transform.rotation = new Quaternion(0, 0, 1, 1);
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        transform.position += Vector3.up * highSpeed * Time.deltaTime;
        if (transform.position.y > 1.5 || transform.position.y<-1.5)
            highSpeed = -highSpeed;


    }
}
