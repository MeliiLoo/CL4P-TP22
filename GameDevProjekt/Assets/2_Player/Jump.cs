using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField]
    private Animator animator;

    float jumpSpeed;
    bool isJumping;

    Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        jumpSpeed = gameObject.GetComponent<ChangeCharacter>().jumpSpeed;
        Juump();

    }

    void Juump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            isJumping = true;
            animator.SetBool("IsJumping", true);

            rb.AddForce(new Vector2(rb.velocity.x, jumpSpeed));
        }
    }
    public void OnCollisionEnter2D(Collision2D otherObject)
    {
        if (otherObject.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
            animator.SetBool("IsJumping", false);


            rb.velocity = Vector2.zero;

        }
    }
}
