using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {

	public int score;
	public float maxTime;
	public float currentTime;
	public Text scoreText;
	public Text timeText;
	public GameObject gameOver;
	public GameObject finishText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		maxTime -= Time.deltaTime;
		currentTime += Time.deltaTime;

		scoreText.text = "Score: " + score.ToString();
		timeText.text = "Time: " + maxTime.ToString();
		currentTime = maxTime - Time.deltaTime;
		
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
           if (score > PlayerPrefs.GetInt ("Points")){

            PlayerPrefs.SetInt("Points",score);
            PlayerPrefs.SetFloat("Time",currentTime);
            }        
            else{}
            StartCoroutine(Warten());
}

    IEnumerator Warten()
    {
        yield return new WaitForSeconds(2);
        LadeScene();
    }

    public void LadeScene(){
        SceneManager.LoadScene("Menu",LoadSceneMode.Single);
    }
}