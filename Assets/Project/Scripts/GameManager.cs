/// <summary>
/// Manage game win/lose and points.
/// </summary>
using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	// Game score.
	public int score = 0;

	// Score needed to win.
	public int winScore = 20;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Increment the score and return new score.
	public int IncrementScore() {
		score ++;
		Debug.Log("Score incremented to: " + score);

		if (score >= winScore) {
			WinGame();
		}

		return score;
	}

	// Declare the game lost.
	public void LoseGame() {
		Debug.Log("Game is lost!");
	}

	// Declare the game won.
	public void WinGame() {
		Debug.Log("Game is won!");
	}
}
