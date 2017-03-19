using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestroyScript : MonoBehaviour {

	public float radius = 4.5f;

	GameObject goal;

	// Use this for initialization
	void Start () {
		goal = GameObject.Find("Goal");
	}
	
	// Update is called once per frame
	void Update () {
		//Distance between center of the goal and this
		//gameObject so I can check to see if it's
		//greater than the radius

//		goal.transform.position
//		transform.position

		if(Vector3.Distance(goal.transform.position, transform.position) > radius){
			Destroy(gameObject);
			Debug.Log(gameObject.name + " DIED!!! OH NOOO!!!!");
		}
	}
}
