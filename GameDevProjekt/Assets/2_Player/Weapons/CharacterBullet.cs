using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBullet : MonoBehaviour
{


    [SerializeField]
    private float speed = 15f;
    [SerializeField]
    private Rigidbody2D rb;
    [SerializeField]
    private int damage = 10;
    [SerializeField]
    private GameObject bulletImpact;

    // Use this for initialization
    void Start()
    {
        rb.velocity = transform.right * speed;

    }

    void OnTriggerEnter2D(Collider2D hit)
    {
        EnemySkills enemy = hit.GetComponent<EnemySkills>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            Destroy(this.gameObject);

        }

    }
}
    

