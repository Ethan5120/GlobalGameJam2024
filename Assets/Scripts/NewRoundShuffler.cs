using System.Collections.Generic;
using Unity.VisualScripting;
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
    [SerializeField] int currentRound;


    void Start()
    {
        target.y = -5f;
        GM.Round = 0;
        currentRound = 5;
        GM.CurrentTime = GM.SetTimer;
        GM.Strikes = 0;
        GM.CurrentState = ScriptableManager.GameState.SetUp;
    }

    void Update()
    {
        switch(GM.CurrentState)
        {
            case ScriptableManager.GameState.SetUp:
            {
                RoundSetup();
                break;
            }
            case ScriptableManager.GameState.Result:
            {


                break;
            }

        }

        
    }

    void RoundSetup()
    {
        if(currentRound != GM.Round)
        {
            RNumberSeq.Clear();
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
                target.x = -6.5f + (4.5f * i);   
                Rounds[GM.Round].InnmatesInRound[RNumberSeq[i]].transform.position = target;
            }

            GM.CurrentState = ScriptableManager.GameState.Selection;
            currentRound = GM.Round;
        }
    }

    public void NextRound()
    {
        GM.Round +=1;
        GM.CurrentState = ScriptableManager.GameState.SetUp;
        RoundSetup();
    }

        
}

    

