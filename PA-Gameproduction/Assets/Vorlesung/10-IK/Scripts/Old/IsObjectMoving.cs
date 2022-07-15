using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsObjectMoving : MonoBehaviour
{
    public Vector3 lastPos;
    public bool movement;

    public Collider trigger;

    private void Start()
    {
        lastPos = transform.position;
        movement = false;
    }

    void Update()
    {
        
        if(transform.position != lastPos)
        {
            movement = true;
            if(trigger.isTrigger == true && movement)
            {
                trigger.enabled = false;
            }

        }
        else
        {
            movement = false;
            if (trigger.isTrigger == true && !movement)
            {
                trigger.enabled = true;
            }
        }

        lastPos = transform.position;
    }
}
