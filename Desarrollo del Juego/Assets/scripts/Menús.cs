using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menús : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Escena de Juego");
    }

}
