using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "Idle", menuName = "ScriptableObjects/States/Idle")]//Esto lo hacemos para poder hacer el ScriptableObject en el control de Unity

public class Idle : State
{
    private Color matColor = Color.green; //Aqu� le estamos diciendo que tenga el color verde.
    public override State Run(GameObject owner) //el override toma preferencia al prefab.
    {
        if (owner.GetComponent<MeshRenderer>()) owner.GetComponent<MeshRenderer>().material.color = matColor; //esto es para los colores.
        owner.GetComponent<NavMeshAgent>().SetDestination(owner.transform.position); //esto hace que se quede quieto cuando llega a Idle.

        if (action.Check(owner)) //si hace un Check del owner, le mandar� hacer el siguiente estado.
        {
            return nextState; //Aqu� se le dice que est�s devolviendo el siguiente estado.
        }
        return null; //Si es null, el enemigo volver� al sitio donde estaba o dejar� de perseguir.
    }
}
