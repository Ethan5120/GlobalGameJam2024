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
    public bool press = false;
    public GameObject panel;

    public GameObject c1, c2, c3;


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
            //Debug.Log("Entro");
            //ChangeAnimationState(Idle);
        }
    }

    private void OnMouseExit()
    {
        if (press == false)
        {
            //Debug.Log("Salio");
            //ChangeAnimationState(Stop);
        }
    }

    private void OnMouseDown()
    {
        Debug.Log("Presiono el mouse");
        panel.SetActive(true);
        //DesactivateColliders();
        //ChangeAnimationState(Explo);
    }

    /*

    private void DesactivateColliders()
    {
        if (c1 != null && c1.GetComponent<Collider2D>() != null)
        {
            c1.GetComponent<Collider2D>().enabled = false;
        }
        if (c2 != null && c2.GetComponent<Collider2D>() != null)
        {
            c2.GetComponent<Collider2D>().enabled = false;
        }
        if (c3 != null && c3.GetComponent<Collider2D>() != null)
        {
            c3.GetComponent<Collider2D>().enabled = false;
        }
    }

    public void ActivarColliders()
    {
        if (c1 != null && c1.GetComponent<Collider2D>() != null)
        {
            c1.GetComponent<Collider2D>().enabled = true;
        }
        if (c2 != null && c2.GetComponent<Collider2D>() != null)
        {
            c2.GetComponent<Collider2D>().enabled = true;
        }
        if (c3 != null && c3.GetComponent<Collider2D>() != null)
        {
            c3.GetComponent<Collider2D>().enabled = true;
        }
    }*/
}
