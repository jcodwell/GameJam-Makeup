using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {


	public Button startButton;
	public Button endButton;
	// Use this for initialization
	void Start () {
		Button btn = startButton.GetComponent<Button> ();
		btn.onClick.AddListener (startGame);	

		Button endbtn = endButton.GetComponent<Button> ();
		endbtn.onClick.AddListener (EndGame);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void startGame() {
		SceneManager.LoadScene (1);
		Debug.Log("You have clicked the button!");

	}


	void EndGame() {
		Application.Quit();
		Debug.Log("You have clicked the button!");

	}



}
