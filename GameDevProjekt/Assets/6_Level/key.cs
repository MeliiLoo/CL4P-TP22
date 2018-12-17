﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class key : MonoBehaviour {

    public int gotKey;
    public GameControl gc;
    public int keyCounter;
    public Text keyText;

    [SerializeField]
    private GameObject keyObject;

    void Start(){
        keyCounter = 0;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
      
  
        if (collision.gameObject.CompareTag("Player"))
        {
            
            
            //keyObject.gameObject.SetActive(false);
            Destroy(this.gameObject);
            gotKey = 1;

            // für die Anzeige
            keyCounter++;
            gc.score +=10;
            keyText.text = "Key: " + keyCounter + "/ 3".ToString();
        }
    }
}
