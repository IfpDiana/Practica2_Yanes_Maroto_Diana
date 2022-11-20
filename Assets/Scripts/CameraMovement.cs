using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour //recordar que cuando vaya a poner la c�mara, ponerla en la posici�n, 0f, 1f, 0f
{
    public Player player;
    public float mouseSens = 200f;
    private float yRotation = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //Para tener el rat�n bloqueado en la pantalla.
    }

    void Update() //detecta el movimiento del rat�n.
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime; //el rat�n aqu� son movimientos horizontales.
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime; //el rat�n aqu� son movimientos verticales.
        //Debug.Log("Mouse X: " + mouseX + "Mouse Y: " + mouseY);

        //y rotaci�n
        yRotation -= mouseY;
        if (yRotation >= 90) //l�mites para la c�mara, RECUERDA NO SER BOBA, QUE SABES HACERLO!!
        {
            yRotation = 90;
        }
        if (yRotation <= -90)
        {
            yRotation = -90;
        }
        transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(yRotation, 0, 0), 1f);
        //x rotaci�n
        player.transform.Rotate(Vector3.up * mouseX);

    }
}
