using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
		Debug.Log("Hallo");
	}
}
