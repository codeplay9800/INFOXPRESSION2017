using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class screenorientationsponsor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.orientation = ScreenOrientation.LandscapeLeft;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Escape))
		{
			SceneManager.LoadScene("menu");
		}
		
	}
	public void backtoscene()
	{
		SceneManager.LoadScene ("menu");
	}
}
