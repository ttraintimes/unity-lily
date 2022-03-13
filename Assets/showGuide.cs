using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showGuide : MonoBehaviour
{
    //GameObject raycastedObj;
    ObjectInteraction referencedScript;

    [SerializeField] private int InteractionRange = 10;
    [SerializeField] private LayerMask scenetransitionLayer;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, out hit, InteractionRange, scenetransitionLayer.value))
        {
            if (hit.collider.CompareTag("scenetransition"))
            {
                gameObject.transform.GetChild(0).gameObject.SetActive(true);
               if (Input.GetKeyDown("e") && (referencedScript != null))
                {
                    gameObject.transform.GetChild(0).gameObject.SetActive(false);
                }
            }
        }
        else
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }

    }
}
