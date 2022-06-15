using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public BuildingData b_data;
    public static Building current;

   void Start()
    {
        current = this;
    }

    //Get the number of people currently in the building
    public int getNumberOfCharactersOccupying(BuildingData data)
    {
        int i = 0;
        foreach(Character c in data.peopleInBuilding)
        {
            i++;
        }
        return i;
    }
}
