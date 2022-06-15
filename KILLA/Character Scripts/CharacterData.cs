using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class CharacterData : ScriptableObject
{
    //Character First Name
    public string firstName;
    //Character Last Name
    public string lastName;
    //Character Icon for their profile. Currently Empty
    public Image characterIcon;
    //The GameObjectFor the person. Currently Empty
    public GameObject prefab;
    //The sex of the person, Male, Female
    public string sex;
    //The id of the person, created upon generation, should be unique
    public int id;
    //Where the character is currently located
    public Location location;
    //The home of the character
    public Location home;
    //Is the character dead?
    public bool isDead;
    //The age of the person
    public int age;
    //Everyone will try to fight back if attempted to be killed, lowered to 0 if distracted
    //or if in a vulnerable building/situtaion
    public float fightingCapability;
    //Relationships with other people, Each character has a relationship definition
    //with other characters in the world
    public Dictionary<Character, Relationship> relationships;
    //The characters mood
    public string mood;
    //The characters personality
    public string personality;
}
