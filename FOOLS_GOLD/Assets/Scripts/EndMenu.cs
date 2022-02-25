using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndMenu : MonoBehaviour
{

    // [SerializeField] TextMeshProUGUI finalScoreText; <- PH for scoreLogic after miningLogic
    // [SerializeField] ScoreKeeper scoreKeeper; <- PH for scoreLogic after miningLogic

    void Awake()
    {
        // scoreKeeper = FindObjectOfType<ScoreKeeper>(); <- PH for scoreLogic after miningLogic
    }

    public void ShowFinalScore()
    {
        // finalScoreText.text = "Congratulations!\nYou got a score of " + scoreKeeper.CalculateScore();
        // PH for scoreLogic after miningLogic
    }


}
