using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float playerSpeed = 20f;
    public float gravityForce = 200f;//(Esto es para ponerle un valor a la gravedad))
    private CharacterController controller; //Controlador del personaje.
    public float Yvelocity = 0f; //Recordar hacer está variable para que se multiplique por cero y no te de errores.
    
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal"); //Movimiento en Horizontal.
        float z = Input.GetAxis("Vertical"); //Movimiento en Vertical.
        float y = Input.GetAxis("Jump");  //esto lo haces  para crear una variable de salto.

        Vector3 movement = transform.right * x + transform.forward * z;//Esto es para hacer la gravedad, para que se quede en el suelo.
                                                                                                       //movement.y /= playerSpeed; //la  velocidad del jugador.

        movement *= playerSpeed;

        

        if(Input.GetButtonDown("Jump") && controller.isGrounded) //Aquí le estás diciendo si está en el suelo.
        {
            Yvelocity = 0;
            Yvelocity += 60f; //Usas la variable para que te detecte el salto, y le multiplicas una cantidad para conseguir la fuerza de gravedad.
        }
        //Debug.Log(Yvelocity);
        Yvelocity -= gravityForce *Time.deltaTime;//Aquí lo que haces es que se reste y lo multiplica, IMPORTANTE RESTARLO.
        movement.y = Yvelocity;
        movement *= Time.deltaTime; //Esto es la velocidad del movimiento.

        //Debug.Log(movement);

        controller.Move(movement);//Time.deltaTime * speed)

        if(Input.GetKey(KeyCode.Escape))//le das a la   tecla escape y se irá al menú.
        {
            SceneManager.LoadScene("Menu");
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Object"))  //Hace que se destruya el objeto.
        {
            Destroy(collision.gameObject);
        }
    }
}
