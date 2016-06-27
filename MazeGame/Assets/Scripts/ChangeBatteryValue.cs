using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangeBatteryValue : MonoBehaviour 
{

	private GameObject flashLight;
	private LightToggle lightToggle;
	private Text batteryValue;

	// Use this for initialization
	void Start () 
	{
		flashLight = GameObject.Find ("FlashLight Light");
		lightToggle = flashLight.GetComponent<LightToggle> ();
		batteryValue = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		batteryValue.text = lightToggle.currentBattery.ToString ();
	}

}
