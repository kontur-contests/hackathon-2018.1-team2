using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

	public void PlayPressed()
	{
		SceneManager.LoadScene ("Level_1");
	}

	public void ExitPressed()
	{
		Application.Quit ();
	}
}
