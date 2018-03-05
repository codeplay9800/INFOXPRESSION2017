using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotateloading : MonoBehaviour {
	Animator rotater;
	public float time;
	// Use this for initialization
	void Start () {
		rotater = this.GetComponent<Animator> ();
		StartCoroutine ("Rotation");
	}

	// Update is called once per frame
	IEnumerator Rotation() {
		while (true) {
		rotater.SetTrigger ("rot");
			yield return new WaitForSeconds (time);
		}
	}
}
