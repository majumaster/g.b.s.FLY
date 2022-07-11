using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    [SerializeField] GameObject text;
    bool isStart = false;
    
    void Start()
    {
        Time.timeScale = 0f;
    }
    // Update is called once per frame
    void Update()
    {
        if (isStart == false)
        {
            if (Input.touchCount > 0 || Input.GetMouseButtonDown(0))
            {
                isStart = true;
                text.SetActive(false);
                Time.timeScale = 1f;
            }
        }
    }


}
