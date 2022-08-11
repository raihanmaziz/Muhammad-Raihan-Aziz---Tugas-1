using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanManager : MonoBehaviour
{
    public int maxSpawn;
    public int maxSpawnCount;
    public int spawnCount;
    public int spawnInterval;
    public int waveCounter;
    public HumanController human;
    private float timer;
    private int waveDelay;

    public WaveManager waveManager;
    public LifeManager lifeManager;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            GenerateHuman();
            timer -= spawnInterval;
        }
    }

    public void GenerateHuman()
    {
        if (lifeManager.isOver)
        {
            return;
        }
        if (spawnCount >= maxSpawnCount)
        {
            waveCounter += 1;
            waveDelay = 3;
            if (waveCounter == waveDelay)
            {
                waveCounter = 0;
                spawnCount = 0;
                maxSpawnCount += maxSpawn;
            }
            return;
        }
        HumanController humanSpawn = Instantiate(human, new Vector3(Random.Range(-8, 8), 6, 2), Quaternion.identity);
        spawnCount += 1;
    }
}
