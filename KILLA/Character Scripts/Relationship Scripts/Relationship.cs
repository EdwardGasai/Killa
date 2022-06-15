using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//When the character meets a new person, a relationship is created
//Used to manipulate the data
public class Relationship : MonoBehaviour
{
    RelationshipData data;

    private static Relationship current;

    
    void Start()
    {
        current = this;
    }


    //COULD SWITCH THIS TO SWITCH CASES?
    public void updateRelationshipLevel(float amount)
    {
        float currentLevel = data.relationshipLevel;

        float newLevel = data.relationshipLevel += amount;

        //If there was a positive interaction
        if(newLevel - currentLevel > 0.0f)
        {
            data.numberOfPositiveInteractions++;
        }
        //If there was a negative interaction
        else if(newLevel - currentLevel < 0.0f)
        {
            data.numberOfNegativeInteractions++;
        }

        //Add the amount
        data.relationshipLevel += amount;

        //Make sure it's not over 100
        if (data.relationshipLevel > 100.0f)
        {
            data.relationshipLevel = 100.0f;
        }
        //Make sure it's not negative
        if(data.relationshipLevel < 0.0f)
        {
            data.relationshipLevel = 0.0f;
        }
    }


   
    


}
