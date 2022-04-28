using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pick : MonoBehaviour
{
    void OnMouseDown()
    {
      FindObjectOfType<flowerpick>().flower();
      gameObject.SetActive(false);

    }
}
