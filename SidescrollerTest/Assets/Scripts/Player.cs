/* File name:				Player
 * Author:					Danielle De Guzman
 * Last modified by:		Danielle De Guzman
 * Date last modified:		October 28, 2016
 * Program Description:		Singleton class to manage player points and health
 * Revision History:
 * */
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player{

		private int _points = 0;
		private int _health = 100;

		public HUDController hud;

		private static Player _instance = null;
		public static Player Instance{

			get{ 
				if (_instance == null) {

					_instance = new Player ();
				}
				return _instance;
			}
		}

		private Player(){
		}

		public int Points{
			get{ 
				return _points;
			}

			set{ 
				_points = value;

				//Update UI
				hud.UpdatePoints();
			}
		}

		public int Health{
			get{ 
				return _health;
			}

			set{ 
				_health = value;

				//Update UI
				hud.UpdateHealth();
				if (_health <= 0){
				hud.GameOver ();
			}
		}
		}


}
