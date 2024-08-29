using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public List<EventStruct> eventList;
    [SerializeField]
    private GameObject player;

    // EventStruct
    [System.Serializable]
    public struct EventStruct
    {
        public string eventName;
        public Vector3 callPos;
        public float eventDuration;
        // EventObject is the object that has the event abstract class that will be called
        public GameObject eventObject;
    }

    void Awake()
    {
        eventList = new List<EventStruct>();
    }

    void Start()
    {

    }

    void Update()
    {

    }
}
