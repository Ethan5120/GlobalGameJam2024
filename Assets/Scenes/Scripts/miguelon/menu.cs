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
    SceneManager.LoadScene("GameScene");

    }

    public void Salir()
    {
        Debug.Log("Tilin se fue de sabatico cariño");
        Application.Quit();
    }

}
