using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waitforsec : MonoBehaviour
{
    public GameObject objectToActivate;
 
     private void Start()
     {
         StartCoroutine(ActivationRoutine());
     }
 
     private IEnumerator ActivationRoutine()
     {        
         yield return new WaitForSeconds(3);

         objectToActivate.SetActive(true);
 
         yield return new WaitForSeconds(10);
 
         objectToActivate.SetActive(false);
     }
}
