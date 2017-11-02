using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class medRotation : MonoBehaviour {

	public GameObject controller;
	private bool isEntered = false;
	private bool isPressed = false;
	public int rotation = 0;
	//public float translation = 0;
	public float winningX;
	private float deltaAngleX;
	public float winningY;
	private float deltaAngleY;
	public float leniancy;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		
		if (this.isEntered && Input.GetMouseButton (0) && !(Input.GetKey (KeyCode.LeftShift))) {
			float axis = Input.GetAxis ("Mouse X") * rotation * Time.deltaTime;
			this.isPressed = true;
			this.transform.Rotate (0, axis * -1, 0);
			Quaternion q = transform.rotation;
			q.eulerAngles = new Vector3 (q.eulerAngles.x, q.eulerAngles.y, 0);
			transform.rotation = q;
		} else if (this.isEntered && Input.GetMouseButton (0) && Input.GetKey (KeyCode.LeftShift)) {
			float axis = Input.GetAxis ("Mouse Y") * rotation * Time.deltaTime;
			this.isPressed = true;
			this.transform.Rotate (axis * 1, 0, 0);
			Quaternion q = transform.rotation;
			q.eulerAngles = new Vector3 (q.eulerAngles.x, q.eulerAngles.y, 0);
			transform.rotation = q;
		}

		if (!Input.GetMouseButton(0)){
			this.isPressed = false;
			deltaAngleY = Mathf.DeltaAngle (winningY, transform.rotation.eulerAngles.y);
			deltaAngleX = Mathf.DeltaAngle (winningX, transform.rotation.eulerAngles.x);
			if ((Mathf.Abs(deltaAngleY) > 0 && Mathf.Abs(deltaAngleY) < leniancy) && Mathf.Abs(deltaAngleX) > 0 && Mathf.Abs(deltaAngleX) < leniancy){
				controller.GetComponent<controller> ().completed ();
				//Debug.Log ("Winner");
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
