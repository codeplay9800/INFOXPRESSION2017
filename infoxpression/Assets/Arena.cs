using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Arena : MonoBehaviour {
	public Text text;
	// Use this for initialization
	void Start () {
		if (System.DateTime.Now.Date == new System.DateTime (2017, 10, 14)) {
			text.text = "Robo Race\n"+"Treasure Hunt Prelims \n"+"Mélange\n";
		}
		if (System.DateTime.Now.Date == new System.DateTime (2017, 10, 15)) {
			text.text = "Mind The line\n"+"Treasure Hunt Finals\n" ;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
