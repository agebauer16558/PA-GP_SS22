using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{
    private Animator ThirdPersonAnis;

    void Start()
    {
        ThirdPersonAnis = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            bool currentState = (ThirdPersonAnis.GetBool("isCrouching"));

            ThirdPersonAnis.SetBool("isCrouching", !currentState);
        }    
    }
}
