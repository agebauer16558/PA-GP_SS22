using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateItem : MonoBehaviour
{
    public int rotationValue = 50; 
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * rotationValue * Time.deltaTime);
    }
}
