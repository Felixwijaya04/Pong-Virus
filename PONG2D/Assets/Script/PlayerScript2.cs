using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript2 : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] private Rigidbody2D rb;
    private float horizontal2;


    private void Update()
    {
        horizontal2 = Input.GetAxisRaw("Horizontal2");
    }

    private void FixedUpdate()
    {
        move(movementSpeed);
    }
    void move(float movementSpeed)
    {
        rb.velocity = new Vector2(0, -horizontal2 * movementSpeed);
    }
}
