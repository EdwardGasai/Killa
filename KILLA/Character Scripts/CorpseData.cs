using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorpseData : ScriptableObject
{
    //The person the corpse belongs to
    public CharacterData c_Data;
    //The way the person died
    public string causeOfDeath;
    //Time of Death
    public int timeOfDeath;




}
