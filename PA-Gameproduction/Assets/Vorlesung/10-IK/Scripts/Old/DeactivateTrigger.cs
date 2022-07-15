using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Bolt;

public class DeactivateTrigger : MonoBehaviour
{
    public Collider trigger;

    private GameObject player;
    private bool itemGrabbed;
    private float targetTime = 10.0f;
    private bool throwing;
    private bool startTimer;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        itemGrabbed = (bool)Variables.Object(player).Get("itemInHand");
        throwing = (bool)Variables.Object(player).Get("startingToThrow");
        print(itemGrabbed);
        if (trigger.isTrigger == true && itemGrabbed)
        {
            trigger.enabled = false;
            print("deactivated trigger");
        }

        if(throwing)
        {
            startTimer = true;
            print("throwing");
        }

        if(startTimer)
        {
            targetTime -= Time.deltaTime;
            print(targetTime);
        }

        if(targetTime <= 0.0f)
        {
            print("we're done");
            trigger.enabled = true;
            startTimer = false;
            targetTime = 10.0f;
        }




    }
}
