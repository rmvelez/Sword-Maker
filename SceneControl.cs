using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
	// these are a group of functions that load the various scenes within the game

	// function that starts the game
	public void StartGame()
	{
		SceneManager.LoadScene("MyGame");
	}

	// function that loads the instruction screen
	public void LearnGame()
	{
		SceneManager.LoadScene("LearnScene");
	}

	// this function loads the title screen
	public void BackToTitle()
	{
		SceneManager.LoadScene("MyTitle");
	}
}
