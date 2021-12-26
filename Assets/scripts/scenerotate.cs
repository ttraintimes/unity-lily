using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach this script to a GameObject to rotate around the target position.
public class scenerotate : MonoBehaviour
{
    //Assign a GameObject in the Inspector to rotate around
    public GameObject target;

    void Update()
    {
        // Spin the object around the target at 1 degree/second.
        transform.RotateAround(target.transform.position, Vector3.up, Time.deltaTime);
    }
}
