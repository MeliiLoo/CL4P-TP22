using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character2Health : MonoBehaviour
{
    [SerializeField]
    private Character character;
    

    public bool isDead;

    public float health;
    public float maxHealth;

    public Image healthBar;


   void Start()
    {
        maxHealth = character.health;
        health = maxHealth;
        
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
                    health -= 10;
                    HealthBar();

                    if (health < 1)
                    {
                        isDead = true;
                        
                    }



                }
            }
        }
    }

    public void HealthBar() {

        healthBar.fillAmount = health/maxHealth;

    }
}

