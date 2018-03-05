using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Dblock : MonoBehaviour {

	public Text text;
	// Use this for initialization
	void Start () {
		text.text ="Circuitrix \n"+ "Clash On Lan \n" ;
		if (System.DateTime.Now.Date == new System.DateTime (2017, 10, 14)) {
			text.text = "Hardware Hackathon\n"+"Clash On Lan \n" ;
		}
		if (System.DateTime.Now.Date == new System.DateTime (2017, 10, 15)) {
			text.text = "Clash On Lan \n" ;
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
