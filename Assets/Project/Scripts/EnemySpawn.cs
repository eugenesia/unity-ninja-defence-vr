using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {

	GameObject ninja;
	Animator anim;

	// Use this for initialization
	void Start () {
		ninja = GameObject.Find("Ninja Warrior");
		anim = ninja.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

		AnimatorStateInfo animState = anim.GetCurrentAnimatorStateInfo(0);
		if (animState.IsName("Attack1")) {
			Debug.Log("Is attacking");
		}
		else {
			anim.SetTrigger("Attack1Trigger");
		}
	}
}
