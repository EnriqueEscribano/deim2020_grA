using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Columna : MonoBehaviour
{
    GameObject nave;                       
    NaveControlar naveControlar;                                // Creamos la variable con la clase NaveControlar.
    float columSpeed;                                          //Creamos la variable de la velocidad de la columna, donde intentaremos luego acceder a la velocidad de la nave para que las coluimnas vayan a la misma velocidad.

    // Start is called before the first frame update
    void Start()
    {
        nave = GameObject.Find("NaveParent");                  //Asignamos mediante código el objeto nave a la variable nave.
        naveControlar = nave.GetComponent<NaveControlar>();    //Accedemos a la clase NaveControlar para poder acceder al Script NaveControlar y a sus respectivas variables.
    }

    // Update is called once per frame
    void Update()
    {
        columSpeed = naveControlar.speed;                                          //Accedemos a la velocidad de la nave y decimos que va la velocidad de las columnas va a ser igual a la de la nave. Esto se hace en el void update para que si la velocidad de la nave cambia a lo largo del juego, también se cambie la de las columnas.
        transform.Translate(Vector3.back * Time.deltaTime * columSpeed);           //Accedemos a la velocidad de la nave.

        if (transform.position.z < -10)                                            //A partir de esa posición, (cuando haya pasado la cámara), se destruye el objeto.
        {
            Destroy(gameObject);
        }
        
    }
}
