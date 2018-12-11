using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class key : MonoBehaviour {

    public int gotKey;

    [SerializeField]
    private GameObject keyObject;


    private void OnTriggerEnter2D(Collider2D collision)
    {
      
  
        if (collision.gameObject.CompareTag("Player"))
        {
            
            
            keyObject.gameObject.SetActive(false);
            gotKey = 1;


        }
    }
}
