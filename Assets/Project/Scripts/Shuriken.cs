/// <summary>
/// Manage individual shuriken behavior.
/// </summary>

using UnityEngine;
using System.Collections;

public class Shuriken : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Disappear on hitting enemy.
	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.CompareTag("Enemy")) {
			Destroy(gameObject);
		}
	}
}
