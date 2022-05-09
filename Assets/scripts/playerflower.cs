using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerflower : MonoBehaviour
{
    GameObject raycastedObj;
    public Text flowernum;
    public Image guide;
    public AudioSource BeachAudio;
    public AudioSource RainAudio;

    [SerializeField] private int InteractionRange = 2;
    [SerializeField] private LayerMask flowerLayer;

    // Update is called once per frame


    void Start()
    {
        flowernum.enabled = false;
        guide.enabled = false;
        
    }

    void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        
        if (Physics.Raycast(transform.position, fwd, out hit, InteractionRange, flowerLayer.value))
        {
            if (hit.collider.CompareTag("flower"))
            {
                flowernum.enabled = true;
                guide.enabled = true;
                raycastedObj = hit.collider.gameObject;
                StartCoroutine(ActivationRoutine());
            }
            if (hit.collider.CompareTag("beach"))
            {
                BeachAudio.Play();
            }
            if (hit.collider.CompareTag("rain"))
            {
                RainAudio.Play();
            }
        }
        else
        {
        //    flowernum.enabled = false;
        }

    }
    private IEnumerator ActivationRoutine()
     {        
         yield return new WaitForSeconds(10);
         guide.enabled = false;
     }
}
