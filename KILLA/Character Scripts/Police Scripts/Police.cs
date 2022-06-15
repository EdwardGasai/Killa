using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Police : MonoBehaviour
{

    public static Police current;
    public PoliceData policeData;


    //Initialize police and assign the data
    void Start()
    {
        current = this;
        
    }


}
