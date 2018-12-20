using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySkills : MonoBehaviour {

    [SerializeField]
    private int Health;
    [SerializeField]
    private GameObject Weapon;
    [SerializeField]
    private GameObject Weapon1;
    [SerializeField]
    private float speed;
    [SerializeField]
    private int length;
    [SerializeField]
    private GameControl gameCo;

    // private GameObject body;
    private Vector3 startPos;
    private Vector3 newPos;
    private Vector3 tempPos;
    private SpriteRenderer sr;
    private Vector3 ls;
    public Launcher launchiX;
    public Launcher launchiY;
    private float fireDelay = 1f;
    private bool canShoot = true;

    void Start() {
        // GameObject und SpriteRenderer holen
        // body = gameObject.GetComponent<GameObject>();
        sr = gameObject.GetComponent<SpriteRenderer>();
        //Position holen
        startPos = transform.position;
    }

    void Update() {
        // automatisches hin und her laufen	
        newPos = startPos;
        newPos.x = newPos.x + Mathf.PingPong(Time.time * speed, length) - 3;

        transform.position = newPos;

        // Flippen von Charakter
        if (newPos.x > tempPos.x) {
            sr.flipX = false;
        }
        else
        {
            sr.flipX = true;
        }
        tempPos = newPos;



        // position holen
        if (Weapon) {
            if (sr.flipX == false) {
                ls = launchiY.transform.position;
                shootL();
            }
            else {
                ls = launchiX.transform.position;
                shootR();
            }
        }

        //Sterben
        if (Health < 1)
        {
                Destroy(this.gameObject);
                gameCo.score += 2;
          
        }


    }


   
  
		
   

public void shootL(){
	if(canShoot){
			Instantiate(Weapon,
            ls,
            Quaternion.identity);
			canShoot = false;
			StartCoroutine(Delay());
	}
}

public void shootR(){
	if(canShoot){
			Instantiate(Weapon1,
            ls,
            Quaternion.identity);
			canShoot = false;
			StartCoroutine(Delay());
	}
}

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(fireDelay);
        canShoot = true;
    }

    public void TakeDamage(int damage) {

        Health -= damage; 
    }



}