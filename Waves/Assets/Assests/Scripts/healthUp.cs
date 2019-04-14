using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthUp : MonoBehaviour
{
    public PlayerController pc;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "tank")
        {
            Destroy(this.gameObject);
            pc.health += 1;
            pc.healthText.text = "LIFE : " + pc.health.ToString();
        }
    }
}
