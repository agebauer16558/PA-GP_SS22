using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TrainingRoomController : MonoBehaviour
{
    public static TrainingRoomController Instance { get; private set; }
    
    public TextMeshProUGUI prismScoreText;
    public TextMeshProUGUI goalScoreText;
    public TextMeshProUGUI goalScore2Text;

    public int prismScore;
    public int goalScore;
    public int goalScore2;


    private void Awake()
    {
        if(Instance != null) { Destroy(gameObject); }
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        prismScore = 0;
        goalScore = 0;
        goalScore2 = 0;

        prismScoreText.text = "" + prismScore;
        goalScoreText.text = "" + goalScore;
        goalScore2Text.text = "" + goalScore2;
    }

    public void UpdatePrismScore(int pointsToAdd)
    {
        prismScore += pointsToAdd;
        prismScoreText.text = "" + prismScore;
    }

    public void UpdateGoalScore(int pointsToAdd)
    {
        goalScore += pointsToAdd;
        goalScoreText.text = "" + goalScore;
    }

    public void UpdateGoal2Score(int pointsToAdd)
    {
        goalScore2 += pointsToAdd;
        goalScore2Text.text = "" + goalScore2;
    }
}
