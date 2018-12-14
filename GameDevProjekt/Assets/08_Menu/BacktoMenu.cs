using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BacktoMenu : MonoBehaviour {

	public Button back;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		back.onClick.AddListener(BackToMenu);
		
	}

	public void BackToMenu(){
    	    SceneManager.LoadScene("Menu", LoadSceneMode.Single);
	}
}
