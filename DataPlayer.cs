using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPlayer : MonoBehaviour
{
    public static DataPlayer Instanse;
    bool isDead = false;
    public int score = 0;
    public int hits = 0;
    public int seed;
    private void Awake()
    {
        Instanse = this;
    }
    private void Start()
    {
        score = 0;
        hits = 0;
    }
}
