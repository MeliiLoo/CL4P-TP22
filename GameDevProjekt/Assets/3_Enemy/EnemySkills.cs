using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySkills : MonoBehaviour {

[SerializeField]
private int Health;
[SerializeField]
private GameObject Weapon;
[SerializeField]
private float speed;
[SerializeField]
private Rigidbody2D rigi;
private GameObject body;
private Vector3 startPos;
private Vector3 newPos;

	void Start () {
	rigi = gameObject.AddComponent<Rigidbody2D>();
	startPos = transform.position;	

	}
	
	void Update () {
	// automatisches hin und her laufen	
	newPos = startPos;
	newPos.x = newPos.x + Mathf.PingPong (Time.time * speed, 6) - 3;
	transform.position = newPos;

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

}

public void kill(){
Destroy(rigi,1f);
}


}