using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ludiq;
using Bolt;

public class Crouch : MonoBehaviour
{
    
    private Animator ThirdPersonAnis;
    private bool isCrouching;
    
    void Start()
    {
        ThirdPersonAnis = GetComponent<Animator>();
    }
    void Update()
    {
        CrouchLoop();
    }

    void CrouchLoop()
    {
        if (Input.GetButtonDown("Fire1"))
        { 

            bool currentState = ThirdPersonAnis.GetBool("isCrouching");

            ThirdPersonAnis.SetBool("isCrouching", !currentState);
        }

        if (Input.GetButtonUp("Fire1"))
        {

            bool currentState = ThirdPersonAnis.GetBool("isCrouching");

            ThirdPersonAnis.SetBool("isCrouching", !currentState);
        }
    }
}
