using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterDisplay : MonoBehaviour {

    public Character character;

    [SerializeField]
    private Text nameText;
    [SerializeField]
    private Text descriptionText;
    [SerializeField]
    private Text healthText;
    [SerializeField]
    private Image artworkImage;



	// Use this for initialization
	void Start () {
        character.Print();

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
