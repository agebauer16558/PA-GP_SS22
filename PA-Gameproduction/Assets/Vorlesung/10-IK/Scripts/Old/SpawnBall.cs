using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform spawnLocation;
    public Animator pressButton;

    public AnimationEvent Test;

    private void OnTriggerStay(Collider other)
    {

       
    }

    public void StartAnimation()
    {
        pressButton.SetTrigger("pushing");
    }

    /*public void SpawnObject()
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Instantiate(ballPrefab, spawnLocation.position, spawnLocation.rotation);
            }
        }
    }*/
    
}
