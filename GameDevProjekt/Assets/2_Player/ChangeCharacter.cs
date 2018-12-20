using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCharacter : MonoBehaviour {


    [SerializeField]
    private GameObject character1, character2, character3;
    [SerializeField]
    private Character char1, char2, char3;

    public float moveSpeed;
    public float jumpForce;
    public float health;

    int activeCharacter;

    public bool isDead1;
    public bool isDead2 = false;
    public bool isDead3 = false;

    [SerializeField]
    private GameControl gamectrl;
    [SerializeField]
    private GameObject gameOver;

    // Use this for initialization
    void Start () {

        character1.gameObject.SetActive(true);
        character2.gameObject.SetActive(false);
        character3.gameObject.SetActive(false);
        activeCharacter = 1;
        

    }

    void Update()
    {
        

        if ((Input.GetKeyDown("1") || Input.GetMouseButtonDown(0)) && activeCharacter <3)
        {
            activeCharacter++;
        }
        else if((Input.GetKeyDown("1") || Input.GetMouseButtonDown(0)) && activeCharacter >2) {
            activeCharacter = 1;
        }

        

        switch (activeCharacter)
        {
            case 1:

                

                if (!isDead1)
                {
                    character1.gameObject.SetActive(true);
                    character2.gameObject.SetActive(false);
                    character3.gameObject.SetActive(false);
                    moveSpeed = char1.speed;
                    jumpForce = char1.jump;
                    health = char1.health;

                    break;

                }

                else if (isDead1)
                {
                    character1.gameObject.SetActive(false);
                    character2.gameObject.SetActive(false);
                    character3.gameObject.SetActive(false);

                    activeCharacter = 2;

                    break;
                }

                    break;
                

                

            case 2:

                if (!isDead2)
                {
                    character1.gameObject.SetActive(false);
                    character2.gameObject.SetActive(true);
                    character3.gameObject.SetActive(false);
                    moveSpeed = char2.speed;
                    jumpForce = char2.jump;
                    health = char2.health;

                }

                else if (isDead2)
                {
                    character1.gameObject.SetActive(false);
                    character2.gameObject.SetActive(false);
                    character3.gameObject.SetActive(false);

                    activeCharacter = 3;

                    break;
                }

                break;



                case 3:


                if (!isDead3)
                {
                    character1.gameObject.SetActive(false);
                    character2.gameObject.SetActive(false);
                    character3.gameObject.SetActive(true);
                    moveSpeed = char3.speed;
                    jumpForce = char3.jump;
                    health = char3.health;

                    break;

                }

                else if (isDead3)
                {
                    character1.gameObject.SetActive(false);
                    character2.gameObject.SetActive(false);
                    character3.gameObject.SetActive(false);

                    activeCharacter = 1;

                    break;
                }

                break;
        }

        if (isDead1 && isDead2 && isDead3) {
            gameOver.SetActive(true);
            gamectrl.savePoints();
        }
    }
	
       
        
    }

