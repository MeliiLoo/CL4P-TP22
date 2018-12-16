using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dynamicFireaball2 : MonoBehaviour {

private Vector2 newForce;
private Rigidbody2D firi;

	// Use this for initialization
	void Start () {
		firi = gameObject.GetComponent<Rigidbody2D>();
	}
	public
	// Update is called once per frame
	void Update () {

		newForce = new Vector2(-5,0);
	   	firi.AddForce(newForce, ForceMode2D.Impulse);
	}
}