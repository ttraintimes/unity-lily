using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class VolumeContrl : MonoBehaviour
{

    public Slider mySlider;
    public static float curVolume=-1;
    public AudioSource bgAS;
    public AudioSource effffAS;
    public AudioSource efffAS;
    public AudioSource effAS;
    public AudioSource efAS;

    private void Start()
    {
        Time.timeScale = 1;
      // mySlider=GameObject.FindWithTag("bgmusic");
        if (curVolume != -1)
        {
            bgAS.volume = curVolume;
            effffAS.volume = curVolume;
            efffAS.volume = curVolume;
            effAS.volume = curVolume;
            efAS.volume = curVolume;
            mySlider.value = curVolume;
        }

        UnityAction<float> bgVolume ;
        bgVolume = SetVolume;
        mySlider.onValueChanged.AddListener(bgVolume); 
    }
    void SetVolume(float nowValue)
    {
        effffAS.volume = nowValue;
        efffAS.volume = nowValue;
        effAS.volume = nowValue;
        efAS.volume = nowValue;
        bgAS.volume = nowValue;
        curVolume = nowValue;
    }
}
