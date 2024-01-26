using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameRounds
{
    public string name;
    public List<GameObject> InnmatesInRound = new List<GameObject>();
    
}

public class NewRoundShuffler : MonoBehaviour
{
    [Header("List of Rounds")]
    public List<GameRounds> Rounds;

    //This is the list of the Random Number Sequence
    private List<int> RNumberSeq = new List<int>();

    //Declare the GameManager SO; don't forget to add it in the editor after creating one in the assets.
    [Header("Game Manager")]
    [SerializeField] ScriptableManager GM;
    [Space(10)]

    //The positions of the inmates
    Vector2 target;


    void Start()
    {
        target.y = 0;
        RoundSetup();
    }

    void Update()
    {
        
    }

    void RoundSetup()
    {
        //Setup the order
        for(int i = 0; i < 4; i++)
        {
            int r = Random.Range(0, 4);
            while (RNumberSeq.Contains(r))
            {
                r = Random.Range(0, 4);
            }
            Debug.Log(r);
            RNumberSeq.Add(r);
        }

        //Once the shuffle is done, Place then in their positions
        for(int i = 0; i < 4; i++)
        {
            target.x = -6 + (4 * i);   
            Rounds[GM.Round].InnmatesInRound[RNumberSeq[i]].transform.position = target;
        }

        
    }

       

        
}

    

