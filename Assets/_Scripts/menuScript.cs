using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class menuScript : MonoBehaviour {

	[SerializeField]
	private Text text;

	private Button startButton;
	private Button exitButton;


	// Use this for initialization
	void Start () {
		text.color = Color.cyan;
		text.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
