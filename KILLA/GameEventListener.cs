using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    //Adding protected means the subclasses can access these variables
    [SerializeField] protected GameEvent gameEvent;
    [SerializeField] protected UnityEvent unityEvent;


    //Register our gameEvent to the listener
    void Awake() => gameEvent.Register(gameEventListener: this);
    //Deregister when our subscriber is destroyed
    void onDestroy() => gameEvent.Deregister(gameEventListener: this);

    //Raise and Invoke the actual event
    //now virtual so the subclass is able to override this
    public virtual void RaiseEvent() => unityEvent.Invoke();

}
