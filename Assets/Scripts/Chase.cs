using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; //recuerda que sin esto, no puedes hacer cosas con la IA.

[CreateAssetMenu(fileName = "Chase", menuName = "ScriptableObjects/States/Chase")]//Esto lo hacemos para poder hacer el ScriptableObject en el control de Unity
public class Chase : State
{
    public override State Run(GameObject owner)
    {
        GameObject obj = owner.GetComponent<PlayerReference>().player; 
        owner.GetComponent<NavMeshAgent>().SetDestination(obj.transform.position);

        if (!action.Check(owner))
        {
            return nextState;//los [] son para cuando tienes arrays.
        }

        return this;
    }
    
}
