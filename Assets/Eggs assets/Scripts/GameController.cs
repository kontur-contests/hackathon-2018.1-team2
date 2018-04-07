using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour 
{
	private EggCounter x;
	// Use this for initialization
	void Start () 
	{
		x = FindObjectOfType<EggCounter>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnGUI()
	{
		//GUISkin = TextAlignment.Center;
		if (x.Counter == 3) 
		{
			Debug.Log ("Victory");
			GUI.Box (new Rect (100, 100, 200, 50), "Victory");
		}
	}
}
