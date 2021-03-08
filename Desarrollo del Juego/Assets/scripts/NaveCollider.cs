using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NaveCollider : MonoBehaviour
{

    [SerializeField] MeshRenderer myMesh;

   
        void OnTriggerEnter(Collider other)            //Other se refiere para cualquier otro objeto, en este caso el plano
        
        {
             if (other.gameObject.tag == "Finish")
                 {
                     Destroy(this.gameObject);          //This se refiere a la clase en la que estamos, en este caso sphere collider
            SceneManager.LoadScene("UserInterface2");
                 }
        }

}
