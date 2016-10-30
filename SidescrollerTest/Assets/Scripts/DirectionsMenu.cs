/* File name:				DirectionsMenu
 * Author:					Danielle De Guzman
 * Last modified by:		Danielle De Guzman
 * Date last modified:		October 20, 2016
 * Program Description:		Redirects user back to Start Menu after going to the 
 * 							Directions section
 * Revision History:
 * */

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DirectionsMenu : MonoBehaviour {

	[SerializeField]
	Button backToMain = null;

	public void BackToMain(){
		SceneManager.LoadScene ("WelcomeScreen");
	}

}
