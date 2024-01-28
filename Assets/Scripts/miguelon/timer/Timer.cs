using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] ScriptableManager GM;
   
   
  

    public TextMeshProUGUI textoTimerPro;

  
    void Update()
    {
        DisplayTime();

        if (GM.CurrentTime < 0)
        {
            //GmaeOver
            Debug.Log("se acabo la busqueda");
            GM.CurrentTime = 0;  
        }

    }


    void DisplayTime()
    {
        GM.CurrentTime -= Time.deltaTime;

        float minutes = Mathf.FloorToInt(GM.CurrentTime / 60);  
        float seconds = Mathf.FloorToInt(GM.CurrentTime % 60);
        textoTimerPro.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
