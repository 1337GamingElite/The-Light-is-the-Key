using UnityEngine;
using System.Collections;

public class RandomTeleport : MonoBehaviour 
{

	public Transform des1, des2, des3;
	public AudioSource teleportSound;

	private static int lastLocationNumber;

	private static int generateLocationNumber(int min, int max)
	{
		int locationNumber = Random.Range (min, max);

		if (locationNumber == lastLocationNumber)
		{
			return generateLocationNumber (min, max);
		}

		lastLocationNumber = locationNumber;
		return locationNumber;
	}

	void OnTriggerEnter(Collider player)
	{
		if (player.tag == "Player") 
		{
			teleportSound.Play ();
			int location = generateLocationNumber (1, 4);
			if (location == 1) // Des1
			{
				player.transform.position = des1.position;
			}
			if (location == 2) // Des2
			{
				player.transform.position = des2.position;
			}
			if (location == 3) // Des3
			{
				player.transform.position = des3.position;
			}
		}
	}

}
