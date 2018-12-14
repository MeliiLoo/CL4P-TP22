using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Water : MonoBehaviour {

    //Players myPlayer;
    public int score;
    public float time;
    public GameObject gameOver;
    
	void Start () {
  
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            time = Time.realtimeSinceStartup;
            savePoints();
        }
        else { }
    }

private void savePoints(){
           if (score > PlayerPrefs.GetInt ("Points")){

            PlayerPrefs.SetInt("Points",score);
            PlayerPrefs.SetFloat("Time",time);
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


