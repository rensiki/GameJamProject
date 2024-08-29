using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EventData : MonoBehaviour
{
    public string eventName;
    public virtual void OnEvent()
    {
        Debug.Log("Event Triggered");
    }
}