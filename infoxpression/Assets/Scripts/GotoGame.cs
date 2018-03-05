using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoGame : MonoBehaviour {
	public InputField InputField;
	public GameObject input;
	bool Enabled=false;


	// Use this for initialization
	public void enableInput () {
		if (Enabled == false) {
			input.SetActive (true);
			Enabled = true;
		}
		else if (Enabled == true) {
			Enabled = false;
			input.SetActive (false);
		}
	}
	void loadscene()
	{
		SceneManager.LoadScene ("minigame");
	}
	// Update is called once per frame
	void Start () {
		input.SetActive(false);
	}

	public void Apply()
	{if(InputField.text == "myinfox")
		{
			loadscene ();
		}
	}

}
