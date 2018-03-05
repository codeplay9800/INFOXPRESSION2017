using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameController : MonoBehaviour {
	private mover sp,sp2;
	public GameObject[] hazardsrow1;
	public GameObject[] hazardsrow2;
	public GameObject[] hazardsrow3;
	public GameObject[] hazardsrow4;
	public GameObject[] hazardsrow5;
	public GameObject[] hazardsrow6;
	public GameObject[] hazardsrow7;
	public GameObject[] hazardsrow8;
	public Vector3 spawnValues;
	static int score;
	Vector3 player_spawnpos= new Vector3(-7.5f,0.0f,0.0f);
	Quaternion player_spawnrot=Quaternion.identity;
	public float spawnWait;
	public float startwait;
	public GameObject WinText;
	public GameObject lossText;
	public Text triesText;
	public GameObject StartText;
	public GameObject player;
	public static int tries=3;
	Text wintext;
	IEnumerator StartGame()
	{
		StartText.SetActive (true);
		yield return new WaitForSeconds (startwait);
		StartText.SetActive (false);
		spawnplayer ();

	}
	/*IEnumerator Spawnwave1()
	{	
		while(true)
		{	GameObject hazard = hazardsrow1 [Random.Range(0,hazardsrow1.Length)];
				sp = hazard.GetComponent<mover> ();
				sp.speed =2.5f ;
				Vector3 spawnPosition = new Vector3 (-6.75f ,spawnValues.y,spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				if(hazard.gameObject.tag=="1")
					yield return new WaitForSeconds (0.88f);
				if(hazard.gameObject.tag=="2")
					yield return new WaitForSeconds (1.52f);
				if(hazard.gameObject.tag=="3")
					yield return new WaitForSeconds (2.24f);
				Instantiate (hazard, spawnPosition, spawnRotation);
				
		}
	}*/

	IEnumerator Spawnwave2()
	{	
		while (true) {
			GameObject hazard = hazardsrow2 [Random.Range(0,hazardsrow2.Length)];
			sp2 = hazard.GetComponent<mover> ();
			sp2.speed =2.0f ;
			Vector3 spawnPosition = new Vector3 (-5.25f ,spawnValues.y,spawnValues.z);
			Quaternion spawnRotation = Quaternion.identity;
			if(hazard.gameObject.tag=="1")
				yield return new WaitForSeconds (1.1f);
			if(hazard.gameObject.tag=="2")
				yield return new WaitForSeconds (1.08585f);
			if(hazard.gameObject.tag=="3")
				yield return new WaitForSeconds (1.60f);
			Instantiate (hazard, spawnPosition, spawnRotation);
		}
	}
	IEnumerator Spawnwave3()
	{
		while (true) {
			GameObject hazard = hazardsrow3 [Random.Range (0, hazardsrow3.Length)];
			sp2 = hazard.GetComponent<mover> ();
			sp2.speed = -2.5f;
			Vector3 spawnPosition = new Vector3 (-3.75f, spawnValues.y, -spawnValues.z);
			Quaternion spawnRotation = Quaternion.identity;
			if (hazard.gameObject.tag == "1")
				yield return new WaitForSeconds (0.62865f);
			if (hazard.gameObject.tag == "2")
				yield return new WaitForSeconds (1.63f);
			if (hazard.gameObject.tag == "3")
				yield return new WaitForSeconds (1.60f);
			Instantiate (hazard, spawnPosition, spawnRotation);
		}
	}

		IEnumerator Spawnwave4()
		{
			while (true) {
				GameObject hazard = hazardsrow4 [Random.Range(0,hazardsrow4.Length)];
				sp2 = hazard.GetComponent<mover> ();
				sp2.speed =3.0f ;
				Vector3 spawnPosition = new Vector3 (-2.25f ,spawnValues.y,spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				if(hazard.gameObject.tag=="1")
					yield return new WaitForSeconds (0.7f);
				if(hazard.gameObject.tag=="2")
					yield return new WaitForSeconds (1.2f);
				if(hazard.gameObject.tag=="3")
					yield return new WaitForSeconds (1.80f);
				Instantiate (hazard, spawnPosition, spawnRotation);
			}
	}
	IEnumerator Spawnwave5()
	{
		while (true) {
			GameObject hazard = hazardsrow5 [Random.Range(0,hazardsrow5.Length)];
			sp2 = hazard.GetComponent<mover> ();
			sp2.speed =-3.0f ;
			Vector3 spawnPosition = new Vector3 (0.0f ,spawnValues.y,-spawnValues.z);
			Quaternion spawnRotation = Quaternion.identity;
			if(hazard.gameObject.tag=="1")
				yield return new WaitForSeconds (0.57f);
			if(hazard.gameObject.tag=="2")
				yield return new WaitForSeconds (.97f);
			if(hazard.gameObject.tag=="3")
				yield return new WaitForSeconds (1.9f);
			Instantiate (hazard, spawnPosition, spawnRotation);
		}
	}
	IEnumerator Spawnwave6()
	{
		while (true) {
			GameObject hazard = hazardsrow6 [Random.Range(0,hazardsrow6.Length)];
			sp2 = hazard.GetComponent<mover> ();
			sp2.speed =-4.0f ;
			Vector3 spawnPosition = new Vector3 (1.5f ,spawnValues.y,-spawnValues.z);
			Quaternion spawnRotation = Quaternion.identity;
			if(hazard.gameObject.tag=="1")
				yield return new WaitForSeconds (0.65f);
			if(hazard.gameObject.tag=="2")
				yield return new WaitForSeconds (.99f);
			if(hazard.gameObject.tag=="3")
				yield return new WaitForSeconds (1.42f);
			Instantiate (hazard, spawnPosition, spawnRotation);
		}
	}
	IEnumerator Spawnwave7()
	{	
		while (true) {
			GameObject hazard = hazardsrow7 [Random.Range (0, hazardsrow7.Length)];
			sp = hazard.GetComponent<mover> ();
			sp.speed = 2.5f;
			Vector3 spawnPosition = new Vector3 (3.0f, spawnValues.y, spawnValues.z);
			Quaternion spawnRotation = Quaternion.identity;
			if (hazard.gameObject.tag == "1")
				yield return new WaitForSeconds (0.83f);
			if (hazard.gameObject.tag == "2")
				yield return new WaitForSeconds (1.73f);
			if (hazard.gameObject.tag == "3")
				yield return new WaitForSeconds (2.26f);
			Instantiate (hazard, spawnPosition, spawnRotation);

		}
	}
		IEnumerator Spawnwave8()
		{	
			while(true)
			{	GameObject hazard = hazardsrow8 [Random.Range(0,hazardsrow8.Length)];
				sp = hazard.GetComponent<mover> ();
				sp.speed =2.5f ;
				Vector3 spawnPosition = new Vector3 (5.5f ,spawnValues.y,spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				if(hazard.gameObject.tag=="1")
					yield return new WaitForSeconds (0.78f);
				if(hazard.gameObject.tag=="2")
					yield return new WaitForSeconds (1.42f);
				if(hazard.gameObject.tag=="3")
					yield return new WaitForSeconds (2.03f);
				Instantiate (hazard, spawnPosition, spawnRotation);

			}
	}
	void Start () {
		Screen.orientation = ScreenOrientation.LandscapeLeft;
		wintext = WinText.GetComponent<Text> ();
		wintext.text = "AWESOME";
		score = 0;
		tries = 5;
		Debug.Log (score);
		WinText.SetActive (false);
		lossText.SetActive (false);
		StartCoroutine("StartGame");
		StartCoroutine("Spawnwave2");
		StartCoroutine("Spawnwave3");
		StartCoroutine("Spawnwave4");
		StartCoroutine("Spawnwave5");
		StartCoroutine("Spawnwave6");
		StartCoroutine("Spawnwave7");
		StartCoroutine("Spawnwave8");

	}

	public void spawnplayer()
	{	tries = tries - 1;
		if(tries >= 1) {
			Instantiate (player, player_spawnpos, player_spawnrot);
		} 
	}
	public void UpdateScore()
	{
		
		score=score+1;
		Debug.Log (score);
	}

	public void backtoscene()
	{
		SceneManager.LoadScene ("3dayGame");
	}
		
	void Update()
	{	
		if (tries <=0) {
			lossText.SetActive (true);
			Invoke ("backtoscene", 4);
		}
		if (score >= 3) 
		{	WinText.SetActive (true);
		}

		if(Input.GetKey(KeyCode.Escape))
		{
			SceneManager.LoadScene("3dayGame");
		}


	}
}
