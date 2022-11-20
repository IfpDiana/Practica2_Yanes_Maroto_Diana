using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "Idle", menuName = "ScriptableObjects/States/Idle")]//Esto lo hacemos para poder hacer el ScriptableObject en el control de Unity

public class Idle : State
{
    private Color matColor = Color.green; //Aquí le estamos diciendo que tenga el color verde.
    public override State Run(GameObject owner) //el override toma preferencia al prefab.
    {
        if (owner.GetComponent<MeshRenderer>()) owner.GetComponent<MeshRenderer>().material.color = matColor; //esto es para los colores.
        owner.GetComponent<NavMeshAgent>().SetDestination(owner.transform.position); //esto hace que se quede quieto cuando llega a Idle.

        if (action.Check(owner)) //si hace un Check del owner, le mandará hacer el siguiente estado.
        {
            return nextState; //Aquí se le dice que estás devolviendo el siguiente estado.
        }
        return null; //Si es null, el enemigo volverá al sitio donde estaba o dejará de perseguir.
    }
}
