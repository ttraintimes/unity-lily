using UnityEngine;
using System.Collections.Generic;
using System.Collections;

//Script for moving a gameObject smoothly
//Usage: Attach the character controller component to the gameobject that you want to move
//Souce: https://stackoverflow.com/questions/62391105/how-to-add-jump-in-c-sharp-script-in-unity3d-using-character-controller
namespace UnityLibary
{
    public class PlayerContrl : MonoBehaviour
    {
        // place the gameobject that you want to move to the controller placeholder
        public CharacterController controller;

        public float speed = 5f;
    //    public float jumpSpeed = 2.0f;
 public float gravity = 5.0f;
 private Vector3 movingDirection = Vector3.zero;

        void Update()
        {
         //   if (controller.isGrounded && Input.GetButton("Jump")) {
             if (controller.isGrounded) {
        // movingDirection.y = jumpSpeed;
         movingDirection.y = 1.0f;
     }
     movingDirection.y -= gravity * Time.deltaTime;
     controller.Move(movingDirection * Time.deltaTime);


           // float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

           // Vector3 move = transform.right * x + transform.forward * z;
            Vector3 move = transform.forward * z;

            controller.Move(move * speed * Time.deltaTime);

            //Rotate clockwise
            if (Input.GetKey(KeyCode.D))
            {
                transform.RotateAround(transform.position, Vector3.up, 20 * Time.deltaTime);
            }
            // Rotate anticlockwise
            if (Input.GetKey(KeyCode.A))
            {
                transform.RotateAround(transform.position, -Vector3.up, 20 * Time.deltaTime);
            }
             if (Input.GetKey(KeyCode.Q))
             {
                 transform.Rotate(Vector3.left, 3.0f * Time.deltaTime);
             }
             if (Input.GetKey(KeyCode.Z))
             {
                 transform.Rotate(Vector3.right, 3.0f * Time.deltaTime);
             }
      

        }

    }
}