using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeLight : MonoBehaviour {
	bool full;
	public float wait;
	public Light pointli;
	// Use this for initialization
	void Start () {
		full = false;
		pointli = GetComponent<Light> ();
		pointli.range = 0.5f;
		StartCoroutine ("changeRange");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	IEnumerator changeRange()
	{
		while (true) {
			while (pointli.range <= 2.0f && full == false) {
				pointli.range = pointli.range + 0.1f;
				yield return new WaitForSeconds (wait);
			}
			//yield return new WaitForSeconds (1.0f);

			if (pointli.range >= 1.9f) {
				full = true;
			}
			while (pointli.range >= 0.5f && full == true) {
				pointli.range = pointli.range - 0.1f;
				yield return new WaitForSeconds (wait);
			}
			if (pointli.range <= 0.5f) {
				full = false;
			}
		}
	}


}
