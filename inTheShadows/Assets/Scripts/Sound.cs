using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour {

	public Slider slider;
	// Use this for initialization
	void Start () {
		AudioListener.volume = slider.value;
		slider.onValueChanged.AddListener (delegate {valueChanged();});
	}
	
	// Update is called once per frame
	void Update () {
	}

	void valueChanged(){
		AudioListener.volume = slider.value;
	}
}
