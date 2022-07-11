using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    //[SerializeField] GameObject options;
    bool isOnOptions = false;
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //OffOptions();

    }
    public void TryAgain()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //OffOptions();


    }
    public void BackToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
    /*
    public void Options()
    {
        if (isOnOptions == false)
        {
            options.SetActive(true);
            isOnOptions = true;
        }
        else
        {
            OffOptions();
        }

    }
    */
    public void ExitGame()
    {
        Application.Quit();
    }
    /*
    public void OffOptions()
    {
        isOnOptions = false;
        options.SetActive(false);
    }
    */
}
