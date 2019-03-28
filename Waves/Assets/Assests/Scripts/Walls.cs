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
    //    Debug.Log("GameObject1 collided with " + col.name);
        Destroy(col.gameObject);
    }
}