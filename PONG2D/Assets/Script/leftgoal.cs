using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class leftgoal : MonoBehaviour
{
    public scoreManager sm;
    public GameObject ball;
    Vector2 ballPos;

    private void Start()
    {
        ballPos = ball.transform.position;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        sm.leftWin(1);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        ball.transform.position = ballPos;
    }
}
