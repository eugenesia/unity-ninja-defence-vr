/// <summary>
/// Manage individual enemy behavior.
/// </summary>

using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	// Before the enemy dies, it blinks.
	// Number of blinks.
	private int blinkCount = 3;
	// Interval between blinks.
	private float blinkInterval = 0.2f;

	// Game Manager object for game-wide functions.
	private GameManager gameMgr;

	// Audio source that plays enemy death sound "ugh!"
	private AudioSource audioSource;


	// Use this for initialization
	void Start () {
		gameMgr = GameObject.Find("Game").GetComponent<GameManager>();
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Check if we collided with a player projectile, if so it's dead.
	void OnCollisionEnter(Collision collision) {
		// Enemy got hit by fire.
		if (collision.gameObject.CompareTag("Fire")) {
			gameMgr.IncrementScore();

			// Play the enemy death sound "ugh!"
			audioSource.Play();

			StartCoroutine("Die");
		}
	}

	// Start dying sequence.
	IEnumerator Die() {

		// Stop running animation and make it idle.
		Animator anim = GetComponent<Animator>();
		anim.SetBool("Moving", false);
		anim.SetBool("Running", false);

		// Blink by disabling and enabling the renderer.
		Renderer renderer = GetComponentInChildren<Renderer>();
		for (int i = 0; i < blinkCount * 2; i++) {
			renderer.enabled = ! renderer.enabled;
			yield return new WaitForSeconds(blinkInterval);
		}

		// Destroy this enemy as it's dead.
		Destroy(gameObject);
	}
}
