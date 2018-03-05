using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockE : MonoBehaviour {
	public Text text;
	// Use this for initialization
	void Start () {
		text.text ="Inaugration\n"+"Admin Room \n"+"GOT Quiz-Prelims \n" + "Codestrer\n"+ "Pair Programming \n"+ "Jigsaw \n"+ "Bug Finder \n"+"PR and Hospitality \n" ;
		if (System.DateTime.Now.Date == new System.DateTime (2017, 10, 14)) {
			text.text = "Rooters\n" + "Blind Coding \n" + "Jigsaw \n"+"Alexa \n"+"DSC Session \n"+"GSOC Meetup" ;
		}
		if (System.DateTime.Now.Date == new System.DateTime (2017, 10, 15)) {
			text.text = "GOT Finals\n" + "Valedictory \n" + "Jigsaw \n"+"Mind Your Language \n"+"U-Hack\n" ;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
