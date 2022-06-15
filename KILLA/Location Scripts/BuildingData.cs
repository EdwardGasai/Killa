using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingData : ScriptableObject
{
    //Name of the building
    public string buildingName;
    //People at the building currently
    public List<Character> peopleInBuilding;
    //Current population at the building
    public int currentPopulation;
    //0.0 to 100.0 How suitable the location is for committing a crime
    public float suitabilityForCrime;
    //The Building game Object
    public GameObject prefab;
}
