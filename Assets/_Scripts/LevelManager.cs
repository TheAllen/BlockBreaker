using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name)
	{
		Debug.Log ("Level load requested for: " + name);
		Brick.breakableCount = 0;
		Application.LoadLevel(name);
	}

	public void QuitGame(string name){
		Debug.Log ("Level load requested for: " + name);
		Application.Quit ();
	}

	public void returnMenu(string name){
		Application.LoadLevel (name);
	}

	public void LoadNextLevel(){
		Brick.breakableCount = 0;
		Application.LoadLevel (Application.loadedLevel + 1);
		//loading the next level
	}

	public void BrickDestroyed(){
		if(Brick.breakableCount <= 0){
			LoadNextLevel ();
		}
	}
}
