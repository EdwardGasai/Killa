using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldData : ScriptableObject
{
    //Each world has a list of locations
    public List<Location> Locations;
    //Each world has a list of Characters in that world
    public List<Character> Characters;
    //Each world has an economy
    public Economy Economy;
}
