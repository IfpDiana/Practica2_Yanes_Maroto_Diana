using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WayPoints : MonoBehaviour
{
    private int waypoints = 4;

    private void Start()
    {
        GetComponent<NavMeshAgent>().SetDestination(GameObject.Find("Waypoint(0)").transform.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        waypoints += 4;
        GetComponent<NavMeshAgent>().SetDestination(GameObject.Find("Waypoint(0)"+waypoints.ToString()).transform.position);
    }
}
