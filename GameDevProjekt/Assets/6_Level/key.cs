using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class key : MonoBehaviour {

    public int gotKey = 0;
    [SerializeField]
    private GameObject key1;

   

        private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            key1.gameObject.SetActive(false);
            gotKey = 1;
            

        }
    }
}
