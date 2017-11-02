using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelController : MonoBehaviour {
	public GameObject level1, level2, level3, level4, level5;
	private GameObject level2Child;
	int levelPassed;
	// Use this for initialization
	void Start () {
		levelPassed = PlayerPrefs.GetInt ("levelPassed");
		level2.GetComponent<BoxCollider> ().enabled = false;
		level3.GetComponent<BoxCollider> ().enabled = false;
		level4.GetComponent<BoxCollider> ().enabled = false;
		level5.GetComponent<BoxCollider> ().enabled = false;
		switch (levelPassed) {
		case 1:
			level1.transform.GetChild (1).gameObject.SetActive (true);
			level2.GetComponent<BoxCollider> ().enabled = true;
			level2.transform.GetChild (0).gameObject.SetActive (true);
			break;
		case 2:
			level1.transform.GetChild (1).gameObject.SetActive (true);
			level2.GetComponent<BoxCollider> ().enabled = true;
			level2.transform.GetChild (0).gameObject.SetActive (true);
			level2.transform.GetChild (1).gameObject.SetActive (true);
			level3.GetComponent<BoxCollider> ().enabled = true;
			level3.transform.GetChild (0).gameObject.SetActive (true);
			break;
		case 3:
			level1.transform.GetChild (1).gameObject.SetActive (true);
			level2.GetComponent<BoxCollider> ().enabled = true;
			level2.transform.GetChild (0).gameObject.SetActive (true);
			level2.transform.GetChild (1).gameObject.SetActive (true);
			level3.GetComponent<BoxCollider> ().enabled = true;
			level3.transform.GetChild (0).gameObject.SetActive (true);
			level3.transform.GetChild (1).gameObject.SetActive (true);
			level4.GetComponent<BoxCollider> ().enabled = true;
			level4.transform.GetChild (0).gameObject.SetActive (true);
			break;
		case 4:
			level1.transform.GetChild (1).gameObject.SetActive (true);
			level2.GetComponent<BoxCollider> ().enabled = true;
			level2.transform.GetChild (0).gameObject.SetActive (true);
			level2.transform.GetChild (1).gameObject.SetActive (true);
			level3.GetComponent<BoxCollider> ().enabled = true;
			level3.transform.GetChild (0).gameObject.SetActive (true);
			level1.transform.GetChild (1).gameObject.SetActive (true);
			level4.GetComponent<BoxCollider> ().enabled = true;
			level4.transform.GetChild (0).gameObject.SetActive (true);
			level4.transform.GetChild (1).gameObject.SetActive (true);
			level5.GetComponent<BoxCollider> ().enabled = true;
			level5.transform.GetChild (0).gameObject.SetActive (true);
			break;
		}
	}
	
	// Update is called once per frame
	void Update () {		
	}

	public void reset(){
		level1.transform.GetChild (1).gameObject.SetActive (false);
		level2.GetComponent<BoxCollider> ().enabled = false;
		level2.transform.GetChild (0).gameObject.SetActive (false);
		level2.transform.GetChild (1).gameObject.SetActive (false);
		level3.GetComponent<BoxCollider> ().enabled = false;
		level3.transform.GetChild (0).gameObject.SetActive (false);
		level3.transform.GetChild (1).gameObject.SetActive (false);
		level4.GetComponent<BoxCollider> ().enabled = false;
		level4.transform.GetChild (0).gameObject.SetActive (false);
		level4.transform.GetChild (1).gameObject.SetActive (false);
		level5.GetComponent<BoxCollider> ().enabled = false;
		level5.transform.GetChild (0).gameObject.SetActive (false);
		level5.transform.GetChild (1).gameObject.SetActive (false);
		PlayerPrefs.DeleteAll ();
	}
}
