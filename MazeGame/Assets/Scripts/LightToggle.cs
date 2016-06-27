using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LightToggle : MonoBehaviour 
{

	public Light flashLight;
	private AudioSource soundPlayer;
	public static bool isOn;

	public float maxBattery = 100f;
	public float currentBattery = 0;
	public GameObject batteryBar;

	void Start()
	{
		currentBattery = maxBattery;
		soundPlayer = GetComponent<AudioSource> ();
		InvokeRepeating ("decreaseBattery", 1f, 1f);
	}

	void Update() 
	{		
		isOn = flashLight.enabled;
		if (Input.GetMouseButtonDown(0) && currentBattery > 0)
		{
			flashLight.enabled = !flashLight.enabled;
			soundPlayer.Play ();
		}

		if (currentBattery <= 0) 
		{
			flashLight.enabled = false;
		}
	}

	void decreaseBattery()
	{
		if (currentBattery > 0 && isOn == true)
		{
			currentBattery -= 1;
			float batteryBarValue = currentBattery / maxBattery;
			setBatteryBar (batteryBarValue);
		}
	}

	public void setBatteryBar(float battery)
	{
		// Battery needs to be a value between 0-1
		batteryBar.transform.localScale = new Vector3 (battery, batteryBar.transform.localScale.y, batteryBar.transform.localScale.z);
	}
	
}