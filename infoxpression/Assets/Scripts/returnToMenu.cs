using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class returnToMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	void Update()
	{ 
		if (Input.GetKeyDown (KeyCode.Escape)) {
			SceneManager.LoadScene ("menu");
		}
	}
	// Update is called once per frame
	public void loadMenu () {
		SceneManager.LoadScene ("menu");
	}
}
