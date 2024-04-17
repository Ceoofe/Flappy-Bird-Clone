using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject pipePrefab;
    BirdController birdScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipes", 2f, 1.5f);
        birdScript = GameObject.Find("Red_Bird_0").GetComponent<BirdController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(birdScript.isAlive == false)
        {
            CancelInvoke();
        }
    }

    void SpawnPipes()
    {
        Instantiate(pipePrefab, new Vector2(6f, Random.Range(-1.35f, 0.66f)), Quaternion.identity);
    }
}
