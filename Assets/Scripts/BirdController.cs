using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdController : MonoBehaviour
{
    Rigidbody2D Rigidbody2d;
    int score = 0;
    public Text scoreUI;
    public bool isAlive;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2d = GetComponent<Rigidbody2D>();
        // Set the alive to true
        isAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            Rigidbody2d.AddForce(Vector2.up * 250);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Points"))
        {
            // Increase score by 1
            score = score + 1;

            scoreUI.text = score.ToString();
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        // Set alive to false on Collision
        isAlive = false;
        Time.timeScale = 0f;
    }
}
