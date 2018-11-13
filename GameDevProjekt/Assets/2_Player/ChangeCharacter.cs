using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCharacter : MonoBehaviour {


    [SerializeField]
    private GameObject character1, character2, character3;

    int activeCharacter;

	// Use this for initialization
	void Start () {

        character1.gameObject.SetActive(true);
        character2.gameObject.SetActive(false);
        character3.gameObject.SetActive(false);
        activeCharacter = 1;
    }

    void Update()
    {


        if (Input.GetKeyDown("1") && activeCharacter <3)
        {
            activeCharacter++;
        }
        else if(Input.GetKeyDown("1") && activeCharacter >2) {
            activeCharacter = 1;
        }

        switch (activeCharacter)
        {
            case 1:


                
                character1.gameObject.SetActive(true);
                character2.gameObject.SetActive(false);
                character3.gameObject.SetActive(false);
                break;

            case 2:

                

                character1.gameObject.SetActive(false);
                character2.gameObject.SetActive(true);
                character3.gameObject.SetActive(false);
                break;

            case 3:



                character1.gameObject.SetActive(false);
                character2.gameObject.SetActive(false);
                character3.gameObject.SetActive(true);
                break;
        }
    }
	
       
        
    }

