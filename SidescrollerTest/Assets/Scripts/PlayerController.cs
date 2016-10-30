/* File name:				PlayerController
 * Author:					Danielle De Guzman
 * Last modified by:		Danielle De Guzman
 * Date last modified:		October 15, 2016
 * Program Description:		Controls left/right player movement and establishes
 * 							game boundaries so player cannot move past that point
 * Revision History:
 * */
using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	[SerializeField]
	private float speed = 0;
	private Transform transform;
	private Vector2 currentPosition;
	private float playerInput;

	void Start () {

		transform = gameObject.GetComponent<Transform>();
		currentPosition = transform.position;
	}


	void FixedUpdate () {

		playerInput = Input.GetAxis ("Horizontal");

		currentPosition = transform.position;

		//move right
		if (playerInput > 0) {
			currentPosition += new Vector2 (speed, 0);
		}
		//move left
		if (playerInput < 0) {
			currentPosition -= new Vector2 (speed, 0);
		}

		checkBounds ();
		transform.position = currentPosition;
	}

	/*Method to check and ensure that the player can't go beyond the set bounds*/
	private void checkBounds(){

		if (currentPosition.x < -6.9f) {
			currentPosition.x = -6.9f;
		}
		if (currentPosition.x > 2.06f) {
			currentPosition.x = 2.06f;
		}
	}
}
