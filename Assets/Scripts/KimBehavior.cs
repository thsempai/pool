using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class KimBehavior : MonoBehaviour
{
    public Vector3 destination;
    void Update()
    {
        GetComponent<NavMeshAgent>().SetDestination(destination);
    }
}
