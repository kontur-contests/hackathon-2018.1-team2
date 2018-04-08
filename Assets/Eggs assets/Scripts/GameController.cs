using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour 
{
	private static bool created = false;
	private bool levelComplete = false;
	private Dictionary<string, int> eggGoals;
	private EggCounter eggCounter;
	
	// Use this for initialization
	void Start () 
	{
		eggCounter = FindObjectOfType<EggCounter>();
		eggGoals = new Dictionary<string, int> 
		{
			{ "Level_1", 3 },
			{ "Level_2", 2 },
            { "Level_3", 1 },
            { "Level_4", 4 }
		};
	}
	
	void Awake()
    {
        if (!created)
        {
            DontDestroyOnLoad(this.gameObject);
            created = true;
            Debug.Log("Awake: " + this.gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () 
	{
		if (levelComplete) 
		{
			if (Input.GetKeyDown (KeyCode.Return)) 
			{
				switch (SceneManager.GetActiveScene().name) 
				{
					case "Level_1":
						SceneManager.LoadScene ("Level_2");
						break;
					case "Level_2":
						SceneManager.LoadScene ("Level_3");
						break;
					case "Level_3":
                        SceneManager.LoadScene ("Level_4");
                        break;
                }
			}
		}
	}

	void OnLevelWasLoaded()
	{
		Debug.Log (SceneManager.GetActiveScene().name);
		eggCounter = FindObjectOfType<EggCounter>();
	}

	void OnGUI()
	{
		if (eggCounter.Counter == eggGoals[SceneManager.GetActiveScene().name]) 
		{
			var boxWidth = 200;
			var boxHeight = 25;
			GUI.Box(new Rect (Screen.width/2 - boxWidth/2, Screen.height/2 - boxHeight*3, boxWidth, boxHeight), "Victory!");
			levelComplete = true;
		}
	}
}
