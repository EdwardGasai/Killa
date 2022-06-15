using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location : MonoBehaviour
{
    public static Location current;
    public LocationData l_data;


    void Start()
    {
        current = this;
    }

    public int getNumberOfCharactersOccupying(LocationData data)
    {
        int i = 0;
        //Get the number of occupants for each building a the location
        foreach (Building b in data.buildings)
        {
            i += b.getNumberOfCharactersOccupying(b.b_data);
        }
        //Add the people not in buildings but at the location
        return i+l_data.currentPopulation;
    }
}
