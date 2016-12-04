/// <summary>
/// Control enemy spawning and movement.
/// </summary>

using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour {

	public GameObject ninjaPrefab;

	// How many seconds to wait to spawn a new enemy.
	public float spawnInterval = 5f;

	// Use this for initialization
	void Start () {
		// Spawn enemy repeatedly after an interval.
		InvokeRepeating("SpawnEnemy", 0f, spawnInterval);
	}
	
	// Update is called once per frame
	void Update () {
	}

	// Instantiate a new enemy.
	private void SpawnEnemy() {
		GameObject newEnemy = Instantiate(ninjaPrefab);

		// Start off at the end of the platform, and move towards player.
		newEnemy.transform.position = new Vector3(0f, 0f, 150f);
		newEnemy.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 50f);

		// Enemy starts off at the far end of the platform.
		Animator anim = newEnemy.GetComponent<Animator>();
		anim.SetBool("Moving", true);
		anim.SetBool("Running", true);
		//anim.SetFloat("Input Z", -10f);
	}
}
