using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : ScriptableObject
{
    //Inventory ID
    public string id;
    //Name of item to be displayed
    public string displayName;
    //Pre fab for the game
    public GameObject prefab;
}
