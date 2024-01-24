using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharAsignSystem : MonoBehaviour
{
    public List<GameObject> InmateList = new List<GameObject>();
    public List<GameObject> InnocentList = new List<GameObject>();
    void Start()
    {
        Debug.Log(InmateList.Count);
        int test = UnityEngine.Random.Range(0, InmateList.Count - 1);
        Debug.Log(test);
        Debug.Log("The impostor is " + InmateList[test].name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
