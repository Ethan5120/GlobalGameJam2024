using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuKill : MonoBehaviour
{
    public GameObject m;
    public GameObject p1, p2, p3, p4;
    public GameObject vd;
    public void BotonNo()
    {
        m.SetActive(false);
    }

    public void BotonSi()
    {
        m.SetActive(false);
        p1.SetActive(false);
        p2.SetActive(false);
        p3.SetActive(false);
        p4.SetActive(false);
        vd.SetActive(true);
        // Cambio de ronda
    }
}
