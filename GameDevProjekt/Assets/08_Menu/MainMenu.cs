using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

public Button hs;

    public void Update(){
        	hs.onClick.AddListener(OpenHighscore);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame() {

        Application.Quit();
    }

    public void OpenHighscore(){
        Debug.Log("Hallo");

    }

}
