using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftWall : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            Debug.Log("left win");
            //add left score
        }
    }
}
