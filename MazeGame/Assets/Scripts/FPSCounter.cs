using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class FPSCounter : MonoBehaviour 
{

	public Text fpsCounter;
	
	int frameCounter = 0;
	float timeCounter = 0.0f;
	float lastFPS = 0.0f;
	float refreshTime = 0.25f;

	// Use this for initialization
	void Start () 
	{
		fpsCounter = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.V)) // Toggles the FPSCounter
		{
			fpsCounter.enabled = !fpsCounter.enabled;
		}
		
		/* FPS CALCULATIONS */
		if (timeCounter < refreshTime)
		{
			timeCounter += Time.deltaTime;
			frameCounter++;
		} 
		else
		{
			lastFPS = (float) frameCounter / timeCounter;
			frameCounter = 0;
			timeCounter = 0.0f;
		}
		
		double fps = Math.Round ((double)lastFPS, 1);
		
		fpsCounter.text = "FPS: " + fps.ToString ();
	}

}
