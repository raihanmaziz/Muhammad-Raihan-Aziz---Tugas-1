using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieManager : MonoBehaviour
{
    [SerializeField] private int maxSpawn;
    [SerializeField] private int maxSpawnCount;
    [SerializeField] private int spawnCount;
    [SerializeField] private int spawnInterval;
    [SerializeField] private int waveCounter;
    [SerializeField] private ZombieController zombie;
    [SerializeField] private ZombieCrazyController zombieCrazy;
    private float timer;

    [SerializeField] private WaveManager waveManager;
    [SerializeField] private LifeManager lifeManager;
    [SerializeField] private ScoreManager scoreManager;
    
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
            zombieCrazySpawn.SetManager(scoreManager);
        }
        else
        {
            ZombieController zombieSpawn = Instantiate(zombie, new Vector3(Random.Range(-8, 8), 6, 1), Quaternion.identity);
            zombieSpawn.SetManager(scoreManager);
        }
        spawnCount += 1;
    }
}
