using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	private int max;
	private int min;
	private int guess;

	private int maxGuessAllow = 10;

	public Text text;

	// Use this for initialization
	void Start () {
		StartGame ();
	}

	void StartGame(){
		max = 1000;
		min = 1;
		guess = Random.Range (min, max + 1);
		NextGuess ();
	}

	public void GuessLower(){
		max = guess;
		NextGuess ();
	}

	public void GuessHigher(){
		min = guess;
		NextGuess ();
	}

	void NextGuess(){
		guess = Random.Range (min, max + 1);
		text.text = guess.ToString ();
		maxGuessAllow--;
		if (maxGuessAllow <= 0) {
			Application.LoadLevel ("Win");
		}
	}
	


}