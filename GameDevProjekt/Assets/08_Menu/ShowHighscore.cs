using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowHighscore : MonoBehaviour {

public Text timeH;
public Text scoreH;

	// Use this for initialization
	void Awake () {

		// Punkte aus PlayerPrefs holen und an Text übergeben
			scoreH.text = PlayerPrefs.GetInt("Points") + "  Points".ToString();
            timeH.text = PlayerPrefs.GetFloat("Time") + " Sec".ToString();
	}

}
