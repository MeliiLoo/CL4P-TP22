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
            savePoints();
        }
        else { }
    }

private void savePoints(){

           if (gamectrl.score > PlayerPrefs.GetInt ("Points")){

            PlayerPrefs.SetInt("Points",gamectrl.score);
            PlayerPrefs.SetFloat("Time",gamectrl.currentTime);
            }        
            else{}
            gameOver.SetActive(true);
            StartCoroutine(Warten());
}

    IEnumerator Warten()
    {
        yield return new WaitForSeconds(2);
        LadeScene();
    }

    private void LadeScene(){
        SceneManager.LoadScene("Menu",LoadSceneMode.Single);
    }
}


