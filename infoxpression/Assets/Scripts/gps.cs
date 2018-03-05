using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gps : MonoBehaviour {

	public Text text;
	int c=0;
	public float latitude,longitude,radLat, radLong;

	IEnumerator coroutine;

	IEnumerator Start()
	{
		coroutine = updateGPS();

		if (!Input.location.isEnabledByUser)
			yield break;

		Input.location.Start();

		int maxWait = 20;
		while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
		{
			yield return new WaitForSeconds(1);
			maxWait--;
		}

		if (maxWait < 1)
		{
			print("Timed out");
			yield break;
		}


		if (Input.location.status == LocationServiceStatus.Failed)
		{
			print("Unable to determine device location");
			yield break;
		}
		else
		{
			Debug.Log ("tatti");
			playerManager.isReady = true;
			// Access granted and location value could be retrieved
			latitude = Input.location.lastData.latitude;
			longitude = Input.location.lastData.longitude;

			text.text = "Location: " + latitude + " " + longitude + "tatti" + "\n" + c + 1;
			c++;
			radLat = latitude * 0.017453f;
			radLong = longitude * 0.017453f;	
			StartCoroutine(coroutine);
		}
	}

	IEnumerator updateGPS()
	{
		float UPDATE_TIME = 3f; //Every  3 seconds
		WaitForSeconds updateTime = new WaitForSeconds(UPDATE_TIME);

		while (true)
		{
			print("Location: " + Input.location.lastData.latitude + " " + Input.location.lastData.longitude + " " + Input.location.lastData.altitude + " " + Input.location.lastData.horizontalAccuracy + " " + Input.location.lastData.timestamp);
			//longitudeText.text = "Longitude: " + Input.location.lastData.longitude;
			//latitudeText.text = "Latitude: " + Input.location.lastData.latitude;
			yield return updateTime;
		}
	}

	void stopGPS()
	{
		Input.location.Stop();
		StopCoroutine(coroutine);
	}

	void OnDisable()
	{
		stopGPS();
	}
}
