using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
	public Sprite[] hitSprites;
	public AudioClip crack;
	public static int breakableCount = 0;
	public GameObject smoke;

	private int maxHits;
	private int timesHit;
	private LevelManager levelManager;
	private bool isBreakable;

	// Use this for initialization
	void Start () {
		isBreakable = (this.tag == "breakable");
		//keep track of breakable
		if (isBreakable) {
			breakableCount++;
			//print (breakableCount);
		}
		timesHit = 0;
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
		//smoke = GameObject.FindObjectOfType<GameObject> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D col){
		AudioSource.PlayClipAtPoint (crack, transform.position);
		if (isBreakable) {
			HandleHit ();
		}
	}

	void HandleHit(){
		timesHit++;
		maxHits = hitSprites.Length + 1;
		if (timesHit >= maxHits) {
			breakableCount--;
			print(breakableCount);
			GameObject smokePuff = Instantiate (smoke, transform.position, Quaternion.identity) as GameObject;
			smokePuff.GetComponent<ParticleSystem>().startColor = gameObject.GetComponent<SpriteRenderer> ().color;
			levelManager.BrickDestroyed();
			Destroy (gameObject);
		} else {
			LoadSprites ();
		}
	}

	void LoadSprites(){
		int spriteIndex = timesHit - 1;
		if (hitSprites [spriteIndex] != null) {
			this.GetComponent<SpriteRenderer> ().sprite = hitSprites [spriteIndex];
		} else {
			Debug.LogError ("Brick sprites missing");
		}
	}

	void SimulateWin(){
		levelManager.LoadNextLevel ();
	}
}
