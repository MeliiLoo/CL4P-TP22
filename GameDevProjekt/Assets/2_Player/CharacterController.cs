﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

   
    [SerializeField]
    private Animator animator;

    float moveSpeed;
    float jumpSpeed;
    bool isJumping;

    Rigidbody2D rb;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }



    void Update()
    {

        moveSpeed = gameObject.GetComponent<ChangeCharacter>().moveSpeed;
        jumpSpeed = gameObject.GetComponent<ChangeCharacter>().jumpSpeed;

        float xEingabe = Input.GetAxis("Horizontal");
        float yEingabe = Input.GetAxis("Vertical");
        if (yEingabe < 0)
        {
            return;
        }
        if (yEingabe > 0)
        {
            return;
        }


        float xNeu = transform.position.x +
         xEingabe * moveSpeed * Time.deltaTime;
      

        float yNeu = transform.position.y +
            yEingabe * jumpSpeed* Time.deltaTime;

        transform.position = new Vector3(xNeu, yNeu, 0);


        animator.SetFloat("Moving", Mathf.Abs(xEingabe));
        Jump();





     
}
         void Jump()
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




    


