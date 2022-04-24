using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Hitend : MonoBehaviour
{
    GameObject raycastedObj;
    ObjectInteraction referencedScript;
    public GameObject EndMenu;
    public UnityEvent onMenuAppear;

    [SerializeField] private int InteractionRange = 2;
    [SerializeField] private LayerMask scenetransitionLayer;

    // Update is called once per frame


    void Start()
    {
        EndMenu.SetActive(false);
    }

    void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, out hit, InteractionRange, scenetransitionLayer.value))
        {
            Time.timeScale = 0;
            if (hit.collider.CompareTag("scenetransition"))
            {
                EndMenu.SetActive(true);
                onMenuAppear.Invoke();
                raycastedObj = hit.collider.gameObject;
                referencedScript = raycastedObj.GetComponent<ObjectInteraction>();
                Cursor.visible = true;
                if (Input.GetKeyDown("e") && (referencedScript != null))
                {
                    referencedScript.interact();
                    raycastedObj = null;
                    referencedScript = null;
                    raycastedObj = null;
                }
            }
        }
        else
        {
            Time.timeScale = 1;
            EndMenu.SetActive(false);
        }

    }
}
