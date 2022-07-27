using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeycardController : MonoBehaviour
{
    public bool keycardCollected;

    // If player enters they keycard-trigger, mark keycard as collected
    // and disable keycard's Mesh-Renderer
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            keycardCollected = true;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
    }
}
