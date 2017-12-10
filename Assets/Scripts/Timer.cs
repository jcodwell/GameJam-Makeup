using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;

public class Timer: MonoBehaviour {

	public int timeLeft = 60; //Seconds Overall
	public Text countdown; //UI Text Object


	void Start () {
		StartCoroutine("LoseTime");
		Time.timeScale = 1; //Just making sure that the timeScale is right
	}
	void Update () {

		Scene currentScene = SceneManager.GetActiveScene ();
		string scenename = currentScene.name;

		countdown.text = ("" + timeLeft); //Showing the Score on the Canvas

		if (timeLeft <= 0 && scenename == "Lev.1") {
			SceneManager.LoadScene (3);

		}

		else if (timeLeft <= 0 && scenename == "Lev.2") {
			SceneManager.LoadScene(4);
		}
	}
	//Simple Coroutine
	IEnumerator LoseTime()
	{
		while (true) {
			yield return new WaitForSeconds (1);
			timeLeft--; 
		}
	


	
	
	}
}