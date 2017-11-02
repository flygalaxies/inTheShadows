using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class completion : MonoBehaviour {

	public GameObject obj1 = null;
	public GameObject obj2 = null;
	public GameObject controller;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if ((obj1.GetComponent<ggRotation> ().complete == true) && (obj2.GetComponent<ggRotation> ().complete == true)) {
			controller.GetComponent<controller> ().completed ();
		}
	}
}
