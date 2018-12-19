using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCoin : MonoBehaviour {

	public GameControl gm;
	public GameObject coin;

	// Use this for initialization
	void Start () {
		
	}
	private void OnTriggerEnter2D(Collider2D collision){
       
        if (collision.gameObject.CompareTag("Player"))
        { 
		Destroy(this.gameObject);
		gm.score +=3;
		}
}
}