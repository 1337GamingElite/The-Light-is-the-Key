using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenu : MonoBehaviour 
{

	public Canvas quitPopUp;
	public Button playButton;
	public Button exitButton;

	// Use this for initialization
	void Start () 
	{
		quitPopUp = quitPopUp.GetComponent<Canvas> ();
		playButton = playButton.GetComponent<Button> ();
		exitButton = exitButton.GetComponent<Button> ();

		quitPopUp.enabled = false;
		playButton.enabled = true;
		exitButton.enabled = true;
	}
	
	public void exitPressed()
	{
		quitPopUp.enabled = true;
		playButton.enabled = false;
		exitButton.enabled = false;
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
	}

	public void yesPressed()
	{
		Application.Quit ();
	}

}
