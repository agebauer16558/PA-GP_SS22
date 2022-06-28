using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WavingController : MonoBehaviour
{
    public Animator wavingAnimation;
    public Animator dancingAnimation;
    private bool isWaving; 
    private bool isDancing;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1)) {
            wavingAnimation.SetBool("isWaving", isWaving);
            isWaving = !isWaving; 
        }

        if(Input.GetKeyDown(KeyCode.Alpha2)) {
            dancingAnimation.SetBool("isDancing", isDancing);
            isDancing = !isDancing;
        }   
    }

}
