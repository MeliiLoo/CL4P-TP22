using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

	// bullet neu erstellt: direkt eine Geschwindigkeit mitgeben

	
	[SerializeField]
	private int speed;
	private Vector2 force;
	private Rigidbody2D rd;

	private void Start() {

		rd = GetComponent<Rigidbody2D>();
		force = new Vector2(-1*speed,0);

	}
	private void Update(){

	rd.AddForce(force, ForceMode2D.Impulse);  
	}
}
