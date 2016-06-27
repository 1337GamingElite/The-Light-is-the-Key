using UnityEngine;
using System.Collections;

public class ResetBattery : MonoBehaviour 
{

	private GameObject flashLight;
	private LightToggle battery;
	public AudioSource sound;

	void Start()
	{
		flashLight = GameObject.Find("FlashLight Light");
		battery = flashLight.GetComponent<LightToggle> ();
	}
	
	void OnTriggerEnter(Collider batteryPickUp)
	{
		if (batteryPickUp.gameObject.tag == "Battery")
		{
			battery.currentBattery = battery.maxBattery;
			float newBatteryBarValue = battery.currentBattery / battery.maxBattery;
			battery.setBatteryBar(newBatteryBarValue);
			sound.Play ();
			Destroy(batteryPickUp.gameObject);
		}
	}

}
