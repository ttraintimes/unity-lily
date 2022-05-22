using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class letterUI : MonoBehaviour
{
    GameObject raycastedObj;
    ObjectInteraction referencedScript;
    public GameObject letterScene;
    public UnityEvent onMenuAppear;
    public AudioSource LetterAudio;

    [SerializeField] private int InteractionRange = 2;
    [SerializeField] private LayerMask scenetransitionLayer;

    // Update is called once per frame


    void Start()
    {
        letterScene.SetActive(false);
    }

    void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, out hit, InteractionRange, scenetransitionLayer.value))
        {
            if (hit.collider.CompareTag("letter"))
            {
                letterScene.SetActive(true);
                LetterAudio.Play();
                onMenuAppear.Invoke();
                raycastedObj = hit.collider.gameObject;
                referencedScript = raycastedObj.GetComponent<ObjectInteraction>();
            }
        }
        else
        {
            letterScene.SetActive(false);
        }

    }
}
