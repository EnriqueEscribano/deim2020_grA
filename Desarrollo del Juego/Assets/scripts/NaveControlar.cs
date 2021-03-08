using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NaveControlar : MonoBehaviour

                                                                                  //Antes de empezar, hemos tenido que meter la nave en un Empty Object puesto que al haberla importado como FBX, este formato traía por defecto sus propios ejes, y cambiaba el x por el z, o bien porque el objeto en Maya no estaba freezado y se encontraba girado. Al meterla en un Empty Object vuelve a cambiar los ejes preestablecidos por los de Unity debido a la jerarquía de los elementos.
{

    public float speed = 5f; //Al declarar la variable pública, si se hacen cambios en la velocidad, se han de hacer desde Unity porque así es la jerarquía.

    [SerializeField] Text speedText;
    [SerializeField] Text timeText;

    private string currentTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        MoverNave();

        //Cambio el texto de la UI, metido en la variable speedText. Debe ser una cadena, si quiero, puedo convertir el float en string //speedText.text = speed.ToString();
        speedText.text = "Velocidad: " + speed + " Km/h";

        // Obtain the current time.
        currentTime = Time.time.ToString("f2");
        currentTime = "Time is: " + currentTime + " s.";

        timeText.text = currentTime;

    }

    void MoverNave()
    {
        float PosX = transform.position.x;
        float PosY = transform.position.y;
        print(transform.position.x);
        float desplY = Input.GetAxis("Vertical");

        float desplX = Input.GetAxis("Horizontal");

        //Restringir movimiento horizontal
        if ((PosX < 22 || desplX < 0) && (PosX > 12 || desplX > 0))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
        }

        //Restringir movimiento vertical
        if ((PosY < 4 || desplY < 0) && (PosY > 0 || desplY > 0))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed * desplY);
        }

        // las || significan or.
    }
}