using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour {

    public int key;

   

    void Update()
    {
        key = GameObject.Find("Key").GetComponent<key>().gotKey;
    }
    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("Player") && key > 0){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
	}
}
}
