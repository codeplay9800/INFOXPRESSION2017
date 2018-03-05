using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class PlayerControl : MonoBehaviour {
	Rigidbody rb;
	public GameObject gamecontroller;
	GameController gc;
	public float speed=10.0f;
	public float xmin,xmax,zmin,zmax;

	void Start(){
		rb = gameObject.GetComponent<Rigidbody> ();
		gc = gamecontroller.GetComponent<GameController> ();
	}


	void FixedUpdate()
	{
		float moveHor = CrossPlatformInputManager.GetAxis("Horizontal");
		float moveVer = CrossPlatformInputManager.GetAxis ("Vertical");
		rb.velocity = new Vector3 (moveHor*speed, 0.0f, moveVer*speed);
		gameObject.transform.position = new Vector3 (
			Mathf.Clamp (gameObject.transform.position.x, xmin, xmax),
			0.0f,
			Mathf.Clamp (gameObject.transform.position.z, zmin, zmax));
	
	}

	void OnTriggerEnter(Collider col)
	{		Destroy (this.gameObject);
		if (col.gameObject.tag == "Hole") {
			gc.UpdateScore ();
		}
		gc.spawnplayer ();
	
	
	}

}