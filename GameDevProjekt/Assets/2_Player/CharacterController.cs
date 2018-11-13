using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    [SerializeField]
    private Character character;
    [SerializeField]
    private Animator animator;

    private float moveSpeed;
    private float jumpForce;
    bool isJumping;

    Rigidbody2D rb;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        moveSpeed = character.speed;
        jumpForce = character.jump;
    

        float move = Input.GetAxis("Horizontal"); // -1 left or a - 1 right or d
        rb.velocity = new Vector2(moveSpeed * move, rb.velocity.y);
        animator.SetFloat("Moving",Mathf.Abs(move));

        Jump();
    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            isJumping = true;
            animator.SetBool("IsJumping", true);

            rb.AddForce(new Vector2(rb.velocity.x, jumpForce));
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


