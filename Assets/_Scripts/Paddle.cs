using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	public bool autoPlay;
	private Ball ball;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!autoPlay) {
			MoveWithMouse ();
		} else {
			AutoPlay ();
		}

	}

	void AutoPlay(){
		ball = GameObject.FindObjectOfType<Ball>();
		//print (ball.transform.position.x);
		this.transform.position = new Vector3 (ball.transform.position.x, 0.5f, 0f);

	}

	void MoveWithMouse(){
		Vector3 paddlePos = new Vector3 (0.5f, this.transform.position.y, 0f);
		float mousePauseBlocksX = Input.mousePosition.x / Screen.width * 16;
		//float mousePauseBlocksY = Input.mousePosition.y / Screen.height * 12;
		paddlePos.x = Mathf.Clamp(mousePauseBlocksX, 0.5f, 15.5f);
		this.transform.position = paddlePos;
	}
}
