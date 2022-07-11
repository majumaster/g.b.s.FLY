using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMenu : MonoBehaviour
{
    public static int score;

    public static int highscore;

    [SerializeField]Text text;

    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", highscore);
        text.text = "" + highscore;
    }

    
}
