using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowHighscore : MonoBehaviour {

public Text timeH;
public Text scoreH;

	// Use this for initialization
	void Start () {

		// Punkte aus PlayerPrefs holen und an Text übergeben
			scoreH.text = PlayerPrefs.GetInt("Points",0) + "  Points".ToString();
            timeH.text = PlayerPrefs.GetFloat("Time",0).ToString();
	}

}
