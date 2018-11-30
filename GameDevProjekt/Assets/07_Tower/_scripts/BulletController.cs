using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

	// bullet neu erstellt: direkt eine Geschwindigkeit mitgeben

	
	[SerializeField]
	private int speed; 

	private void Start() {

	GetComponent<Rigidbody>().AddForce(Vector3.forward*speed, ForceMode.Impulse);  
	}
}
