using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rightGoal : MonoBehaviour
{
    public scoreManager sm;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        sm.rightWin(1);
    }
}
