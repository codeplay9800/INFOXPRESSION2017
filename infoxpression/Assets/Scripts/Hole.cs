using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour {
	SphereCollider coll;
	// Use this for initialization
	void Start () {
		coll = this.GetComponent<SphereCollider> ();
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider col) {
		GameController.tries = GameController.tries + 1;
		Renderer rend = GetComponent<Renderer>();
		rend.material.color=Color.cyan;
		coll.isTrigger = false;

	}
}
