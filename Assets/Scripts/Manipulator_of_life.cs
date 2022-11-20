using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manipulator_of_life : MonoBehaviour
{
    Healthbar healthbar;

    public int amount; //Esto es la cantidad de daño que queremos que quite u añada.
    public float damageTime; //Aquí ponemos la variable del tiempo que va a tardar en quitar vida o recuperarla.
    public float currentDamageTime;

    void Start()
    {
        healthbar = GameObject.FindWithTag("Player").GetComponent<Healthbar>(); //Aquí está detectando al jugador a través de una etiqueta.
    }

    
    public void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            currentDamageTime += Time.deltaTime;
            if (currentDamageTime > damageTime)
            {
                healthbar.life += amount;
                currentDamageTime = 0.0f;
            }
        }
    }
}
