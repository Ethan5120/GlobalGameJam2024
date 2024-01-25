using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewRoundShuffler : MonoBehaviour
{
    [System.Serializable]
    public class GameRounds
    {
        public string name;
        public List<GameObject> InnmatesInRound = new List<GameObject>();
    }
    public List<GameRounds> Rounds = new List<GameRounds>();
    public List<GameObject> Order = new List<GameObject>();
    [SerializeField] int Round = 0;
    [SerializeField] int x;
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
        //Shuffle the order of the characters
        for(int i = 0; i < 4; i++)
        {
            x = Random.Range(0, 4);
            //if(CharCheck())
            //{
            Debug.Log(x);
            Order.Add(Rounds[Round].InnmatesInRound[x]);
                
            //}
        }
        //Once the shuffle is done, Place then in their positions
        /*for(int i = 0; i < 5;)
        {
            target.x = -6 + (3 * i);   
            Order[i].transform.position = target;
        }*/
        
    }

    bool CharCheck()
    {
        for(int j = 0; j < Order.Capacity; j++)
        {
            if(Order[j] == null)
            {
                break;
            }
            else if(Rounds[Round].InnmatesInRound[x].name == Order[j].name)
            {
                return false;
            }
        }
        return true;
    }
    
}
