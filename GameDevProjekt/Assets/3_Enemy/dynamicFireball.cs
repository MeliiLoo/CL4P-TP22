using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dynamicFireball : MonoBehaviour {

private Vector3 posi;
private Rigidbody2D firi;

	// Use this for initialization
	void Start () {
		firi = gameObject.AddComponent<Rigidbody2D>();
		posi = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	firi.AddForce(new Vector2(50,0));
		
	}
}
