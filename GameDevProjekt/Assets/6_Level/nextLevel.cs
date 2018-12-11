using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour {

    public bool key;

   

    void Update()
    {
        key = gameObject.GetComponent<key>().gotKey;
    }
    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("Player") && key == true){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
	}
}
}
