using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggCounter : MonoBehaviour 
{
	public int Counter;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
		if (collision.gameObject.name == "Egg")
        {
			Counter++;
			Destroy(collision.gameObject);
        }
    }

	void OnGUI()
	{
		GUI.Box(new Rect(10, 10, 100, 25), "Eggs: " + Counter);
	}
}
