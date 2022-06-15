using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationData : ScriptableObject
{
    //Name of the Location
    public string locationName;
    //Buildings at the location
    public List<Building> buildings;
    //Current population at the location
    public int currentPopulation;
    //0.0 to 100.0 How likely people are to visit this place
    public float popularity;
    //0.0 to 100.0 How suitable the location is for committing a crime
    public float suitabilityForCrime;
    //List of characters with their respective data
    public List<Character> peopleAtTheLocation;
    //Prefab for the location
    public GameObject prefab;


}
