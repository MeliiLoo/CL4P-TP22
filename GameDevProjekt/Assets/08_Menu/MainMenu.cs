using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

public Button BackToGame;
public Button Play;
public Button Highscore;
public Button Quit;

    void Update(){

        BackToGame.onClick.AddListener(OpenBackToGame);
        Play.onClick.AddListener(PlayGame);
        Highscore.onClick.AddListener(OpenHighscore);
        Quit.onClick.AddListener(QuitGame);
    }

    public void OpenBackToGame(){
    SceneManager.GetActiveScene();
    }

    public void PlayGame(){
    SceneManager.LoadScene("Scene_1", LoadSceneMode.Single);
    }

    public void QuitGame(){
        Application.Quit();
    }

    public void OpenHighscore(){
      	    SceneManager.LoadScene("Highscore", LoadSceneMode.Single);
    }

}
