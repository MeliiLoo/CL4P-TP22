using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

   
    [SerializeField]
    private Animator animator;

    float moveSpeed;
    float jumpForce;
    bool isJumping;

    public GameObject rbo2, rbo3, rbo4;

    Rigidbody2D rb;
    Rigidbody2D rb2;
    Rigidbody2D rb3;
    Rigidbody2D rb4;

    // Use this for initialization
    void Start()
    {
        rb = rbo2.GetComponent<Rigidbody2D>();
        rb2 = GetComponent<Rigidbody2D>();
        rb3 = rbo3.GetComponent<Rigidbody2D>();
        rb4 = rbo4.GetComponent<Rigidbody2D>();


    }


    void FixedUpdate()
        {
            moveSpeed = gameObject.GetComponent<ChangeCharacter>().moveSpeed;
            jumpForce = gameObject.GetComponent<ChangeCharacter>().jumpForce;

            float xEingabe = Input.GetAxis("Horizontal");
            float yEingabe = Input.GetAxis("Vertical");
        if (yEingabe < 0 | yEingabe > 0)
        {
            return;
        }
      



        float xNeu = transform.position.x +
         xEingabe * moveSpeed * Time.deltaTime;


        float yNeu = transform.position.y +
            yEingabe * jumpForce * Time.deltaTime;

        transform.position = new Vector3(xNeu, yNeu, 0);

       
        //animator.SetFloat("Speed", Mathf.Abs((move));

        Jump();
        }

        void Jump()
        {
            if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
            {
                isJumping = true;

                //animator.SetBool("IsJumping", true);

                rb.AddForce(new Vector2(rb.velocity.x, jumpForce));
                rb2.AddForce(new Vector2(rb2.velocity.x, jumpForce));
                rb3.AddForce(new Vector2(rb3.velocity.x, jumpForce));
                rb4.AddForce(new Vector2(rb4.velocity.x, jumpForce));
        }
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Ground"))
            {
                isJumping = false;

                //animator.SetBool("IsJumping", false);

                rb.velocity = Vector2.zero;
                rb2.velocity = Vector2.zero;
                rb3.velocity = Vector2.zero;
                rb4.velocity = Vector2.zero;
        }






     

    }
    }




    


