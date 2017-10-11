using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class selector : MonoBehaviour {

	public EventSystem eventSystem;
	public GameObject selectedObj;
	bool btnSelected;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxisRaw ("Vertical") != 0 && btnSelected == false) {
			eventSystem.SetSelectedGameObject (selectedObj);
			btnSelected = true;
		}
		
	}
	private void OnDisable(){
		btnSelected = false;
	}
}
