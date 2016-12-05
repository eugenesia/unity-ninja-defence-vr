using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// How often to shoot a projectile.
	public float shootInterval = 2f;

	// Shuriken prefab to clone for a new shuriken.
	public GameObject shurikenPrefab;

	// How much force to shoot the projectile with.
	private float shootForce = 200f;

	// Main Camera.
	private GameObject mainCam;

	// Use this for initialization
	void Start () {
		mainCam = GameObject.Find("Main Camera");

		// Shoot a shuriken every X seconds.
		InvokeRepeating("ShootShuriken", shootInterval, shootInterval);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void ShootShuriken() {
		// Direction of shot is the horizontal component of the direction of gaze.
		// Because we want the shuriken to only shoot horizontally.
		Vector3 direction = Vector3.ProjectOnPlane(mainCam.transform.forward, Vector3.up);
		direction.Normalize();

		// Force vector to apply to shuriken.
		Vector3 forceVector = direction * shootForce;

		// Spawn a new shuriken in front of the player.
		GameObject shuriken = Instantiate(shurikenPrefab);

		// Shuriken should start in front of the camera, offset horizontally from the player.
		Vector3 posOffset = Vector3.ProjectOnPlane(mainCam.transform.forward, Vector3.up);
		shuriken.transform.position = transform.position + posOffset;

		// Apply forward and rotational forces to the shuriken so it will rotate
		// and fly forward.
		Rigidbody rb = shuriken.GetComponent<Rigidbody>();
		rb.AddForce(forceVector);
		rb.AddTorque(Vector3.up * 100f);
	}
}
