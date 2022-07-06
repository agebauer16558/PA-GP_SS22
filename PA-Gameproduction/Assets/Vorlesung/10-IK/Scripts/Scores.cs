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
        }
        if (this.CompareTag("goalItem") && other.gameObject.CompareTag("Item"))
        {
            TrainingRoomController.Instance.UpdateGoalScore(points);
        }
    }
}
