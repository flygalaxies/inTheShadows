using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ezRotation : MonoBehaviour {

	public GameObject controller;
	private bool isEntered = false;
	private bool isPressed = false;
	public int rotation = 100;
	public float winningY;
	private float deltaAngleY;
	public float leniancy;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (this.isEntered && !Input.GetMouseButton(0)) {			
		}
		else if (this.isEntered && Input.GetMouseButton(0)) {
			float axis = Input.GetAxis("Mouse X") * rotation * Time.deltaTime;
			this.isPressed = true;
			this.transform.Rotate(0, axis * -1, 0);
		}
		if (!Input.GetMouseButton(0)){
			this.isPressed = false;
			deltaAngleY = Mathf.DeltaAngle (winningY, transform.rotation.eulerAngles.y);
			if (Mathf.Abs(deltaAngleY) > 0 && Mathf.Abs(deltaAngleY) < leniancy){
				controller.GetComponent<controller> ().completed ();
			}
		}
	}

	void OnMouseEnter(){
		this.isEntered = true;
	}
	void OnMouseExit(){		
		if (this.isPressed == false) {
			this.isEntered = false;
		}
	}
}
