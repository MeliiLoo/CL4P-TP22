using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour {

    public int key;
    public GameObject finish;
    public GameControl gmc;

   

    void Update()
    {
        key = GameObject.Find("Key1").GetComponent<key>().gotKey;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player") && key == 3){
        finish.SetActive(true);
        gmc.savePoints();
}
        if (other.gameObject.CompareTag("Player") && key > 0){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
	}
}
}
