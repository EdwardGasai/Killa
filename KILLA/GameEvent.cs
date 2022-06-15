using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
//This script allows us to create a new object from the asset menu
[CreateAssetMenu(menuName = "Game Event", fileName = "New Game Event")]

public class GameEvent : ScriptableObject
{
    HashSet<GameEventListener> listeners = new HashSet<GameEventListener>();

    public void Invoke()
    {
        foreach (var globalEventListener in listeners)
            globalEventListener.RaiseEvent();
    }

    private void RaiseEvent()
    {
        throw new NotImplementedException();
    }

    public void Register(GameEventListener gameEventListener) => listeners.Add(gameEventListener);

    public void Deregister(GameEventListener gameEventListener) => listeners.Remove(gameEventListener);


}

