using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullets : MonoBehaviour
{
    Rigidbody2D rb;

    public float speed = 4.0f;

    public GameObject rocketPrefab;
    public Transform barrelEnd;

    GameObject rocketInstance;

    bool moveBullet = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (moveBullet)
        {
            rocketInstance = Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.rotation) as GameObject;
            moveBullet = false;
        }

        if (Input.GetMouseButton(0))
        {
            moveBullet = true;

        }
    }
}