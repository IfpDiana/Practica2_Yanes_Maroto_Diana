using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour //recordar que cuando vaya a poner la cámara, ponerla en la posición, 0f, 1f, 0f
{
    public Player player;
    public float mouseSens = 200f;
    private float yRotation = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //Para tener el ratón bloqueado en la pantalla.
    }

    void Update() //detecta el movimiento del ratón.
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime; //el ratón aquí son movimientos horizontales.
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime; //el ratón aquí son movimientos verticales.
        //Debug.Log("Mouse X: " + mouseX + "Mouse Y: " + mouseY);

        //y rotación
        yRotation -= mouseY;
        if (yRotation >= 90) //límites para la cámara, RECUERDA NO SER BOBA, QUE SABES HACERLO!!
        {
            yRotation = 90;
        }
        if (yRotation <= -90)
        {
            yRotation = -90;
        }
        transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(yRotation, 0, 0), 1f);
        //x rotación
        player.transform.Rotate(Vector3.up * mouseX);

    }
}
