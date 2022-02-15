using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour {

	[SerializeField] Camera camera1; 
	[SerializeField] Camera camera2; 
	[SerializeField] Camera camera3; 
    [SerializeField] Camera camera4; 
	[SerializeField] Camera camera5; 

private bool switchCam = false;
private bool planet1Cam = false;
private bool planet2Cam = false;
private bool planet3Cam = false;
private bool planet4Cam = false;
private int camSelect;

	void Start(){ 
		camSelect = 1;
		camera1.GetComponent<Camera>().enabled = true; 
		camera2.GetComponent<Camera>().enabled = false; 
		camera3.GetComponent<Camera>().enabled = false; 
        camera4.GetComponent<Camera>().enabled = false; 
		camera5.GetComponent<Camera>().enabled = false; 


	} 

	void Update() { 
		if (Input.GetKey(KeyCode.P)) {
			camera2.GetComponent<Camera>().enabled = false;
switchCam = !switchCam; 
planet1Cam = false; 
planet2Cam = false; 
planet3Cam = false;
planet4Cam = false;
			camSelect = 1;


		} 

		if (Input.GetKey(KeyCode.O)){
			camera1.GetComponent<Camera>().enabled = false; 
switchCam = false;
planet1Cam = true; 
planet2Cam = false; 
planet3Cam = false;
planet4Cam = false;
			camSelect = 2;

		} 
        if (Input.GetKey(KeyCode.I)){
			camera1.GetComponent<Camera>().enabled = false; 
switchCam = false;
planet1Cam = false; 
planet2Cam = true; 
planet3Cam = false;
planet4Cam = false;
			camSelect = 3;

		} 
        if (Input.GetKey(KeyCode.U)){
			camera1.GetComponent<Camera>().enabled = false; 
switchCam = false;
planet1Cam = false; 
planet2Cam = false; 
planet3Cam = true;
planet4Cam = false;
			camSelect = 4;

		} 
         if (Input.GetKey(KeyCode.Y)){
			camera1.GetComponent<Camera>().enabled = false; 
switchCam = false;
planet1Cam = false; 
planet2Cam = false; 
planet3Cam = false;
planet4Cam = true;
			camSelect = 5;

		} 
			

		if (switchCam == true) {
			camera1.GetComponent<Camera>().enabled = true; 
			camera2.GetComponent<Camera>().enabled = false;
			camera3.GetComponent<Camera>().enabled = false;
            camera4.GetComponent<Camera>().enabled = false;
			camera5.GetComponent<Camera>().enabled = false;
		} 
		if (planet1Cam == true) {
			camera1.GetComponent<Camera>().enabled = false; 
			camera2.GetComponent<Camera>().enabled = true; 
			camera3.GetComponent<Camera>().enabled = false; 
            camera4.GetComponent<Camera>().enabled = false;
			camera5.GetComponent<Camera>().enabled = false;
		} 

		if (planet2Cam == true) {
			camera1.GetComponent<Camera>().enabled = false; 
			camera2.GetComponent<Camera>().enabled = false; 
			camera3.GetComponent<Camera>().enabled = true; 
            camera4.GetComponent<Camera>().enabled = false;
			camera5.GetComponent<Camera>().enabled = false;

		} 
        if (planet3Cam == true) {
			camera1.GetComponent<Camera>().enabled = false; 
			camera2.GetComponent<Camera>().enabled = false; 
			camera3.GetComponent<Camera>().enabled = false; 
            camera4.GetComponent<Camera>().enabled = true;
			camera5.GetComponent<Camera>().enabled = false;

		} 
        if (planet4Cam == true) {
			camera1.GetComponent<Camera>().enabled = false; 
			camera2.GetComponent<Camera>().enabled = false; 
			camera3.GetComponent<Camera>().enabled = false; 
            camera4.GetComponent<Camera>().enabled = false;
			camera5.GetComponent<Camera>().enabled = true;

		} 


		else { 
			camera1.GetComponent<Camera>().enabled = true; 
			camera2.GetComponent<Camera>().enabled = false;
			camera3.GetComponent<Camera>().enabled = false; 
            camera4.GetComponent<Camera>().enabled = false;
			camera5.GetComponent<Camera>().enabled = false;

		} 
	}


}