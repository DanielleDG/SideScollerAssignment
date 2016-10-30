/* File name:				CoinController
 * Author:					Danielle De Guzman
 * Last modified by:		Danielle De Guzman
 * Date last modified:		October 15, 2016
 * Program Description:		Spawns prize objects for the player to collect
 * Revision History:
 * */
using UnityEngine;
using System.Collections;

public class CoinController : MonoBehaviour {


	[SerializeField]
	public float speed;

	private Transform _transform;
	private Vector2 _currentPosition;

	private float minX = -9f;
	private float maxX = 9f;

	void Start () {
		_transform = gameObject.GetComponent<Transform>();
		_currentPosition = _transform.position;
		Reset ();
	}

	void FixedUpdate () {
		_currentPosition = _transform.position;

		_currentPosition -= new Vector2 (0, speed);
		_transform.position = _currentPosition;

		if (_currentPosition.y <= -5.3) {
			Reset ();
		}
	}

	//Reset the coin object when it goes past this given point
	public void Reset(){
		float xPos = Random.Range(minX, maxX);
		_currentPosition = new Vector2 (xPos, 5.3f);
		_transform.position = _currentPosition;
	}


	}

