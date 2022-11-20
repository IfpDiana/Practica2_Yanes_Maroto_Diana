using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manipulator_of_life : MonoBehaviour
{
    Healthbar healthbar;

    public int amount; //Esto es la cantidad de da�o que queremos que quite u a�ada.
    public float damageTime; //Aqu� ponemos la variable del tiempo que va a tardar en quitar vida o recuperarla.
    public float currentDamageTime;

    void Start()
    {
        healthbar = GameObject.FindWithTag("Player").GetComponent<Healthbar>(); //Aqu� est� detectando al jugador a trav�s de una etiqueta.
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
