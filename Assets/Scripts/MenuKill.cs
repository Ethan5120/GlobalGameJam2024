using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuKill : MonoBehaviour
{
    [SerializeField] ScriptableManager GM;
    public GameObject m;
    public GameObject p1, p2, p3, p4;
    public GameObject vd;
    public bool isGuilty;
    public void BotonNo()
    {
        m.SetActive(false);
    }

    public void BotonSi()
    {
        if(isGuilty)
        {
            m.SetActive(false);
            p1.SetActive(false);
            p2.SetActive(false);
            p3.SetActive(false);
            p4.SetActive(false);
            vd.SetActive(true);
            GM.CurrentState = ScriptableManager.GameState.Result;
        }
        else
        {
            GM.Strikes += 1;
        }
        // Cambio de ronda
    }
}
