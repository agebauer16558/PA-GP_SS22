using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeycardController : MonoBehaviour
{
    public static KeycardController Instance { get; private set; }

    private bool keycardedCollected;

    // If player enters they keycard-trigger, mark keycard as collected
    // and destroy keycard in the world
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            keycardedCollected = true;
            Destroy(gameObject);
        }
    }
}
