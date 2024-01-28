using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenMax : MonoBehaviour
{
    public void PantallaCompleta(bool PantallaCompleta)
    {
    Debug.Log("Si jala tilin");
    Screen.fullScreen = PantallaCompleta;
    }
}
