using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Bolt;

public class Scores : MonoBehaviour
{
    public int points;
    public GameObject player;

    private bool stillInHand;
    void Update()
    {
        stillInHand = (bool)Variables.Object(player).Get("itemInHand");
    }
    private void OnTriggerEnter(Collider other)
    {
        if(this.CompareTag("prismItem") && other.gameObject.CompareTag("Item")
            && !stillInHand)
        {
            TrainingRoomController.Instance.UpdatePrismScore(points);
            Destroy(other.gameObject);
        }
        if (this.CompareTag("goalItem") && other.gameObject.CompareTag("Item")
            && !stillInHand)
        {
            TrainingRoomController.Instance.UpdateGoalScore(points);
            Destroy(other.gameObject);
        }
        if (this.CompareTag("goal2Item") && other.gameObject.CompareTag("Item")
            && !stillInHand)
        {
            TrainingRoomController.Instance.UpdateGoal2Score(points);
            Destroy(other.gameObject);
        }
    }
}
