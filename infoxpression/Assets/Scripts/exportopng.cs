using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exportopng : MonoBehaviour {
	public Texture2D tex;
	void Start()
	{	
		StartCoroutine ("pillu");
	}
	// Take a shot immediately
	IEnumerator pillu () {
		// We should only read the screen buffer after rendering is complete
		yield return new WaitForEndOfFrame();

		// Create a texture the size of the screen, RGB24 format
		int width = Screen.width;
		int height = Screen.height;
		Texture2D tex = new Texture2D(width, height, TextureFormat.RGB24, false);

		// Read screen contents into the texture
		tex.ReadPixels(new Rect(0, 0, width, height), 0, 0);
		tex.Apply();

		// Encode texture into PNG
		byte[] bytes = tex.EncodeToPNG();

	
	// Update is called once per frame
	
}
}
