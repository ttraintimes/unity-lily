using UnityEngine;
using System.Collections.Generic;
using System.Collections;

//Script for moving a gameObject smoothly
//Usage: Attach the character controller component to the gameobject that you want to move
//Souce: https://stackoverflow.com/questions/62391105/how-to-add-jump-in-c-sharp-script-in-unity3d-using-character-controller
//Souce: https://github.com/fiqryq/Unity-Switch-Camera/blob/main/switchViewCam.cs

namespace UnityLibary {
    public class PlayerContrl : MonoBehaviour {

    [SerializeField]
    Camera firstCamera;
    [SerializeField]
    Camera secondCamera;
    [SerializeField]
    Camera thirdCamera;

    // Inisialisasi State
    private bool switchCam = false;
    private bool backCam = false;
    // Start is called before the first frame update
    //
        public CharacterController controller;

        public float speed=7f;
        // public float jumpSpeed = 2.0f;
        public float gravity=5.0f;
        private Vector3 movingDirection=Vector3.zero;

        void Start()
        {
        firstCamera.GetComponent<Camera>().enabled = false;
        secondCamera.GetComponent<Camera>().enabled = true;
        thirdCamera.GetComponent<Camera>().enabled = false;
        }
        void Update() {
            // Input Key
        if (Input.GetKeyDown("t")) {
            switchCam = !switchCam;
            backCam = false;
        }

        if (Input.GetKeyDown("b")) {
            switchCam = false;
            backCam = true;
        }

        if(switchCam == true){
            firstCamera.GetComponent<Camera>().enabled = true;
            secondCamera.GetComponent<Camera>().enabled = false;
            thirdCamera.GetComponent<Camera>().enabled = false;
        } else if (backCam == true){
            firstCamera.GetComponent<Camera>().enabled = false;
            secondCamera.GetComponent<Camera>().enabled = false;
            thirdCamera.GetComponent<Camera>().enabled = true;
        } else {
            firstCamera.GetComponent<Camera>().enabled = false;
            secondCamera.GetComponent<Camera>().enabled = true;
            thirdCamera.GetComponent<Camera>().enabled = false;
        }
        //
            if (Input.GetKey(KeyCode.LeftShift)) {
                speed=14f;
            }
            else {
                speed=7f;
            }

            if (controller.isGrounded) {
                // movingDirection.y = jumpSpeed;
                movingDirection.y=1.0f;
            }

            movingDirection.y -=gravity * Time.deltaTime;
            controller.Move(movingDirection * Time.deltaTime);

            float z=Input.GetAxis("Vertical");
            Vector3 move=transform.forward * z;

            controller.Move(move * speed * Time.deltaTime);

            if (Input.GetKey(KeyCode.D)) {
                transform.RotateAround(transform.position, Vector3.up, 50 * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.A)) {
                transform.RotateAround(transform.position, -Vector3.up, 50 * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.Q)) {
                transform.Rotate(Vector3.left, 3.0f * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.Z)) {
                transform.Rotate(Vector3.right, 3.0f * Time.deltaTime);
            }


        }

    }
}