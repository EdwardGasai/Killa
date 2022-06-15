using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToPickup : MonoBehaviour
{
    [SerializeField] GameEvent onPickup;

    bool pickedUp;

    void OnMouseDown()
    {
        if (pickedUp == true)
            pickUp();
    }

    void pickUp()
    {
        //Invoke the GameEvent
        onPickup?.Invoke();
        pickedUp = true;
    }
}
