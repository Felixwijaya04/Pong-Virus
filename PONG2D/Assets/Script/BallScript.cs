using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public float force;
    [SerializeField] public Rigidbody2D rb;
    private float arahX;
    void Start()
    {
        arahX = Random.Range(0, 2);
        if (arahX < 1)
        {
            rb.velocity = new Vector2(- force, 0);
        }
        else
        {
            rb.velocity = new Vector2(force, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Racket"))
        {
            Vector2 vel;
            vel.x = rb.velocity.x;
            vel.y = (rb.velocity.y / 2) + (collision.collider.attachedRigidbody.velocity.y / 3); //mengambil nilai velocity player
            rb.velocity = vel;
        }
    }
}
