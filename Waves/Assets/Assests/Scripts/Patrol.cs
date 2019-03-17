using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    // Start is called before the first frame update
    //comment to test the commit . 

    public float speed ;
    private float  waitTime;
    private float startWaitTime;
    public Transform  moveSpot;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    public  float rotationSpeed;

    void Start()
    {
        speed = 1 ;
        rotationSpeed = 10;
        startWaitTime = 2;
        waitTime = startWaitTime ;
      
moveSpot.position = new Vector2(Random.Range(minX,maxX),Random.Range(minY,maxY)) ;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vector   = Vector2.MoveTowards(transform.position,moveSpot.position,speed * Time.deltaTime);
        transform.position = vector;
        
        
       // Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(vector.y, vector.x) * Mathf.Rad2Deg;

      


        if(Vector2.Distance(transform.position , moveSpot.position)< 0.2f){
            if(waitTime <= 0 ){
             moveSpot.position = new Vector2(Random.Range(minX,maxX),Random.Range(minY,maxY)) ;
                waitTime = startWaitTime;
        } else {
            waitTime -= Time.deltaTime;
              Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
        }
    }
    }}
