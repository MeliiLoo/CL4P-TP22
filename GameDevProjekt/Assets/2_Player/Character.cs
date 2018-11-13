using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character", menuName = "Character")]
public class Character : ScriptableObject {

	public new string name;
    public string description;

    public Sprite artwork;

    
    public int health;
    public int damage;
    public float speed;
    public int jump;

    public void Print()
    {
        Debug.Log(name + ": " + description);
            }




}
