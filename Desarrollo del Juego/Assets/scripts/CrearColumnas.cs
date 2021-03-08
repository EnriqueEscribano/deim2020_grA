using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrearColumnas : MonoBehaviour
{
    //Variable de tipo Object que contendrá el Prefab a instanciar
    [SerializeField] GameObject MyColumn;
    //Variable de tipo Transform que contendrá el objeto de referencia
    [SerializeField] Transform InitPos;
    //Distancia entre columnas
    [SerializeField] float dist;
    //Vector que usaremos para posicionar las columnas de inicio
    Vector3 newPos;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

        
        StartCoroutine("ColumnCorrutine");

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            CrearColumna();
        }

    }

    void CrearColumna()
    {
        //Creo un nuevo vector3, para ello primero creo un número random, que es un número aleatorio entre los valores que le asigno, en este caso el 0 y el 10.
        float posRandom = Random.Range(0f, 10f);
        Vector3 DestPos = new Vector3(posRandom, 0, 0);
        Vector3 NewPos = InitPos.position + DestPos;
        //Instancio el prefab en la posición del objeto de referencia. Como tenemos su componente Transform, le indicamos que lo que quiero es su posición.
        Instantiate(MyColumn, NewPos, Quaternion.identity);
    }

    IEnumerator ColumnCorrutine()
    {

        for (int n=0; ; n++ )
        {
            print(n);
            //Intancio el prefab en coordenadas 0,0,0
            //Instantiate(MyColumn);
            CrearColumna();
            yield return new WaitForSeconds(1);
        }
    }
}
