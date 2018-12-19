using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {

	public int score;
	public float maxTime;
	public float currentTime;
	public int gotKey;
	public Text scoreText;
	public Text timeText;
	public Text keyText;
	public GameObject gameOver;
	public GameObject finishText;
	

	// Use this for initialization
	void Start () {
		if(SceneManager.GetActiveScene().name == "Scene_2"){
    		score = PlayerPrefs.GetInt("tempScore");
			currentTime = PlayerPrefs.GetFloat("tempTime"); 
            gotKey = PlayerPrefs.GetInt("tempKey");

		}
	}
	
	// Update is called once per frame
	void Update () {

		maxTime -= Time.deltaTime;
		currentTime += Time.deltaTime;

		scoreText.text = "Score: " + score.ToString();
		timeText.text = "Time: " + maxTime.ToString();
 		keyText.text = "Key: " + gotKey + "/ 3".ToString();       
				
		if(maxTime <= 0.0f)
		{
			timerEnded();
		}
	}

 
private void timerEnded()
 {

	gameOver.SetActive(true);
	savePoints();
 }

public void savePoints(){
           if (score > PlayerPrefs.GetInt("Points")){

            PlayerPrefs.SetInt("Points",score);
            PlayerPrefs.SetFloat("Time",currentTime);
            }        
            else{}
            StartCoroutine(Warten());
}

    IEnumerator Warten(){
        yield return new WaitForSeconds(2);
        LadeScene();
    }

    public void LadeScene(){
        SceneManager.LoadScene("Menu",LoadSceneMode.Single);
    }
}