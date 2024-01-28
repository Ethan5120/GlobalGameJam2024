using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Timer : MonoBehaviour
{
    [SerializeField] ScriptableManager GM;
    public GameObject timer;
   
   
  

    public TextMeshProUGUI textoTimerPro;

  
    void Update()
    {
        if(GM.CurrentState == ScriptableManager.GameState.Selection)
        {
            DisplayTime();
            timer.SetActive(true);
        }
        else {
            timer.SetActive(false);
        }


        if (GM.CurrentTime < 0)
        {
            //GameOver
            Debug.Log("se acabo la busqueda");
            GM.CurrentTime = 0;  
            GM.CurrentState = ScriptableManager.GameState.Endgame;
        }

    }


    void DisplayTime()
    {
        GM.CurrentTime -= Time.deltaTime;

        if(GM.CurrentTime < 60f)
        {
            textoTimerPro.color = new Color(255f, 0f, 0f);
        }

        float minutes = Mathf.FloorToInt(GM.CurrentTime / 60);  
        float seconds = Mathf.FloorToInt(GM.CurrentTime % 60);
        textoTimerPro.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
