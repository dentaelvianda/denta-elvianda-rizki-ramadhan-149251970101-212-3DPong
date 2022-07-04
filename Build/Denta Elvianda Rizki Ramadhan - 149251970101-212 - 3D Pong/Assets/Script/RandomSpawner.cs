using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    
    public float ballSpeed;
    public Transform ballLocalPoint;
    public float spawnTime, spawnDelay;


    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("SpawnABall", spawnTime, spawnDelay);
    }
    void SpawnABall()
    {
        
        int randomSpawnPoint = Random.Range(0, spawnPoints.Length);
        
        var ball = ObjectPooler.Instance.SpawnFromPool("Ball", spawnPoints[randomSpawnPoint].position, Quaternion.identity);
        ball.GetComponent<Rigidbody>().velocity = ballLocalPoint.localPosition * ballSpeed;

      
    }
    // Update is called once per frame
    void Update()
    {

    }
}
