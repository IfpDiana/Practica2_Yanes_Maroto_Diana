using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public State startingState;
    public State currentState;

    private void Start()
    {
        currentState = startingState;
    }

    private void Update()
    {
        RunStateMachine();
    }

    private void RunStateMachine() 
    {
        if (currentState == null) //si no se está realizando ningún estado, volverá  a su estado original.
        {
            return;
        }

        State nextState = currentState.Run(gameObject);//Aquí lo que haces es que,  cuando sea el  siguiente estado, lo realice.

        if(nextState !=null)
        {
            SwitchToNextState(nextState); //Le dices que si el siguiente estado no se está realizando, pase al siguiente estado.
        }
    }

    private void SwitchToNextState(State next) //camibas al siguiente estado.
    {
        currentState = next;
    }
}
