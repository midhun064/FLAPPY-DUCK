using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    private float timeBtwSpawn;
    private Vector3 SpawnPos;
    float yPos;
    
    void Start()
    {

    }

    void Update()
    {
        yPos = Random.Range(-3.32f, 2.17f);
        SpawnPos = new Vector3(transform.position.x, yPos, transform.position.z);
        if (timeBtwSpawn <= 0)
        {
            Instantiate(pipe, SpawnPos, transform.rotation);
            timeBtwSpawn = 1.5f;
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
