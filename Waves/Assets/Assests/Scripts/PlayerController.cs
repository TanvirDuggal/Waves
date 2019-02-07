using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;

    public float acceleration = 5f;
    public float sterring = 2f;
    float sterringAmount, speed, direction;
  
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        sterringAmount = - Input.GetAxis("Horizontal");
        speed = Input.GetAxis("Vertical") * acceleration;
        direction = Mathf.Sign(Vector2.Dot(rb.velocity, rb.GetRelativeVector(Vector2.up)));
        rb.rotation += sterringAmount * sterring * rb.velocity.magnitude * direction;
        rb.AddRelativeForce(Vector2.up * speed);
        rb.AddRelativeForce(-Vector2.right * rb.velocity.magnitude * sterringAmount / 2);

    }
}