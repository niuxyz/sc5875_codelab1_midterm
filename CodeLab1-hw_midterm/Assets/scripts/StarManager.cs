using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarManager : MonoBehaviour {
	public Wk6Manager wk6Manger;
	public GameObject Sun;
	public GameObject Moon;
	public Vector2 TimeRange;

	private int timer;
	// Use this for initialization
	void Start () {
		string _dataTime;
		_dataTime = wk6Manger.DataTime;
		if (_dataTime.Contains ("PM")) {
			string time = _dataTime[_dataTime.IndexOf (':')-2].ToString() + _dataTime[_dataTime.IndexOf (':')-1].ToString();
			timer = int.Parse (time);
			timer += 12;
		} else {
			string time = _dataTime[_dataTime.IndexOf (':')-2].ToString() + _dataTime[_dataTime.IndexOf (':')-1].ToString();
			timer = int.Parse (time);
		}

		if (timer <= TimeRange.y && timer >= TimeRange.x) {
			SetApperance (Sun, true);
			SetApperance (Moon, false);
		} else {
			SetApperance (Moon, true);
			SetApperance (Sun, false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SetApperance(GameObject obj, bool ifAppear)
	{
		obj.GetComponent<SpriteRenderer> ().enabled = ifAppear;
	}
}
