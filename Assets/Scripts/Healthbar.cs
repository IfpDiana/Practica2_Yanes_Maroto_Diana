using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{

    public Image healthbar; //Le dices a la imagen que se ponga, teniendo esta el nombre de "Barra de vida"
    public float life = 100; //Creas una variable de "vida" con un m?ximo de est?.
    
    void Update()
    {
        life = Mathf.Clamp(life, 0, 100); //hace que nuestra vida no pase del m?ximo ni del m?nimo.
        healthbar.fillAmount = life / 100;
    }
}
