using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	static MusicPlayer music = null;

	void Awake(){
		Debug.Log ("Music Player Awake " + GetInstanceID());
		if (music != null) {
			Destroy (gameObject);
			print ("Duplicate Music Player self-destructing.");
		} else {
			music = this; // the static variable is set to the instance of the class
			//GameObject.DontDestroyOnLoad (gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		Debug.Log ("Music Player Start " + GetInstanceID());
	}

	// Update is called once per frame
	void Update () {
	
	}
}
