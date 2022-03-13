using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    GameObject raycastedObj;
    ObjectInteraction referencedScript;
    public Image crosshairNormal;
    public Image crosshairInteract;

    [SerializeField] private int InteractionRange = 10;
    [SerializeField] private LayerMask scenetransitionLayer;

    // Update is called once per frame


    void Start()
    {
        //gameObject.transform.GetChild(0).gameObject.SetActive(false);
        crosshairInteract.enabled = false;
    }

    void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, out hit, InteractionRange, scenetransitionLayer.value))
        {
            if (hit.collider.CompareTag("scenetransition"))
            {
                //gameObject.transform.GetChild(0).gameObject.SetActive(true);
                crosshairNormal.enabled = false;
                crosshairInteract.enabled = true;
                raycastedObj = hit.collider.gameObject;
                referencedScript = raycastedObj.GetComponent<ObjectInteraction>();

                if (Input.GetKeyDown("e") && (referencedScript != null))
                {
                    referencedScript.interact();
                    raycastedObj = null;
                    referencedScript = null;
                    raycastedObj = null;
                    //gameObject.transform.GetChild(0).gameObject.SetActive(false);
                }
            }
        }
        else
        {
            crosshairNormal.enabled = true;
            crosshairInteract.enabled = false;
            //gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }

    }
}
