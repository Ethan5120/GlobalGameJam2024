using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] ScriptableManager GM;
   
   
  

    public TextMeshProUGUI textoTimerPro;

  
    void Update()
    {
        
        GM.CurrentTime -= Time.deltaTime;
        
        
        textoTimerPro.text = "" + GM.CurrentTime.ToString("f0");

        if (GM.CurrentTime < 0)
        {
            //GmaeOver
            Debug.Log("se acabo la busqueda");
            GM.CurrentTime = 0;  
        }

    }
}
