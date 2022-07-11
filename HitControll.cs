using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class HitControll : MonoBehaviour
{
    public GameObject deadCanvas;
    public GameObject stayAliveCanvas;
    FlyGBS fly;
    [SerializeField] DataPlayer data;
    public Text scoreText;
    public Text costToLife;
    public Collision2D pipe;
    private void Start()
    {
        fly = GetComponent<FlyGBS>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "ScoreHitBox")
        {
            data.score++;
            //Debug.Log(data.score);
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Pipe")
        {
            int costToLife_ = Pow(2 ,data.hits);
            Debug.Log(costToLife_);
            if (data.seed >= costToLife_)
            {
                Time.timeScale = 0f;
                pipe = collision;
                costToLife.text = "x" + costToLife_;
                stayAliveCanvas.SetActive(true);

            }
            else
            {
                Dead();
            }
            

        }
        if (collision.transform.tag == "Ground")
            Dead();


    }
    public void StayAlive()
    {
        data.seed-= Pow(2, data.hits);
        data.hits++;
        Destroy(pipe.gameObject);
        stayAliveCanvas.SetActive(false);
        Time.timeScale = 1f;

    }
    public void EndRun()
    {
        stayAliveCanvas.SetActive(false);
        Dead();
    }
    void Dead()
    {
        deadCanvas.SetActive(true);
        scoreText.text = "You Score: " + data.score;
        //Debug.Log("dead");
        fly.isDead = true;
        Time.timeScale = 0f;
    }
    int Pow(int x,int y)
    {
        if (y==0)
        {
            return 1;
        }
        if (y == 1)
        {
            return x;
        }
        for (int i = 1; i < y; i++)
            x *= x;
        return x;
    }
    
}
