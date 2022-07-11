using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MixerController : MonoBehaviour
{
    [SerializeField] string musicParameter = "Music";
    [SerializeField] string efectsParameter = "Efects";
    [SerializeField] GameObject muteLine;
    [SerializeField] AudioSource AudioSource;
    public AudioMixer mixer;
    
    float isOn;
    float tmp;

    private void Start()
    {
        isOn = PlayerPrefs.GetFloat(musicParameter);//1-on 0-off
        if (isOn==0)
        {
            muteLine.SetActive(true);
            AudioSource.Stop();
        }
        else
        {
            muteLine.SetActive(false);
            AudioSource.Play();
        }
    }
    private void OnDisable()
    {
        PlayerPrefs.SetFloat(musicParameter, isOn);
        PlayerPrefs.SetFloat(efectsParameter, isOn);
    }
    public void ChangeLevels()
    {
        if (isOn == 1.0)
        {
            isOn = 0;
            muteLine.SetActive(true);
            AudioSource.Stop();
            //Debug.Log(isOn);
        }
        else
        {
            isOn = 1;
            muteLine.SetActive(false);
            AudioSource.Play();
        }
        //Debug.Log(PlayerPrefs.GetFloat(musicParameter));
        //PlayerPrefs.SetFloat(musicParameter, isOn);
       // PlayerPrefs.SetFloat(efectsParameter, isOn);
        //mixer.SetFloat(musicParameter, Mathf.Log10(PlayerPrefs.GetFloat(musicParameter)) * 20);
       // mixer.SetFloat(efectsParameter, Mathf.Log10(PlayerPrefs.GetFloat(efectsParameter)) * 20);
    }
}
