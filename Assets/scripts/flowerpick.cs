using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class flowerpick : MonoBehaviour
{
    public AudioSource TipAudio;
    public GameObject inflower;
    public Text flowernum;
    [HideInInspector]
    public  int n=0;
    [HideInInspector]
    
    void Start()
    {
        inflower.SetActive(false);
    }
    public void flower()
    {
        n++;
        TipAudio.Play();
        flowernum.text = n+" picked";
        inflower.SetActive(true);
    }
}
