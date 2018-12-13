using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour {


 public Button Home;
 
	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
	Home.onClick.AddListener(OpenMenu);
	}

	void OpenMenu(){
  	SceneManager.LoadScene("Menu", LoadSceneMode.Additive);
	}
}
