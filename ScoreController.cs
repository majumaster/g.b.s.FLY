using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    DataPlayer dp;
    [SerializeField]Text scoreText;
    [SerializeField] Text seedText;
    public static int highscore;
    public static int seeds;
    void Start()
    {
        dp = GetComponent<DataPlayer>();
        highscore = PlayerPrefs.GetInt("highscore", highscore);
        seeds = PlayerPrefs.GetInt("seeds", seeds);
        dp.seed = seeds;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = ""+dp.score;
        if (dp.score > highscore)
        {
            highscore = dp.score;

            PlayerPrefs.SetInt("highscore", highscore);
        }
        if (dp.seed != seeds)
        {
            seeds = dp.seed;

            PlayerPrefs.SetInt("seeds", seeds);
        }
        seedText.text = "x" + dp.seed;


    }
}
