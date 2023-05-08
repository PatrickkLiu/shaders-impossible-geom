using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldDissolveControl : MonoBehaviour
{
    private Animator anim;
    public GameObject ball;
    public Animator bed;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
   
    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("StartDissolve");
            anim.Play("Base Layer.StartDissolve");
            bed.Play("BedroomAppear");
            //ball.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("ReverseDissolve");
            anim.Play("Base Layer.ReverseDissolve");
        }


    }
}
