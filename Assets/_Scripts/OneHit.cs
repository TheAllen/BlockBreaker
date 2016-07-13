using UnityEngine;
using System.Collections;

public class OneHit : MonoBehaviour {

	public Ball ball;

	void onCollisionEnter2D(Collision2D collide){
		print ("Hit");
		Destroy (this);
	}

	void OnTriggerEnter2D(Collider2D LoseCollider){
		print("Trigger");
		Destroy (gameObject);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
