using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    [SerializeField] Gameevent gameEvent;
    [SerializeField] UnityEvent unityEvent;

    private void Awake()
    {
        gameEvent.Register(this);
    }
    private void OnDestroy()
    {
        gameEvent.DeRegister(this);
    }
    public void RaiseEvent() => unityEvent.Invoke();
}
