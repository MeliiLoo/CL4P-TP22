using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        // Hier bekommen wir die Position 
		launchPos = GameObject.Find("Launcher").transform.position;
        PlayEnemy1();
		PlayEnemy2();
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

