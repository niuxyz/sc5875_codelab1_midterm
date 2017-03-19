using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {

	public float offsetX = 0;
	public float offsetY = 0;
	public int OrangeCount = 0;

	public string[] fileNames;
	public static int levelNum = 0;
	public GameObject[] EnviorCube;

	//public GameObject orange;

	// Use this for initialization
	void Awake () {
	//	LevelLoader.levelNum;
	//	LevelLoader level = new LevelLoader ();
	//	level.offsetX;
		string fileName = fileNames[levelNum];
		OrangeCount = 0;

		string filePath = Application.dataPath + "/" + fileName;
		StreamReader sr = new StreamReader(filePath);

		GameObject levelHolder = new GameObject("Level Holder");

		int yPos = 0;
		GameObject player = Instantiate(Resources.Load("Prefabs/Player") as GameObject);
		Debug.Log ("START CALLED");
		while(!sr.EndOfStream){
			string line = sr.ReadLine();

			for(int xPos = 0; xPos < line.Length; xPos++){
				if (line [xPos] == 'o') {
					//GameObject sphere = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					GameObject _orange = Instantiate (Resources.Load ("Prefabs/clementine")as GameObject);
					OrangeCount++;
					//GameObject _orange = Instantiate (orange) as GameObject;

					_orange.transform.parent = levelHolder.transform;
				
					_orange.transform.position = new Vector3 (
						xPos + offsetX,
						yPos + offsetY,
						0);
				}

				if(line[xPos] == 'x'){
					GameObject wallX = (Instantiate (EnviorCube [0]) as GameObject);
					SetPosition (wallX, xPos, yPos);
					//wallX.transform.position = new Vector3 (
					//xPos + offsetX,
					//yPos + offsetY,
					//0);				
					//cube.transform.position = new Vector3(
					//	xPos + offsetX, 
					//	yPos + offsetY, 	
					//	0);
				}
				if (line [xPos] == 'y') {
					GameObject wallY = (Instantiate (EnviorCube [1]) as GameObject);
					SetPosition (wallY, xPos, yPos);
					//wallY.transform.position = new Vector3 (
					//xPos + offsetX,
					//yPos + offsetY,
					//0);
				}
				if (line [xPos] == 'a') {
					GameObject upper_left = (Instantiate (EnviorCube [2]) as GameObject);
					SetPosition (upper_left, xPos, yPos);
				}
				if (line [xPos] == 'b') {
					GameObject upper_right = (Instantiate (EnviorCube [3]) as GameObject);
					SetPosition (upper_right, xPos, yPos);
				}
				if (line [xPos] == 'c') {
					GameObject lower_left = (Instantiate (EnviorCube [4]) as GameObject);
					SetPosition (lower_left, xPos, yPos);
				}
				if (line [xPos] == 'd') {
					GameObject lower_right = (Instantiate (EnviorCube [5]) as GameObject);
					SetPosition (lower_right, xPos, yPos);
				}
			}
//			Debug.Log(line);
			yPos--;
		}

		sr.Close();
	}

	void SetPosition(GameObject temp, float xPOS, float yPOS)
	{
		temp.transform.position = new Vector3(
			xPOS + offsetX,
			yPOS + offsetY,
			0);
	}
	
	// Update is called once per frame
	void Update () {
		if (OrangeCount == 0)
		{
			if(levelNum < fileNames.Length)
				levelNum++;
			SceneManager.LoadScene("Week5");
		}
	}
}
