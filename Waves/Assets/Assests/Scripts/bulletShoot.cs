﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletShoot : MonoBehaviour
{

    public float speed = 4.0f;
    bool shoot = false;
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    private void FixedUpdate()
    {
     transform.position += transform.up * Time.deltaTime * speed;
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Wall")
        {
            Destroy(gameObject);
        }

    }
}