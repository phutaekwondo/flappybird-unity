using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = GameConfig.Score.ToString();

        //if isIncreaseScore is true, then increase the score by 1, then set it to false
        if (GameConfig.isIncreaseScore)
        {
            IncreaseScore();
            GameConfig.isIncreaseScore = false;
        }
    }

    public void ResetScore()
    {
        GameConfig.Score = 0;
    }

    public void IncreaseScore()
    {
        Debug.Log("IncreaseScore");
        GameConfig.Score += 1;
    }
}
    
