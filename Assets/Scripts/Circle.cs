using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using UnityEngine.SceneManagement;

public class Circle : MonoBehaviour {


	public int livesLeft = 4;
	public Text lives;

	// Use this for initialization
	void Start () {




	

	}
	
	// Update is called once per frame
	void Update () {
		
		lives.text = ("" + livesLeft);

		if (livesLeft <= 0) {
		SceneManager.LoadScene (2);
		}






	}


		void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.CompareTag("Triangle"))
			livesLeft--;

	}



}






