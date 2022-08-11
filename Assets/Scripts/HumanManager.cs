using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanManager : MonoBehaviour
{
    [SerializeField] private int maxSpawn;
    [SerializeField] private int maxSpawnCount;
    [SerializeField] private int spawnCount;
    [SerializeField] private int spawnInterval;
    [SerializeField] private int waveCounter;
    [SerializeField] private HumanController human;
    private float timer;
    private int waveDelay;

    [SerializeField] private WaveManager waveManager;
    [SerializeField] private LifeManager lifeManager;

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
