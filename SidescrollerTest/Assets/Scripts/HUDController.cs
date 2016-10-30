/* File name:				HUDController
 * Author:					Danielle De Guzman
 * Last modified by:		Danielle De Guzman
 * Date last modified:		October 28,2016
 * Program Description:		Controls all the components of the HUD. Resets HUD back
 * 							to default state whenever Restart function is called. 
 * 							Hides all gameplay objects when GameOver function is called.
 * 							Updates points / health labels.
 * Revision History:
 * */
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUDController : MonoBehaviour {

	[SerializeField]
	Text PointsLabel = null;
	[SerializeField]
	Text HealthLabel = null;
	[SerializeField]
	GameObject player = null;
	[SerializeField]
	Button restartBtn = null;
	[SerializeField]
	Text GameOverLabel = null;
	[SerializeField]
	GameObject fire = null;
	[SerializeField]
	GameObject coin1 = null;
	[SerializeField]
	GameObject coin2 = null;
	[SerializeField]
	GameObject coin3 = null;

	public void UpdatePoints(){

		PointsLabel.text = "Points: " + Player.Instance.Points;

	}

	public void UpdateHealth(){

		HealthLabel.text = "Health: " + Player.Instance.Health;
	}
		
	void Start () {
		Player.Instance.hud = this;
		Restart ();
	}

	//Make everything but the GameOverLabel and the restartBtn hidden to the player
	public void GameOver(){
		PointsLabel.gameObject.SetActive (false);
		HealthLabel.gameObject.SetActive (false);
		player.SetActive (false);
		fire.SetActive (false);
		coin1.SetActive (false);
		coin2.SetActive (false);
		coin3.SetActive (false);

		restartBtn.gameObject.SetActive (true);
		GameOverLabel.gameObject.SetActive (true);


	}

	//Make everything but the GameOverLabel and the restartBtn visible to the player. Reset points back to 0 and health back to 100
	public void Restart(){
		PointsLabel.gameObject.SetActive (true);
		HealthLabel.gameObject.SetActive (true);
		player.SetActive (true);
		fire.SetActive (true);
		coin1.SetActive (true);
		coin2.SetActive (true);
		coin3.SetActive (true);

		Player.Instance.Points = 0;
		Player.Instance.Health = 100;

		restartBtn.gameObject.SetActive (false);
		GameOverLabel.gameObject.SetActive (false);
	}





}
