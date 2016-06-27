using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CoinManager : MonoBehaviour 
{
	
	public int coinCount; // How many coins the player has
	public int lvlCoinCount; // How many coins the level has, Use when programming the secret door
	private Text coinText;

	void Start() 
	{
		coinText = GetComponent<Text> ();
	}

	void Update()
	{
		coinText.text = "Coins: " + coinCount.ToString ();
	}

}
