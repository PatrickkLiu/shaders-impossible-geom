using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalControl : MonoBehaviour
{
    private Animator anim;
    public GameObject ball;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
   
    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("PortalOpen");
            anim.Play("Base Layer.PortalOpen");
            ball.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("PortalClose");
            anim.Play("Base Layer.PortalClose");
        }


    }
}
