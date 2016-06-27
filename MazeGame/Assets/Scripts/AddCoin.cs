using UnityEngine;
using System.Collections;

public class AddCoin : MonoBehaviour 
{

	private GameObject coinCount;
	private CoinManager coinManager;

	public AudioSource coinSound;

	void Start()
	{
		coinCount = GameObject.Find("Coin Count");
		coinManager = coinCount.GetComponent<CoinManager> ();
	}

	void OnTriggerEnter (Collider coin)
	{
		if (coin.gameObject.tag == "Coin")
		{
			coinSound.Play ();
			coinManager.coinCount++;
			Destroy (coin.gameObject);
		}
	}
	
}
