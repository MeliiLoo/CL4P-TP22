﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySkills : MonoBehaviour {

[SerializeField]
private int Health;
[SerializeField]
private GameObject Weapon;
[SerializeField]
private float speed;
[SerializeField]
private int length;
private Rigidbody2D rigi;
//private GameObject body;
private Vector3 startPos;
private Vector3 newPos;
private Vector3 ls;
private Scene scene;
public GameObject dynamicFireball;



	void Start () {
	// Szene holen
	Scene scene = SceneManager.GetActiveScene();
	// Rigidbody
	rigi = gameObject.AddComponent<Rigidbody2D>();
	//body = gameObject.AddComponent<GameObject>();
	//Position holen
	startPos = transform.position;	
	ls = GameObject.Find("Launcher").transform.position;
	}
	
	void Update () {
	// automatisches hin und her laufen	
	newPos = startPos;
	newPos.x = newPos.x + Mathf.PingPong (Time.time * speed, length) - 3;
	transform.position = newPos;

	//schiessen
	if(scene.name == "Scene_1"){
		shoot();
	}

	// Wenn Lebenspunkte aufgebraucht
	if(1 > Health){
			kill();
		}
}


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if(Health > 0)
			Health-=1;
        }
}

public void shoot(){
			Instantiate(Weapon,
            ls,
            Quaternion.identity,
			dynamicFireball.transform);
			//Weapon.addForce(100,0);
}

public void kill(){
Destroy(rigi,1f);
}


}