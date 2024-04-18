using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 2f;
    BirdController birdScript;
    // Start is called before the first frame update
    void Awake()
    {
        birdScript = GameObject.Find("Red_Bird_0").GetComponent<BirdController>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(transform.position.x < -2.8f)
        {
            if(gameObject.CompareTag("Pipes"))
            {
                Destroy(gameObject);
            }
        }
        if(birdScript.isAlive == true)
        {
            // Move pipes left
            transform.Translate(Vector2.left * Time.deltaTime * speed);
        }
    }
}
