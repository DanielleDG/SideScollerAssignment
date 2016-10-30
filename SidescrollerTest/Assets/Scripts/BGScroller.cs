/* File name:				BGScroller
 * Author:					Danielle De Guzman
 * Last modified by:		Danielle De Guzman
 * Date last modified:		October 10, 2016
 * Program Description:		Scrolls the background
 * Revision History:
 * */

using UnityEngine;
using System.Collections;

public class BGScroller : MonoBehaviour {

	public float speed = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 offset = new Vector2 (Time.time * speed, 0);

		Renderer renderer = GetComponent<Renderer>();
		renderer.material.mainTextureOffset = offset;
	}
}
