using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMouse : MonoBehaviour
{
    private string currentState;
    Animator animator;
    const string Idle = "idle";
    const string Stop = "stop";
    const string Explo = "explosion";
    bool press = false;

    public GameObject vd;


    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void ChangeAnimationState(string newState)
    {
        if (currentState == newState) return;
        animator.Play(newState);
        currentState = newState;
    }

    private void OnMouseEnter()
    {
        if (press == false)
        {
            Debug.Log("Entro");
            ChangeAnimationState(Idle);
        }
    }

    private void OnMouseExit()
    {
        if (press == false)
        {
            Debug.Log("Salio");
            ChangeAnimationState(Stop);
        }
    }

    private void OnMouseDown()
    {
        Debug.Log("Presiono el mouse");
        ChangeAnimationState(Stop);
        //ChangeAnimationState(Explo);
        press = true;
        vd.SetActive(true);
    }
}
