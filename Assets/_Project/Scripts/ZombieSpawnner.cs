using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawnner : MonoBehaviour
{
    public ZombiePool zombiePool;
    public List<GameObject> spawnPoints = new List<GameObject>();
    private float spawnDelay = 2f;
    private float lastSpawnedTime = 0f;
    private float currentTime = 0f;

    void Update()
    {
        if (currentTime - lastSpawnedTime >= spawnDelay)
        {
            lastSpawnedTime = currentTime;
            GameObject tempZombie = zombiePool.GetZombieTypeA();
            if (tempZombie != null)
            {
                tempZombie.transform.parent = spawnPoints[Random.Range(0, spawnPoints.Count)].transform;
                tempZombie.transform.localPosition = Vector3.zero;
            }
        }
        else
        {
            currentTime += Time.deltaTime;
        }
    }
}
