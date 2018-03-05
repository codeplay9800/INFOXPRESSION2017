using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cblock : MonoBehaviour {

	public Text text;
	// Use this for initialization
	void Start () {
		text.text = "Samadhan \n";
		if (System.DateTime.Now.Date == new System.DateTime (2017, 10, 14)) {
			text.text = "U-Hack Kickoff\n"+"Clash Of Companies \n" ;
		}
		if (System.DateTime.Now.Date == new System.DateTime (2017, 10, 15)) {
			text.text = "U-Hack Signoff\n"+"Dockers\n" ;
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
