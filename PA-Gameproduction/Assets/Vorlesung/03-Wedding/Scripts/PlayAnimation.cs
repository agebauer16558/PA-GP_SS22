using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{ 
    public Animator animationClip; 

    private float moveSpeed;
    private float verticalInput;
    private float horzontalInput;
    private float turnSpeed;

    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horzontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * Time.deltaTime * (verticalInput * moveSpeed));
        if(verticalInput != 0)
        {
            animationClip.SetBool("isWalking", true);

            animationClip.SetFloat("direction", verticalInput); 

            transform.Rotate(0, turnSpeed * (horzontalInput * verticalInput) * Time.deltaTime, 0);
        }
        else 
        {
            animationClip.SetBool("isWalking", false);
            animationClip.SetFloat("direction", 0);
        }
        
      
    }
}
