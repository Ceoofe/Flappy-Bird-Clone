using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move pipes left
        transform.Translate(Vector2.left * Time.deltaTime * speed);
;
        if(transform.position.x < -2.8f)
        {
            if(gameObject.CompareTag("Pipes"))
            {
                Destroy(gameObject);
            }
        }
    }
}
