using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour {

	public int scene;
	private Vector3 size;
	void OnMouseEnter(){
		size = transform.localScale;
	}
	void OnMouseOver(){
		transform.localScale = new Vector3 (0.4f, 0.4f, 0.4f);
		if (Input.GetMouseButtonDown (0)) {
			LoadByIndex (scene);
		}
	}
	void OnMouseExit(){
		transform.localScale = size;
	}

	private void LoadByIndex(int sceneIndex){
		SceneManager.LoadScene (sceneIndex);
	}
}
