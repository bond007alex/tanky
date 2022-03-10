using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject[] vehiclePrefabs;
    public GameObject[] obstaclePrefabs;
    public GameObject roadlines;
    private int spawnRangeX = 23;
    private int spawnPosZ = 269;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomVehicle", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomObstacle", startDelay, spawnInterval);
        InvokeRepeating("SpawnRoadlines", 0, .5f);

    }

    // Update is called once per frame
    void Update(){
    }
    void SpawnRandomVehicle ()
    {
        int vehicleIndex = Random.Range(0, vehiclePrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0f, spawnPosZ);
        Instantiate(vehiclePrefabs[vehicleIndex], spawnPos, vehiclePrefabs[vehicleIndex].transform.rotation);
    }
    void SpawnRandomObstacle()
    {
        int obstacleIndex = Random.Range(0, obstaclePrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0f, spawnPosZ);
        Instantiate(obstaclePrefabs[obstacleIndex], spawnPos, obstaclePrefabs[obstacleIndex].transform.rotation);
    }
    void SpawnRoadlines()
    {
        Vector3 spawnPos1 = new Vector3(6, 0.1f, spawnPosZ);
        Vector3 spawnPos2 = new Vector3(18, 0.1f, spawnPosZ);
        Vector3 spawnPos3 = new Vector3(-6, 0.1f, spawnPosZ);
        Vector3 spawnPos4 = new Vector3(-18, 0.1f, spawnPosZ);
        Instantiate(roadlines, spawnPos1, roadlines.transform.rotation);
        Instantiate(roadlines, spawnPos2, roadlines.transform.rotation);
        Instantiate(roadlines, spawnPos3, roadlines.transform.rotation);
        Instantiate(roadlines, spawnPos4, roadlines.transform.rotation);
    }
}
