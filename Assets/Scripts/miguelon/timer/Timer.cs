using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
   
    public float timer = 0;
   
   
  

    public TextMeshProUGUI textoTimerPro;

  
    void Update()
    {
        
        timer -= Time.deltaTime;
        
        
        textoTimerPro.text = "" + timer.ToString("f0");

        if (timer < 0)
        {
            //teminar ronda
            Debug.Log("se acabo la busqueda");
            timer = 0;  
        }

    }
}
