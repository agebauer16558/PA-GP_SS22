using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColor : MonoBehaviour
{
    public Material red;
    public Material green;

    void Start()
    {

    }
    void Update()
    {
        int prismTarget = TrainingRoomController.Instance.prismScore;
        int goalTarget = TrainingRoomController.Instance.goalScore;
        if (prismTarget >= 5 || goalTarget >= 5)
        {
            this.GetComponent<MeshRenderer>().material = green;
        }
    }
}
