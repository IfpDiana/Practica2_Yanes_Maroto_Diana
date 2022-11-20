using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None; //None, sirve para que no desaparezca el cursor.
    }

    public void StartButton()
    {
        StartCoroutine(NewGameCoroutine()); //esto hace que empiece la corrutina que es lo que hace que vaya el tiempo de espera.
    }

    public void ExitButton()
    {
        Application.Quit(); //Le estás diciendo que salga de la aplicación.
    }

    IEnumerator NewGameCoroutine() //Le das una nueva corrutina, donde le dices que espere cierto tiempo para iniciar y pase a la siguiente escena.
    {
        yield return null;
        yield return new WaitForSeconds(1.0f); //espera dos segundos y carga la escena.
        SceneManager.LoadScene("SampleScene");
    }
}
