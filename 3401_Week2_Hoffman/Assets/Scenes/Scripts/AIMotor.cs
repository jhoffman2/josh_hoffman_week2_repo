using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIMotor : MonoBehaviour

   

{
    public Transform destination;
    public NavMeshAgent agent;
    public float slowDown;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(destination.position);
        agent.speed = agent.speed - Time.deltaTime * slowDown;
    }
}
