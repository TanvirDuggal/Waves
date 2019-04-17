using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour
{
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
       // Debug.Log("Bullet collided with wall");
       // Debug.Log(col.gameObject.tag);
        if (col.gameObject.tag == "EnemyBullet" || col.gameObject.tag == "bullet")
        {
            Destroy(col.gameObject);
        }
    }
}