using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreChangerScript : MonoBehaviour {

	private const int HEALTH_MIN = 0;
	public const int HEALTH_MAX = 100;

	public int damageAmt = 7;

	private static int health;

	public int Health{
		get{
			return health;
		}

		set{
			health = value;

			if(health > HEALTH_MAX){
				health = HEALTH_MAX;
			}

			if(health < HEALTH_MIN){
				health = HEALTH_MIN;
			}
		}
	}

	public KeyCode damageKey;

	// Use this for initialization
	void Start () {
		Debug.Log("Current Score: " + Wk3GameManager.instance.Score);

		Health = HEALTH_MAX;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(damageKey)){
			Health -= damageAmt;
			print(name + " Current Health: " + Health);
		}
	}
}
