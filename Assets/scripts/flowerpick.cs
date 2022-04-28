using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class flowerpick : MonoBehaviour
{
    public Text flowernum;
    [HideInInspector]
    public  int n=0;
    [HideInInspector]
    
    public void flower()
    {
        n++;
        flowernum.text = n+" picked";
    }
}
