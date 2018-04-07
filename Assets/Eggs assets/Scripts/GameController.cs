using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour 
{
	private bool levelComplete = false;
	private EggCounter x;
	// Use this for initialization
	void Start () 
	{
		x = FindObjectOfType<EggCounter>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (levelComplete) 
		{
			if (Input.GetKeyDown(KeyCode.Return))
				SceneManager.LoadScene("Level_2");
		}
	}

	void OnGUI()
	{
		if (x.Counter == 3) 
		{
			var boxWidth = 200;
			var boxHeight = 25;
			GUI.Box(new Rect (Screen.width/2 - boxWidth/2, Screen.height/2 - boxHeight*3, boxWidth, boxHeight), "Victory!");
			levelComplete = true;
		}
	}
}
