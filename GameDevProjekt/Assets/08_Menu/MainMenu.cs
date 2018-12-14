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

    public void Update(){
        BackToGame.onCllick.AddListener(BackToGame);
        Play.onCllick.AddListener(PlayGame);
        Highscore.onCllick.AddListener(OpenHighscore);
        Quit.onCllick.AddListener(QuitGame);
    }

    public void BackToGame(){
    SceneManager.LoadScene(SceneManager.GetActiveScene());
    }

    public void PlayGame(){
    SceneManager.LoadScene("Scene_1", LoadSceneMode.Single);
    }

    public void QuitGame(){
        Application.Quit();
    }

    public void OpenHighscore(){
      	    SceneManager.LoadScene("Highscore", LoadSceneMode.Additive);
    }

}
