using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Water : MonoBehaviour {

    public GameControl gamectrl;
    public GameObject gameOver;
    
	void Start () {
  
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameOver.SetActive(true);
            gamectrl.savePoints();
        }
        else { }
    }
}


