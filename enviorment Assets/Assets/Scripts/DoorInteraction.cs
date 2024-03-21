using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoorInteraction : MonoBehaviour
{
    public UnityEvent OnDoorInteract = new UnityEvent();

    public void InteractWithDoor() { 
        OnDoorInteract.Invoke();
    }
}
