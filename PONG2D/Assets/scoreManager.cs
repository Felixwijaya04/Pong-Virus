using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    public Text scoreLeft;
    public Text scoreRight;

    [ContextMenu("increase")]
    public void leftWin(int score)
    {
        scoreLeft.text += score.ToString();
    }
    public void rightWin(int score)
    {
        scoreRight.text += score.ToString();
    }
}
