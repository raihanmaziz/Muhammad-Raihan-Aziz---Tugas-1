using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieManager : MonoBehaviour
{
    public int maxSpawn;
    public int maxSpawnCount;
    public int spawnCount;
    public int spawnInterval;
    public int waveCounter;
    public ZombieController zombie;
    public ZombieCrazyController zombieCrazy;
    private float timer;

    public WaveManager waveManager;
    public LifeManager lifeManager;
    public ScoreManager scoreManager;
    
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        maxSpawnCount = maxSpawn * waveManager.wave;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            GenerateZombie();
            timer -= spawnInterval;
        }
    }

    public void GenerateZombie()
    {
        if (lifeManager.isOver)
        {
            return;
        }
        if (spawnCount >= maxSpawnCount)
        {
            waveCounter += 1;
            if (waveCounter == 6)
            {
                waveManager.AddWave();
                waveCounter = 0;
                spawnCount = 0;
                maxSpawnCount = maxSpawn * waveManager.wave;
            }
            return;
        }
        if ((spawnCount % 3) == 2)
        {
            ZombieCrazyController zombieCrazySpawn = Instantiate(zombieCrazy, new Vector3(Random.Range(-8, 8), 6, 1), Quaternion.identity);
        }
        else
        {
            ZombieController zombieSpawn = Instantiate(zombie, new Vector3(Random.Range(-8, 8), 6, 1), Quaternion.identity);
        }
        spawnCount += 1;
    }
}
