using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddBonus : MonoBehaviour {

	public GameObject Heart;
	private int live;
	public Character1Health play1;
	public GameObject play1G;
	public Character2Health play2;
	public GameObject play2G;
	public Character3Health play3;
	public GameObject play3G;
	
	
	// Use this for initialization
	void Start () {
	}
	
	private void OnTriggerEnter2D(Collider2D collision){
       
        if (collision.gameObject.CompareTag("Player"))
        {       
            Heart.gameObject.SetActive(false);
            live = 10;
			
			if(play1G.gameObject.activeSelf==true){
			play1.health += live;
			play1.HealthBar();
		}
			if(play2G.gameObject.activeSelf==true){
			play2.health += live;
			play2.HealthBar();
			}

			if(play3G.gameObject.activeSelf==true){
			play3.health += live;
			play3.HealthBar();
        }
		else{}
	}
}
}