using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rightGoal : MonoBehaviour
{
    public scoreManager sm;
    public GameObject ball;
    Vector2 ballPos;
    private void Start()
    {
        ballPos = ball.transform.position;
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            sm.leftWin(1);
            ball.transform.position = ballPos;
        }
    }
}
