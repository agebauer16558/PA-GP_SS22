using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateButtonController : MonoBehaviour
{
    // The materials of the buttons
    public Material red;
    public Material green;

    // The animator to open the door
    public Animator openDoor1;
    public Animator openDoor2;
    public Animator openDoor3;

    // The buttons next to the door 
    public GameObject stateButton1;
    public GameObject stateButton2;
    public GameObject stateButton3;

    public KeycardController keycardState;


    void Start()
    {
    }

    void Update()
    {
        // Target-Points to unlock door
        int prismTarget = TrainingRoomController.Instance.prismScore;
        int goalTarget = TrainingRoomController.Instance.goalScore;
        int goal2Target = TrainingRoomController.Instance.goalScore2;

        // Was the keycard collected?
        bool keycardAvailable = keycardState.keycardCollected;

        // If the points of any of both goals is higher or equal 'x'
        // switch the material of the State-Button and play the animation to open the door
        if(prismTarget >= 1 && goalTarget >= 1)
        {
            stateButton1.GetComponent<MeshRenderer>().material = green;
            openDoor1.SetBool("isOpen", true);
        }
        if(goal2Target >= 3)
        {
            stateButton2.GetComponent<MeshRenderer>().material = green;
            openDoor2.SetBool("isOpen2", true);
        }

        // Open the final door if the keycard is available
        if(keycardAvailable)
        {
            stateButton3.GetComponent<MeshRenderer>().material = green;
            openDoor3.SetBool("isOpen3", true);
        } 
    }
}
