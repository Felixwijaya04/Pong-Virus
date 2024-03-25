using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class leftgoal : MonoBehaviour
{
    public scoreManager sm;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        sm.leftWin(1);
    }
}
