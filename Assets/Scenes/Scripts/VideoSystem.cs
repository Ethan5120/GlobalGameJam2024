using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoSystem : MonoBehaviour
{
    [SerializeField] ScriptableManager GM;
    public VideoPlayer video;
    public GameObject pj;
    private void Awake() {
        video = GetComponent<VideoPlayer>();
        video.Play();
        video.loopPointReached += CheckOver;
    }

    void CheckOver(VideoPlayer vp){
        gameObject.SetActive(false);
        pj.SetActive(false);
        
        if(GM.Round < 4)
            {
                GM.Round += 1;
                GM.CurrentState = ScriptableManager.GameState.SetUp;
            }
            else
            {
                GM.CurrentState = ScriptableManager.GameState.Wingame;
            }

    }
}
