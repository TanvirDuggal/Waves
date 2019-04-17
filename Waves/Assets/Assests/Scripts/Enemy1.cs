using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy1 : MonoBehaviour
{
    // Start is called before the first frame update

    public float health = 3.0f;

    public float speed = 10.0f;

    public GameObject player;

    public float fireTime = 2.0f;

    public GameController gamCon;
  
    public GameObject rocketPrefab;
    public Transform barrelEnd;

    GameObject rocketInstance;

    int sceneID;

    void Start()
    {
        sceneID = SceneManager.GetActiveScene().buildIndex;
        InvokeRepeating("fire",1.0f, 2.0f);
      //  CancelInvoke("fire");
      //  InvokeRepeating("fire", 2.0f, 0.1f);
        // print(sceneID);

        InvokeRepeating("SpawnObject", 2, 1);
    }
    float timeee;
    private void fire()
    {
        rocketInstance = Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.rotation) as GameObject;
        
    }    

    float timeLeft = 0;

    public void rot()
    {
        Vector3 diff = player.transform.position - gameObject.transform.position;
        diff.Normalize();

        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);

        //Quaternion loc = transform.rotation;
       // loc = Quaternion.Inverse(loc);
          //transform.rotation = Quaternion.Lerp(loc, player.transform.rotation, Time.deltaTime * speed);
        //transform.LookAt(player.transform);
      //  gameObject.transform.LookAt(player.transform.position);
    }
    float timee;


    public static bool isEven(string s1)
    {
        int l = s1.Length;

        // char[] s = s1.toCharArray(); 

        // Loop to traverse number from LSB 
        bool dotSeen = false;
        for (int i = l - 1; i >= 0; i--)
        {

            // We ignore trailing 0s after dot 
            if (s1[i] == '0' && dotSeen == false)
                continue;

            // If it is '.' we will check next 
            // digit and it means decimal part 
            // is traversed. 
            if (s1[i] == '.')
            {
                dotSeen = true;
                continue;
            }

            // If digit is divisible by 2 
            // means even number. 
            if ((s1[i] - '0') % 2 == 0)
                return true;

            return false;
        }

        return false;
    }


    private void FixedUpdate()
    {
        rot();
        
        timee += Time.deltaTime;
        
        /*
        if (isEven(timee.ToString()))
        {
            fire();
        }
        */
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(">>>>>>>>>>>>>>>>>>>>>>>>> GameObject1 collided with " + col.gameObject.tag);
        if (col.gameObject.tag == "bullet")
        {
            Destroy(col.gameObject);

            health--;
            if (health <= 0)
            {
                Destroy(gameObject);
                // SceneManager.LoadScene(sceneID+1, LoadSceneMode.Single);
                gamCon.hitTaken();
            }
        }
        
    }
}