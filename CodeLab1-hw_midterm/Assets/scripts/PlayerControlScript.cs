using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlScript : MonoBehaviour {

	public float speed = 1;

	public KeyCode upKey = KeyCode.W;
	public KeyCode downKey = KeyCode.S;
	public KeyCode leftKey = KeyCode.A;
	public KeyCode rightKey = KeyCode.D;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Move(Vector3.up, upKey);
		Move(Vector3.down, downKey);
		Move(Vector3.left, leftKey);
		Move(Vector3.right, rightKey);

		if(GetComponent<Rigidbody2D>().velocity.magnitude >= 2)
			GetComponent<Rigidbody2D>().velocity = GetComponent<Rigidbody2D>().velocity.normalized * 2.0f;
//		if(Input.GetKey(KeyCode.W)){
////			Debug.Log("This is working");
//			transform.Translate(Vector3.up * speed * Time.deltaTime);
//		}
//
//		if(Input.GetKey(KeyCode.S)){
//			transform.Translate(Vector3.down * speed * Time.deltaTime);
//		}
	}

	void Move(Vector3 dir, KeyCode key){
		if(Input.GetKey(key)){
			GetComponent<Rigidbody2D> ().AddForce (dir*speed, ForceMode2D.Impulse);
		}
	}
}
