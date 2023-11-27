using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class follow : MonoBehaviour
{
    public Transform target;
    Vector3 Thedestanition;
    NavMeshAgent agent;

    void Start()
    {
        // Cache agent component and destination
        agent = GetComponent<NavMeshAgent>();
        Thedestanition = agent.destination;
    }

    void Update()
    {
        // Update destination if the target moves one unit
        if (Vector3.Distance(Thedestanition, target.position) > 2.0f)
        {
            Thedestanition = target.position;
            agent.destination = Thedestanition;
        }
    }
}