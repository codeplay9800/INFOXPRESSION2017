using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerManager : MonoBehaviour {

	Vector3 currentLocation;
	public static Vector3 BeginningPosition = Vector3.zero;
 	public gps gpsObject;
	float x,y;

	private float originalLatitude;
	private float originalLongitude;
	private float currentLongitude;
	private float currentLatitude;

 	private float distance;

	public static bool isReady = false;

	public Text text;
	float mapScale = 0.008782f;
	float begRadLat,begRadLong;
	Vector3 bearing = Vector3.zero;
	// Use this for initialization
	void Awake () {
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
		BeginningPosition = new Vector3 (28.594975f, 0, 77.019319f);
		begRadLat = BeginningPosition.x * 0.017453f;
		begRadLong = BeginningPosition.z * 0.017453f;
	}
	Vector3 tempBearing = Vector3.zero;
	// Update is called once per frame
	void Update () {
 
		if (isReady) {

			x = (float)(Mathf.Cos (gpsObject.radLat) * Mathf.Sin (gpsObject.radLong - begRadLong));
			y = (float)(Mathf.Cos (begRadLat) * Mathf.Sin (gpsObject.radLat) - Mathf.Sin (begRadLat) * Mathf.Cos(gpsObject.radLat) * Mathf.Cos (gpsObject.radLong - begRadLong));
			tempBearing = new Vector3 (-x*1000000.0f, 0, -y*1000000.0f);
			bearing = tempBearing.normalized;

			Calc (BeginningPosition.x, BeginningPosition.z, gpsObject.latitude, gpsObject.longitude);

			currentLocation = bearing * distance * mapScale;
			transform.position = Vector3.MoveTowards (transform.position, currentLocation, 0.5f * Time.deltaTime);
			text.text = transform.position + " , Distance:  " + distance + " , currentLocation:  " + currentLocation + "\n.bearing:  " + bearing + " , " + x + " " + y;
		}
	}

	public void Calc(float lat1, float lon1, float lat2, float lon2)
	{

		float R = 6378.137f; // Radius of earth in KM
		float dLat = lat2 * Mathf.PI / 180.0f - lat1 * Mathf.PI / 180.0f;
		float dLon = lon2 * Mathf.PI / 180.0f - lon1 * Mathf.PI / 180.0f;
		float a = Mathf.Sin(dLat / 2) * Mathf.Sin(dLat / 2) +
			Mathf.Cos(lat1 * Mathf.PI / 180.0f) * Mathf.Cos(lat2 * Mathf.PI / 180.0f) *
			Mathf.Sin(dLon / 2) * Mathf.Sin(dLon / 2);
		float c = 2 * Mathf.Atan2(Mathf.Sqrt(a), Mathf.Sqrt(1 - a));
		distance = R * c;
		distance = distance * 1000.0f; // meters
    

	}
}
