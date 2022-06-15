using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class GameEventListenerWithDelay : GameEventListener
{
    [SerializeField] float delay = 1f;
    [SerializeField] UnityEvent delayedUnityEvent;

    void Awake() => gameEvent.Register(gameEventListener: this);

    void OnDestroy() => gameEvent.Deregister(gameEventListener: this);

    public override void RaiseEvent()
    {
        unityEvent.Invoke();
        //Coroutine needed since this is a MonoBehaviour
        StartCoroutine(routine: RunDelayedEvent());

    }

    private IEnumerator RunDelayedEvent()
    {
        //yield the action for the delay time
        yield return new WaitForSeconds(delay);
        delayedUnityEvent.Invoke();
    }

}
