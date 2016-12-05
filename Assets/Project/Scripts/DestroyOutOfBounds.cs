/// <summary>
/// Destroy any object out of the game boundaries.
/// </summary>
using UnityEngine;
using System.Collections;

public class DestroyOutOfBounds : MonoBehaviour {

	// Destroy everything that leaves the game boundaries.
	void OnTriggerExit(Collider other) {
		Destroy(other.gameObject);
	}
}
