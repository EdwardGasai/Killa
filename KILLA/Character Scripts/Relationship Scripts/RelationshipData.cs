using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelationshipData : ScriptableObject
{
    //Relationship level 0.0 to 100.0
    public float relationshipLevel;

    //Keeps track of positve interactions
    public int numberOfNegativeInteractions;

    //Keeps track of negative interactions
    public int numberOfPositiveInteractions;

}
