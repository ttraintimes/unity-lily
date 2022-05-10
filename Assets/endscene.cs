using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endscene : MonoBehaviour
{
    GameObject raycastedObj;
    ObjectInteraction referencedScript;
    public GameObject EndScene;

    [SerializeField] private int InteractionRange = 2;
    [SerializeField] private LayerMask scenetransitionLayer;

    // Update is called once per frame


    void Start()
    {
        EndScene.SetActive(false);
    }

    void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, out hit, InteractionRange, scenetransitionLayer.value))
        {
            if (hit.collider.CompareTag("end"))
            {
                EndScene.SetActive(true);
                raycastedObj = hit.collider.gameObject;
                referencedScript = raycastedObj.GetComponent<ObjectInteraction>();
                Time.timeScale = 0;
            }
        }
        else
        {
            EndScene.SetActive(false);
        }

    }
}
