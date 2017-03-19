using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Orange : MonoBehaviour {
	public LevelLoader levelLoader;

	void Start()
	{
		levelLoader = GameObject.Find ("GameManager").GetComponent<LevelLoader>();
	}

	void OnTriggerEnter2D(Collider2D player){
		if (player.gameObject.tag == "Player") {
			GetComponent<CircleCollider2D> ().enabled = false;
			GetComponent<SpriteRenderer> ().enabled = false;

			levelLoader.OrangeCount--;
			Debug.Log ("TRIGGER ENTER");
		}
	}

}
