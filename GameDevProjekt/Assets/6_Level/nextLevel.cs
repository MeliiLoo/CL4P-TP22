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

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player") && gmc.gotKey == 3){
        finish.SetActive(true);
        gmc.savePoints();
}
        if (other.gameObject.CompareTag("Player") && gmc.gotKey > 0){
    		PlayerPrefs.SetInt("tempScore",gmc.score);
			PlayerPrefs.SetFloat("tempTime",gmc.currentTime); 
            PlayerPrefs.SetInt("tempKey",gmc.gotKey);

		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
	}
}
}
