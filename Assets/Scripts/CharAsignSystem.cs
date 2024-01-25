using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharAsignSystem : MonoBehaviour
{
    public List<GameObject> InmateList = new List<GameObject>();
    public List<GameObject> InnocentList = new List<GameObject>();
    public List<GameObject> SelectedCharacters = new List<GameObject>();

    int impostorId, innocentId;
    [SerializeField] int innocentAmmount;
    void Start()
    {
        SelectedCharacters.Clear();
        CharacterSetup();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void CharacterSetup()
    {
        //ImpostorSelection
        impostorId = UnityEngine.Random.Range(0, InmateList.Count - 1); //Generate a Random number to determine the characte to display
        Debug.Log(impostorId);
        Debug.Log("The impostor is " + InmateList[impostorId].name);
        SelectedCharacters.Add(InmateList[impostorId]); //Add said character to a new list

        //InnocentSelection
        for(int i = 0; i < innocentAmmount; i++)
        {
            innocentId = UnityEngine.Random.Range(0, InnocentList.Count - 1);
            Debug.Log(innocentId);
            if(CharCheck())
            {
                Debug.Log("The innocent added is " + InnocentList[innocentId].name);
                SelectedCharacters.Add(InnocentList[innocentId]);
            }
            else
            {
                Debug.Log(innocentId);
                Debug.Log("InnocentAlreadySelected, Re-Selecting");
                i--;
            }
            
            
        }
    }

    bool CharCheck()
    {
        for(int j = 0; j < SelectedCharacters.Count; j++)
        {
            if(InnocentList[innocentId].name == SelectedCharacters[j].name)
            {
                return false;
            }
        }
        return true;
    }
}
