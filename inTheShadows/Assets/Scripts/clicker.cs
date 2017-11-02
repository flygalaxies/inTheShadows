using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class clicker : MonoBehaviour {

	//public EventSystem eventSystem;
	public GameObject object1;
	public GameObject object2;
	public AudioSource audio;
	bool btnSelected;
	public Button yourButton;

	// Use this for initialization
	void Start () {
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		this.object1.SetActive (false);
		this.object2.SetActive (true);
		audio.Play();
	}

	
	// Update is called once per frame
	void Update () {
//		if (Input.GetAxisRaw ("Vertical") != 0 && btnSelected == false) {
//			eventSystem.SetSelectedGameObject (selectedObj);
//			btnSelected = true;
//		}
		
	}
}
