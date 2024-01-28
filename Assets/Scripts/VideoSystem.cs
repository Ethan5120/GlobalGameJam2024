using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoSystem : MonoBehaviour
{
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
    }
}