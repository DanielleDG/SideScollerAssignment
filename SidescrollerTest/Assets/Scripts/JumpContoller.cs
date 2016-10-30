/* File name:				JumpController
 * Author:					Danielle De Guzman
 * Last modified by:		Danielle De Guzman
 * Date last modified:		October 15, 2016
 * Program Description:		Controls jump movement for the player
 * Revision History:
 * */

using UnityEngine;
using System.Collections;

/**Jump script was based on a tutorial by youtuber
* gamesplusjames and modified to suit my game's
* needs.**/

public class JumpContoller : MonoBehaviour {

	/*** Setting the variables to control player's jump power and
	to check if the user is touching the ground or not.**/
	public float jumpPower;
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool isGrounded;

	void FixedUpdate(){
		isGrounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatIsGround);
	}

	/**If the player is grounded, then they are allowed to jump.
	Otherwise, if they are caught mid-air, they cannot jump**/
	void Update () {
		Rigidbody2D rb = GetComponent<Rigidbody2D> ();
		if (Input.GetKey(KeyCode.UpArrow) && isGrounded)
			rb.AddForce(Vector2.up * jumpPower);

	}

}

