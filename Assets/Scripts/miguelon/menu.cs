using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
  

    /*public void EscenaJuego()
    {
        SceneManager.LoadScene("ui");
    }

    public void CargarNivel(string nombreNivel)
    {
        SceneManager.LoadScene(nombreNivel);
    }*/

    public void EscenasCambios()
    {
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void Salir()
    {
        Application.Quit();
    }

}
