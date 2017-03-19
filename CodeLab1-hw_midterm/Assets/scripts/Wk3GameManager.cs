using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wk3GameManager : MonoBehaviour {

	private int score;

	public int Score{
		get{
			Debug.Log("Some wants the scores");
			return score;
		}

		set{
			score = value;

			Debug.Log("score was set to: " + score);

//			if(score > 100){
//				score = 100;
//			}
		}
	}

	private int intIdontWantAnyOneElseToChangeOrSee;

	public static Wk3GameManager instance;

	// Use this for initialization
	void Start () {

		if(instance == null){
			instance = this;
			DontDestroyOnLoad(this);
		} else {
			Destroy(gameObject);
		}

		score += 10;

//		Time.deltaTime =6767;  //This line won't compile, because deltaTime is read-only
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.C)){
			SceneManager.LoadScene("Week3-2");
		}
	}
}
