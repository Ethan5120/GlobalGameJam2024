using UnityEngine;

[CreateAssetMenu(fileName = "GameManager", menuName = "ScriptableObjects/GameManager", order = 1)]
public class ScriptableManager : ScriptableObject
{
    //Game Manager Variables

    public enum GameState{Menus, SetUp, Selection, Result, Endgame, Wingame}

    [Header("GameState")]
    public GameState CurrentState;
    public int Strikes;
    [Space(10)]


    [Header("TimerSettings")]
    public float SetTimer;
    public float CurrentTime;
    [Space(10)]


    [Header("RoundSettings")]
    public int Round;
    
}
