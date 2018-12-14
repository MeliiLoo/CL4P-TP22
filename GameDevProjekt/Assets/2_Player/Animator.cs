using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour {

    [SerializeField]
    private Animator animator;

    bool isJumping;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        isJumping = GameObject.Find("Players").GetComponent<CharacterController>().isJumping;
        if (isJumping == true)
        {
            animator.SetBool("IsJumping", true);

        }
        else
        {
            animator.SetBool("IsJumping", false);
        }
    }
}
