using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menús2 : MonoBehaviour
{
    public void ExitGame()
    {
        SceneManager.LoadScene("UserInterface");
    }

}