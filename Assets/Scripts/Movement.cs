using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Movement : MonoBehaviour {

	public float walkSpeed = 3f;
	public float jumpPower = 1000f;
	//public HealthBar playerhealth;
	public float timer = 0f;

	private Rigidbody2D theRigidbody;


	// Use this for initialization
	void Start () {

		theRigidbody = GetComponent<Rigidbody2D> ();



	}

	// Update is called once per frame
	void Update () {




		float inputX = Input.GetAxis ("Horizontal");
		theRigidbody.velocity = new Vector2 (inputX * walkSpeed, theRigidbody.velocity.y);

		if (Input.GetKeyDown (KeyCode.LeftShift)) {
			walkSpeed += 5f;

		}

		if (Input.GetKeyUp (KeyCode.LeftShift)) {
			walkSpeed -= 5f;

		}
		bool jumping = Input.GetButtonDown ("Jump");

		if (jumping) {

			theRigidbody.velocity = new Vector2 (theRigidbody.velocity.x, 0f);
			theRigidbody.AddForce (new Vector2 (0, jumpPower));
			jumping = false;


		}

	}


}