using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    private float nextSpawnTime;

    public GameObject enemy;
    private float spawnDelay = 7f;
    // Start is called before the first frame update
    void Update()
    {
        if (ShouldSpawn())
        {
            Spawn();
        }
    }

    // Update is called once per frame
    private void Spawn()
    {
        nextSpawnTime = Time.time + spawnDelay;
        Instantiate(enemy, transform.position, transform.rotation);
    }

    private bool ShouldSpawn()
    {
        return Time.time >= nextSpawnTime;
    }
}
