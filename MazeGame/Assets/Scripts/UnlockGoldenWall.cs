using UnityEngine;
using System.Collections;

public class UnlockGoldenWall : MonoBehaviour 
{

	private GameObject coinCount;
	public GameObject goldenWall;
	private CoinManager coinManager;
	
	void Start()
	{
		coinCount = GameObject.Find("Coin Count");
		coinManager = coinCount.GetComponent<CoinManager> ();
	}

	void Update()
	{
		if (coinManager.coinCount >= coinManager.lvlCoinCount)
		{
			goldenWall.SetActive (false);
		}
	}
}
