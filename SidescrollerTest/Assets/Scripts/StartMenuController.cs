/* File name:				StartMenuController
 * Author:					Danielle De Guzman
 * Last modified by:		Danielle De Guzman
 * Date last modified:		October 20, 2016
 * Program Description:		Directs players to either the gameplay scene or the directions
 * 							scene depending n which button they press
 * Revision History:
 * */

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenuController : MonoBehaviour {

	[SerializeField]
	Button playBtn = null;
	[SerializeField]
	Button howToBtn = null;

	public void StartGame(){
		SceneManager.LoadScene ("GameScene");
	}
	public void Directions(){
		SceneManager.LoadScene ("HelpScreen");
	}
}
