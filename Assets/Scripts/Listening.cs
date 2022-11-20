using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Listening", menuName = "ScriptableObjects/States/Listening")]//Esto lo hacemos para poder hacer el ScriptableObject en el control de Unity

public class Listening : Action
{
    public override bool Check(GameObject owner)
    {
        RaycastHit[] info = Physics.SphereCastAll(owner.transform.position, 20, Vector3.up);//con zero no funciona, ya que se multiplica.

        foreach(RaycastHit col in info) //Aquí le estás diciendo al RayCast la información que necesita realizar.
        {
            if(col.collider.gameObject.GetComponent<Player>()) //Aquí le estás indicando que si colisiona la zona con  el player, le escuchará.
            {
                return true; //si le escucha, realizará la acción.
            }
        }
        return false; //Si no le escucha, no va a realizar la acción.
    }
}
