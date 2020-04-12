using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerFate : MonoBehaviour
{
	private int battleOutcome; // int that determines whether players won or lost the game

    // Start is called before the first frame update
    void Start()
    {
		// sets the var to a range of different numbers
		battleOutcome = Random.Range(0,9);
		Debug.Log(battleOutcome); // prints the value of player fate into the console
    }

	// function that determines whether or not players have won the game
	public void BattleOutcome()
	{
		// checks to see if the player got a value between 0 and 4
		if (battleOutcome >= 0 && battleOutcome <= 4)
		{
			// loads the lose scene
			SceneManager.LoadScene("LoseScene");
		}

		// checks to see if the player got a value between 5 and 9
		else if (battleOutcome >= 5 && battleOutcome <= 9)
		{
			// loads the win scene
			SceneManager.LoadScene("WinScene");
		}
	}
}
