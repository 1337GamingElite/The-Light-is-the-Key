using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenu : MonoBehaviour 
{

	public Canvas quitPopUp;
	public Canvas howToPopUp;

	// Buttons
	public Button playButton;
	public Button exitButton;
	public Button howToButton;

	// Use this for initialization
	void Start () 
	{
		quitPopUp = quitPopUp.GetComponent<Canvas> ();
		playButton = playButton.GetComponent<Button> ();
		exitButton = exitButton.GetComponent<Button> ();
		howToPopUp = howToPopUp.GetComponent<Canvas> ();
		howToButton = howToButton.GetComponent<Button> ();

		quitPopUp.enabled = false;
		howToPopUp.enabled = false;
		playButton.enabled = true;
		exitButton.enabled = true;
		howToButton.enabled = true;
	}
	
	public void exitPressed()
	{
		quitPopUp.enabled = true;
		playButton.enabled = false;
		exitButton.enabled = false;
		howToButton.enabled = false;
	}

	public void howToPressed()
	{
		howToPopUp.enabled = true;
		playButton.enabled = false;
		exitButton.enabled = false;
		howToButton.enabled = false;
	}

	public void closePressed()
	{
		howToPopUp.enabled = false;
		playButton.enabled = true;
		exitButton.enabled = true;
		howToButton.enabled = true;
	}

	public void playPressed()
	{
		SceneManager.LoadScene ("Level001");
	}

	public void noPressed()
	{
		quitPopUp.enabled = false;
		playButton.enabled = true;
		exitButton.enabled = true;
		howToButton.enabled = true;
	}

	public void yesPressed()
	{
		Application.Quit ();
	}

}
