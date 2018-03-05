using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logoanim : MonoBehaviour {

	Animator rotater;
	public float time;
	// Use this for initialization
	void Start () {
		rotater = this.GetComponent<Animator> ();
		StartCoroutine ("logoanimation");
	}

	// Update is called once per frame
	IEnumerator logoanimation() {
		while (true) {
			rotater.SetTrigger ("big");
			yield return new WaitForSeconds (time);
		}
	}
}
