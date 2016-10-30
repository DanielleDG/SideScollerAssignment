/* File name:				Player Collider
 * Author:					Danielle De Guzman
 * Last modified by:		Danielle De Guzman
 * Date last modified:		October 25, 2016
 * Program Description:		Detects player collisions with prize/enemy objects. Logs
 * 							all collisions and updates player health/points accordingly.
 * Revision History:
 * */

using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour {

	[SerializeField]
	public GameObject fire = null;

	//Detect collisions with other gameObjects. Log and update health/points as needed.
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "prize") {
			Debug.Log ("Collision with "+ other.gameObject.tag);
			Player.Instance.Points += 10;
			AudioSource coinSound =
				gameObject.GetComponent<AudioSource> ();
			if (coinSound != null) {
				coinSound.Play ();
			}
		} else if(other.gameObject.tag == "fire") {
			Debug.Log ("Collision with " + other.gameObject.tag);
			Player.Instance.Health -= 10;
			AudioSource fireSound =
				fire.GetComponent<AudioSource> ();
			if (fireSound != null) {
				fireSound.Play ();
			}
		}
			
		CoinController sp = other.gameObject.GetComponent<CoinController> ();

		if (sp != null) {
			sp.Reset ();
		}


	}
		
}
