using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class FileIOScript : MonoBehaviour {

	public string fileName = "temp.txt";

	public List<string> highScoreNames;
	public List<string> highScoreValues;

	// Use this for initialization
	void Start () {
		Debug.Log("Path: " + Application.dataPath);

		string finalFilePath = Application.dataPath + "/" + fileName;

		/*
		 * Write to a file
		 * /

//		StreamWriter sw = new StreamWriter(finalFilePath, false);
//
//		for(int i = 0; i < highScoreNames.Length; i++){
//			sw.WriteLine(highScoreNames[i] + " " + highScoreValues[i]);
//		}
//
//		sw.Close();

		/*
		 *  Read from file
		 */

		StreamReader sr = new StreamReader(finalFilePath);

		int i = 0;

		while(!sr.EndOfStream){
			string line = sr.ReadLine();

			string[] splitLine = line.Split(' ');

			string name = splitLine[0];
			string value = splitLine[1];

			Debug.Log("name: " + name);
			Debug.Log("value: " + value);

			highScoreNames.Add(name);
			highScoreValues.Add(value);

			i++;
		}

		sr.Close();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
