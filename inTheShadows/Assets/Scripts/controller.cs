using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class controller : MonoBehaviour {

	public static controller instance = null;
	private int sceneIndex, levelPassed;
	public GameObject activeObj;
	public GameObject deactiveObj;
	public Button menuButton;
	public Button nextLevelButton;

	// Use this for initialization
	void Start () {
		sceneIndex = SceneManager.GetActiveScene ().buildIndex;
		levelPassed = PlayerPrefs.GetInt ("levelPassed");
		Button btn = menuButton.GetComponent<Button> ();
		btn.onClick.AddListener (menuTaskOnClick);
		Button btn1 = nextLevelButton.GetComponent<Button> ();
		btn1.onClick.AddListener (nextLevelTaskOnClick);
	}
	void menuTaskOnClick(){
		SceneManager.LoadScene (0);
	}
	void nextLevelTaskOnClick(){
		SceneManager.LoadScene (sceneIndex + 1);
	}

	public void completed(){
		if (levelPassed < sceneIndex) {
			PlayerPrefs.SetInt ("levelPassed", sceneIndex);
		}
		//completion methods
		Invoke("loadCompletion", 0.5f);
	}

	void loadCompletion(){
		activeObj.SetActive (true);
		deactiveObj.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			SceneManager.LoadScene(0);
		}
	}
}