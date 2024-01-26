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
    public List<GameRounds> Rounds;
    private List<int> RNumberSeq = new List<int>();

    [SerializeField] int NoRound;
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
        for(int i = 0; i < 5; i++)
        {
            int r = Random.Range(0, 5);
            while (RNumberSeq.Contains(r))
            {
                r = Random.Range(0, 5);
            }
            Debug.Log(r);
            RNumberSeq.Add(r);
        }

        //Once the shuffle is done, Place then in their positions
        for(int i = 0; i < 5; i++)
        {
            target.x = -6 + (3 * i);   
            Rounds[NoRound].InnmatesInRound[RNumberSeq[i]].transform.position = target;
        }



        
    }

       

        
}

    

