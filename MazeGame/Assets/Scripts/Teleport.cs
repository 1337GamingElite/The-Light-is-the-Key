using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour 
{

	public Transform destination;
	public AudioSource teleportSound;

	void OnTriggerEnter(Collider player)
	{
		if (player.tag == "Player")
		{
			teleportSound.Play ();
			player.transform.position = destination.position;
		}
	}

}