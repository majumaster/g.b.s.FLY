using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyGBS : MonoBehaviour
{
    Animator mAnimator;
    public float velocity = 1;
    private Rigidbody2D rb;
    public bool isDead=false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        mAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mAnimator != null)
        {
            //dla komputera
            ///*
            if (!isDead &&Input.GetMouseButtonDown(0))
            {
                mAnimator.SetTrigger("isFlyUP2");
                rb.velocity = Vector2.up * velocity;
                //mAnimator.SetBool("isFlyUP", true);
                
            }

            //*/
            //dla telefonu
            /*
            if (!isDead && Input.touchCount > 0)
            {
                rb.velocity = Vector2.up * velocity;
                mAnimator.SetBool("isFlyUP", true);
            }
            //*/
        }

    }
}
