using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlaneOffsetScript : MonoBehaviour
{
    //Componente tipo render.
    Renderer rend;
    //Vector desplazamiento.
    [SerializeField] Vector2 despl;
    //Datos de la nave
    GameObject Nave;
    NaveControlar naveControlar;

    //Velocidad a la que se moverá la textura.
    [SerializeField] float scrollSpeed;
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        //Asignamos el componente renderer.
        rend = GetComponent<Renderer>();
        //Obtenemos el script.
        Nave = GameObject.Find("NaveParent");
        naveControlar = Nave.GetComponent<NaveControlar>();
    }

    // Update is called once per frame
    void Update()
    {
        scrollSpeed = naveControlar.speed / 2; //Velocidad de desplazamiento.
        float offset = Time.time * scrollSpeed; //Distancia de desplazamiento según el tiempo transcurrido.
        despl = new Vector2(0, -offset); //Vector de desplazamiento.
        //rend.material.SetTextureOffset("MainText", despl);
        //rend.material.SetTextureOffset("BumpMap", despl);
    }
}
