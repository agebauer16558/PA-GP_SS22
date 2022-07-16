using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scores : MonoBehaviour
{
    public int points;
    private void OnTriggerEnter(Collider other)
    {
        if(this.CompareTag("prismItem") && other.gameObject.CompareTag("Item"))
        {
            TrainingRoomController.Instance.UpdatePrismScore(points);
            Destroy(other.gameObject);
        }
        if (this.CompareTag("goalItem") && other.gameObject.CompareTag("Item"))
        {
            TrainingRoomController.Instance.UpdateGoalScore(points);
            Destroy(other.gameObject);
        }
        if (this.CompareTag("goal2Item") && other.gameObject.CompareTag("Item"))
        {
            TrainingRoomController.Instance.UpdateGoal2Score(points);
            Destroy(other.gameObject);
        }
    }
}
