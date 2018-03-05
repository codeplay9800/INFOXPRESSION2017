using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cameraManager : MonoBehaviour {

	public GameObject target;
	Vector3 offsetPosition;
	Quaternion offsetRotation;
	public Slider zoomSlider;
	public GameObject cam;
	bool find = false;
	public Button locateMe;

	Color gr = Color.green , re = Color.red;

	void Awake(){
		offsetPosition = cam.transform.position - target.transform.position;
		offsetRotation = cam.transform.rotation;
	}

	// Use this for initialization
	void Start () {
		locateMe.GetComponent<Image> ().color = re;
		locateMe.onClick.AddListener (mLocateMe);
	}



	private bool isDragging = false;
	private static Vector2 startTouch, swipeDelta;

	void mLocateMe(){
		find = !find;
		if (find) {
			locateMe.GetComponent<Image> ().color = gr;
		} else {
			locateMe.GetComponent<Image> ().color = re;
		}
	}

	// Update is called once per frame
	void Update () {
		if (find) {
			cam.transform.position = Vector3.MoveTowards (cam.transform.position, target.transform.position + offsetPosition, Time.deltaTime*0.2f);
			cam.transform.rotation = Quaternion.RotateTowards (cam.transform.rotation, Quaternion.LookRotation(target.transform.position - cam.transform.position), Time.deltaTime);

		}


		#region Mobile Inputs
		if(Input.touches.Length>0){
			if(Input.touches[0].phase == TouchPhase.Began){
				isDragging = true;
				startTouch = Input.touches[0].position;
			}else if(Input.touches[0].phase == TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled){
				isDragging = false; 
				Reset (); 
			}
		}
		#endregion

		//calculate distance
		swipeDelta = Vector2.zero;
		if (isDragging) {
			if (Input.touches.Length > 0) {
				swipeDelta = Input.touches [0].position - startTouch;
			} else if (Input.GetMouseButton (0)) {
				swipeDelta = (Vector2)Input.mousePosition - startTouch;
			}
		}

		if (swipeDelta.magnitude > 0) {
			transform.position = Vector3.MoveTowards (transform.position, new Vector3 (swipeDelta.x / 1000, 0, swipeDelta.y / 1000) + target.transform.position, Time.deltaTime * 5); 
		}
	}

	private void Reset(){
		isDragging = false;
		startTouch = swipeDelta = Vector2.zero;
	}
}

