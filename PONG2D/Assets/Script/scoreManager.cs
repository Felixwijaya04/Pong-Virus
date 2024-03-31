using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    public Text scoreLeft;
    public Text scoreRight;
    private int leftScore = 0;
    private int rightScore = 0;

    public UI_Manager manager;
    
    public void leftWin(int score)
    {
        scoreLeft.text = (int.Parse(scoreLeft.text) + score).ToString();
        leftScore += 1;
        if(leftScore >= manager.score)
        {
            manager.EndTheGame();
        }
    }
    public void rightWin(int score)
    {
        scoreRight.text = (int.Parse(scoreRight.text) + score).ToString();
        rightScore += 1;
        if(rightScore >= manager.score)
        {
            manager.EndTheGame();
        }
    }
}
