using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;

    public float acceleration = 5f;
    public float sterring = 2f;
    float sterringAmount, speed, direction;

    public float health = 5.0f;

    public Text healthText;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        healthText.text = "LIFE : " + health.ToString();
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

    void OnCollisionEnter2D(Collision2D col)
    {
        //  Debug.Log("GameObject1 collided with " + col.name);
        if (col.gameObject.tag == "EnemyBullet")
        {
            Destroy(col.gameObject);
            int sceneID = SceneManager.GetActiveScene().buildIndex;
            health--;

            healthText.text = "LIFE : " + health.ToString();
        
            if (health <= 0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene("GameOverScene", LoadSceneMode.Single);
            }
        }

    }
}