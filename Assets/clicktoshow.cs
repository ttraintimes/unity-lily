using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clicktoshow : MonoBehaviour
{
   public GameObject collider;
   public void onMouseDown()
    {
        collider.SetActive(true);

    }
}
