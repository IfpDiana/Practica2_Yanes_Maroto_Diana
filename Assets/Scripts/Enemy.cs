using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public GameObject target; //le damos una clase que sea target, básicamente, el objetivo que va a perseguir.
    public float Enemyspeed = 3.0f;
    private NavMeshAgent nAgent; //esto es la malla de navegación.

    private void Start()
    {
        nAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if(nAgent)
        {
            nAgent.SetDestination(target.transform.position);
        }
    }
}
