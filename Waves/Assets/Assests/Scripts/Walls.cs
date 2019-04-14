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
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "EnemyBullet" || col.gameObject.tag == "bullet")
        {
            Destroy(col.gameObject);
        }
    }
}