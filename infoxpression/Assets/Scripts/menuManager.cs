using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuManager : MonoBehaviour {
	bool menuanim=false;
	public Button register,liveEvents,game,menu;
	public Animator menuAnim,buttonAnim;

	// Use this for initialization
	void Start () {
		register.onClick.AddListener (mRegister);
		liveEvents.onClick.AddListener (mEvents);
		game.onClick.AddListener (mGame);
		menu.onClick.AddListener (animateMenu);
	}

	void mRegister(){
		Debug.Log ("Register");
		menuAnim.SetTrigger ("out");
		buttonAnim.SetTrigger ("out");
		SceneManager.LoadScene ("website");
	}

	void mEvents(){
		Debug.Log ("events");
		menuAnim.SetTrigger ("out");
		buttonAnim.SetTrigger ("out");
		SceneManager.LoadScene ("liveEvents");
	}

	void mGame(){
		Debug.Log ("game");
		menuAnim.SetTrigger ("out");
		buttonAnim.SetTrigger ("out");
		SceneManager.LoadScene ("3dayGame");

	}

	void animateMenu(){
		if (menuanim == false) {
			menuAnim.SetTrigger ("in");
			buttonAnim.SetTrigger ("in");
			menuanim = true;
		} else {
			menuAnim.SetTrigger ("out");
			buttonAnim.SetTrigger ("out");
			menuanim = false;
		}
	}
	public void sponsorMenu()
	{
		SceneManager.LoadScene ("sponsor");
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		}
	}
}
