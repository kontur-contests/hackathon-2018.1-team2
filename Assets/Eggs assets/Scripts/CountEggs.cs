using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countEggs : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision variable)
    {
        //if (variable.gameObject == GameObject.Find("Basket"))
        //{
              Destroy(gameObject);
        //}
    }
}
