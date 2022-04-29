using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerflower : MonoBehaviour
{
    GameObject raycastedObj;
    public Text flowernum;

    [SerializeField] private int InteractionRange = 1;
    [SerializeField] private LayerMask flowerLayer;

    // Update is called once per frame


    void Start()
    {
        flowernum.enabled = false;
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
            //    raycastedObj = hit.collider.gameObject;
            }
        }
        else
        {
            flowernum.enabled = false;
        }

    }
}
