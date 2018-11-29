using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour {

private Vector2 launchPos;
[SerializeField]
private Launcher ls;
[SerializeField]
private GameObject Body1;
[SerializeField]
private GameObject Body2;

    void Start ()
    {
        Scene scene = SceneManager.GetActiveScene();
        // Hier bekommen wir die Position 
		launchPos = GameObject.Find("Launcher").transform.position;

        // Anhand Scene entscheiden, welchen Level
        if(scene.name == "Scene_1"){
        PlayEnemy1();
        }
        if(scene.name == "Scene_2"){
		PlayEnemy2();
        }
    }

    // Vereinfachung
    void FixedUpdate()
    {

    }

public void PlayEnemy1 ()
{
            Instantiate(Body1,
            launchPos,
            Quaternion.identity);
}
public void PlayEnemy2 ()
{
            Instantiate(Body2,
            launchPos,
            Quaternion.identity);
}

}

