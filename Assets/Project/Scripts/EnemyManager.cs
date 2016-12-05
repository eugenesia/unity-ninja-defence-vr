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

		// Spawn enemy randomly along x-axis on the platform.
		float xpos = Random.Range(-5f, 5f);

		// If enemy is right in front of player (-1.5 < X < +1.5), it will
		// collide with player, so move it to the side.
		if (xpos > -1.5f && xpos < 0f) {
			xpos = -1.5f;
		}
		else if (xpos > 0f && xpos < 1.5f) {
			xpos = 1.5f;
		}

		// Start off at the end of the platform, and move towards player.
		newEnemy.transform.position = new Vector3(xpos, 0f, 90f);

		// Cause enemies to go into "Run" state so they run towards player.
		Animator anim = newEnemy.GetComponent<Animator>();
		anim.SetBool("Moving", true);
		anim.SetBool("Running", true);
	}
}
