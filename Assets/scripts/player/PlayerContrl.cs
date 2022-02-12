using UnityEngine;
using System.Collections.Generic;
using System.Collections;

//Script for moving a gameObject smoothly
//Usage: Attach the character controller component to the gameobject that you want to move

namespace UnityLibary
{
    public class PlayerContrl : MonoBehaviour
    {
        // place the gameobject that you want to move to the controller placeholder
        public CharacterController controller;

        public float speed = 5f;

        void Update()
        {
           // float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

           // Vector3 move = transform.right * x + transform.forward * z;
            Vector3 move = transform.forward * z;

            controller.Move(move * speed * Time.deltaTime);

            //Rotate clockwise
            if (Input.GetKey(KeyCode.D))
            {
                transform.RotateAround(transform.position, Vector3.up, 60 * Time.deltaTime);
            }
            // Rotate anticlockwise
            if (Input.GetKey(KeyCode.A))
            {
                transform.RotateAround(transform.position, -Vector3.up, 60 * Time.deltaTime);
            }
             if (Input.GetKey(KeyCode.Q))
             {
                 transform.Rotate(Vector3.left, 10.0f * Time.deltaTime);
             }
             if (Input.GetKey(KeyCode.E))
             {
                 transform.Rotate(Vector3.right, 10.0f * Time.deltaTime);
             }
      

        }

    }
}