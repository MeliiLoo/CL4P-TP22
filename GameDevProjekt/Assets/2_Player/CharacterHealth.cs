using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterHealth : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        JumpDeath enemy = collision.collider.GetComponent<JumpDeath>();

        if (enemy != null)
        {
            foreach (ContactPoint2D point in collision.contacts)
            {
                if (point.normal.y >= 0.9f)
                {

                    enemy.Death();
                }
                else
                {
                    //normaleris lebe abzoge etz nur reload vode scene
                    Application.LoadLevel(Application.loadedLevel);
                }
            }
        }
    }
}

