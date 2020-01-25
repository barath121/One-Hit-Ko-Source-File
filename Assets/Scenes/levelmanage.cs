using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelmanage : MonoBehaviour {
	
	// Use this for initialization

	public static bool res=true;
	public void LoadLevel (string name) {
        sliders.player_health = 100;
        stamina.total = 0;
        gameover.por = true;
        Application.LoadLevel (name);
			
			}
	public void Quitrequest()
	{
		Application.Quit ();
	}
	}
