// Just add this script to your camera. It doesn't need any configuration.
using UnityEngine.UI;
using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
public class TouchCamera : MonoBehaviour {
	Rigidbody rb;
	bool rotating;
	Vector3 playerInput;
	public float xmin,xmax,zmin,zmax,ymin,ymax,speed,speed2;
	Quaternion rot;
	Vector2?[] oldTouchPositions = {
		null,
		null
	};
	Vector3 firstpoint; //change type on Vector3
	Vector3 secondpoint;
	float xAngle; //angle for axes x for rotation
	float yAngle;
	float xAngTemp ; //temp variable for angle
	float yAngTemp ;
	public Text rottext;
	Vector2 oldTouchVector;
	float oldTouchDistance;
	public Camera camera;

	void Start()
	{	Screen.orientation = ScreenOrientation.LandscapeLeft;
		rotating = false;
		rb = GetComponent<Rigidbody> ();
		xAngle = 180f;
		yAngle = 41.3f;
		xAngTemp = 0.0f;
		yAngTemp=0.0f;
	}

	public void rotpress()
	{
		if (rotating == false) {
			rotating = true;
			rottext.text = " Press To Translate";

		} else if (rotating == true) {
			rotating = false;
			rottext.text =" Press To Rotate";
		}
	}
	void Update() {
		if (Input.touchCount == 0&&rotating==false) {
			oldTouchPositions [0] = null;
			oldTouchPositions [1] = null;
		} else if (Input.touchCount == 1 && rotating ==false) {
			if (oldTouchPositions [0] == null || oldTouchPositions [1] != null) {
				oldTouchPositions [0] = Input.GetTouch (0).position;
				oldTouchPositions [1] = null;
			} else {
				Vector2 newTouchPosition = Input.GetTouch (0).position;

				transform.position += transform.TransformDirection ((Vector3)((oldTouchPositions [0] - newTouchPosition) * speed * camera.orthographicSize / camera.pixelHeight * 2f));
				gameObject.transform.position = new Vector3 (
					Mathf.Clamp (gameObject.transform.position.x, xmin, xmax),
					Mathf.Clamp (gameObject.transform.position.x, ymin, ymax),
					Mathf.Clamp (gameObject.transform.position.z, zmin, zmax));
				
				oldTouchPositions [0] = newTouchPosition;
			}
		} else if (rotating == true&&Input.touchCount >= 1) {	
			//Touch began, save position
			if (Input.GetTouch (0).phase == TouchPhase.Began) {
				firstpoint = Input.GetTouch (0).position;
				xAngTemp = xAngle;
				yAngTemp = yAngle;
			}
			//Move finger by screen
			if (Input.GetTouch (0).phase == TouchPhase.Moved) {
				secondpoint = Input.GetTouch (0).position;
				//Mainly, about rotate camera. For example, for Screen.width rotate on 180 degree
				xAngle = xAngTemp + (secondpoint.x - firstpoint.x) * 180.0f / Screen.width;
				yAngle = yAngTemp - (secondpoint.y - firstpoint.y) * 90.0f / Screen.height;
				//Rotate camera
				this.transform.rotation = Quaternion.Euler (new Vector3 (yAngle, xAngle, 0.0f));
			}
		}



}
}
