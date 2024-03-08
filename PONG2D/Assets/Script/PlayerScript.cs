using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] private Rigidbody2D rb;
    private float horizontal;


    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");   
    }

    private void FixedUpdate()
    {
        move(movementSpeed);
    }
    void move(float movementSpeed)
    {
        rb.velocity = new Vector2(0,-horizontal*movementSpeed);
    }
}
