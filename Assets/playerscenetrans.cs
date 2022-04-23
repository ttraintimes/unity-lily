using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerscenetrans : MonoBehaviour
{
    GameObject raycastedObj;
    ObjectInteraction referencedScript;
    public Image enterE;

    [SerializeField] private int InteractionRange = 2;
    [SerializeField] private LayerMask scenetransitionLayer;

    // Update is called once per frame


    void Start()
    {
        //gameObject.transform.GetChild(0).gameObject.SetActive(false);
        enterE.enabled = false;
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
                enterE.enabled = true;
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
            enterE.enabled = false;
            //gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }

    }
}
