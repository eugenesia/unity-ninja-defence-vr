/// <summary>
/// Manage game win/lose and points.
/// </summary>
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

	// Game score.
	public int score = 0;

	// Score needed to win.
	public int winScore = 20;

	public Text scoreText;

	// Use this for initialization
	void Start () {
		scoreText = GameObject.Find("Score").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Increment the score and return new score.
	public int IncrementScore() {
		score ++;
		scoreText.text = "Score: " + score;

		if (score >= winScore) {
			WinGame();
		}

		return score;
	}

	// Declare the game lost.
	public void LoseGame() {
		scoreText.text = "You lose!";
	}

	// Declare the game won.
	public void WinGame() {
		scoreText.text = "You win!";
	}
}
