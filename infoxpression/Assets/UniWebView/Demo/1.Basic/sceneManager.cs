using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class sceneManager : MonoBehaviour {

	public Button sceneButton;

	// Use this for initialization
	void Start () {
		sceneButton.onClick.AddListener (change);	
	}

	void change(){
		if (SceneManager.GetActiveScene ().name.Equals ("localScene")) {
			SceneManager.LoadScene (0);
		} else {
			SceneManager.LoadScene (1);
		}
	}

}
