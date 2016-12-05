/// <summary>
/// Detect if enemy enters the Lose boundary.
/// </summary>
using UnityEngine;
using System.Collections;

public class LoseBound : MonoBehaviour {

	// Global Game Manager object for game-wide functions.
	public GameManager gameMgr;

	public void Start() {
		gameMgr = GameObject.Find("Game").GetComponent<GameManager>();
	}

	// Detect when enemy enters the Lose boundary, and if so, the game is lost.
	public void OnTriggerEnter(Collider other) {
		gameMgr.LoseGame();
	}
}
