using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dynamicFireball : MonoBehaviour {

private Vector2 newForce;
public Vector3 posi;
public Vector3 tempi;
private Rigidbody2D firi;

	// Use this for initialization
	void Start () {
		firi = gameObject.GetComponent<Rigidbody2D>();
		posi = GameObject.Find("LauncherFire").transform.position;
	}
	public
	// Update is called once per frame
	void Update () {

		if(posi.x > tempi.x){
		newForce = new Vector2(-5,0);
		}
		else
		{
			newForce = new Vector2(5,0);
		}
	   	firi.AddForce(newForce, ForceMode2D.Impulse);
		
		posi = tempi;
	}
}
