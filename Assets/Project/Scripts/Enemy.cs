/// <summary>
/// Manage individual enemy behavior.
/// </summary>

using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Check if we collided with a player projectile, if so it's dead.
	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.CompareTag("Fire")) {

			// Deactivate this enemy as it's dead.
			gameObject.SetActive(false);
		}
	}
}
