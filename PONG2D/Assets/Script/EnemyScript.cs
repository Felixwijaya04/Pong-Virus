using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] private Rigidbody2D ball;
    [SerializeField] float agroRange;
    public float movementSpeed;
    private float dist;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        dist = Vector2.Distance(ball.position, rb.position);
        print(dist);
        if (dist < agroRange)
        {
            chase();
        }
        else
        {
            stopChase();
        }
    }

    void chase()
    {
        if (transform.position.y > ball.position.y)
        {
            // turun kebawah
            rb.velocity = new Vector2(0, -movementSpeed);
            

        } else if(transform.position.y < ball.position.y)
        {
            // naik keatas
            rb.velocity = new Vector2(0, movementSpeed);
        }
    }

    void stopChase()
    {
        rb.velocity = new Vector2 (-movementSpeed, 0);
    }
}
