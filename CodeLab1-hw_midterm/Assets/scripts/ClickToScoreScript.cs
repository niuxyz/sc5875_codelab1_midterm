using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToScoreScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			ScoreManagerScript.instance.Score += 10;
		}
	}
}
