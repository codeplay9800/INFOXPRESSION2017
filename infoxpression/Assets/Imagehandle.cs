using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Imagehandle : MonoBehaviour {
	public GameObject image1;
	public GameObject image2;
	public GameObject image3;

	// Use this for initialization
	void Start () {
		Screen.orientation = ScreenOrientation.LandscapeLeft;
			image1.SetActive (true);
			image2.SetActive (false);
			image3.SetActive (false);
		if (System.DateTime.Now.Date == new System.DateTime (2017, 10, 14)) {
			image1.SetActive (false);
			image2.SetActive (true);
			image3.SetActive (false);
		}
		if (System.DateTime.Now.Date == new System.DateTime (2017, 10, 14)) {
			image1.SetActive (false);
			image2.SetActive (false);
			image3.SetActive (true);
		}
	}

	public void day1()
	{
		image1.SetActive (true);
		image2.SetActive (false);
		image3.SetActive (false);
	}
	public void day2()
	{
		image1.SetActive (false);
		image2.SetActive (true);
		image3.SetActive (false);
	}

	public void day3()
	{
		image1.SetActive (false);
		image2.SetActive (false);
		image3.SetActive (true);
	}
	// Update is called once per frame
	void Update () {
		Debug.Log(System.DateTime.Now.Second +"01"+ (System.DateTime.Now.Second)+"951243"+(System.DateTime.Now.Second)+"67"+System.DateTime.Now.Month);	
	}
}
