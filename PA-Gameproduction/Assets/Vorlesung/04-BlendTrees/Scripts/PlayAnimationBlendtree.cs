using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimationBlendtree : MonoBehaviour
{ 
    public Animator animationClip; 

    private float walkSpeed;
    private float verticalInput;
    private float horzontalInput;
    private float turnSpeed;
    private float targetSpeed; 

    void Start()
    {
        walkSpeed = targetSpeed; 
    }

    void Update()   
    {
        verticalInput = Input.GetAxis("Vertical");
        horzontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * Time.deltaTime * (verticalInput * walkSpeed));
        if(verticalInput != 0)
        {

            animationClip.SetFloat("direction", verticalInput); 

            transform.Rotate(0, turnSpeed * (horzontalInput * verticalInput) * Time.deltaTime, 0);
        }
        else 
        {
            animationClip.SetFloat("direction", 0);
        }
        
      
    }
}
