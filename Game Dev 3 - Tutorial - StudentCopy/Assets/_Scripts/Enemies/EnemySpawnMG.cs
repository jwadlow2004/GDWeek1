using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnMG : MonoBehaviour
{
    // Array to store to spawnpoints
    [SerializeField] Transform[] spawnPoints;
    // To store the delay we will use between spawns
    [SerializeField] float delayBetweenSpawns;
    // Integers to store how many ships each wave 
    [SerializeField] int numberOfEnemiesSpawned;
    // To store the delay between waves
    [SerializeField] float delayBetweenWaves;
    // Reference to the enemy Prefab
    [SerializeField] GameObject enemyPrefab;
    //Array to store all the variation
    [SerializeField] EnemyData[] enemyData;
    // To set how many waves 
    [SerializeField] int wavesNumber;
    // Keep track of current wave count
    private int currentWaveCount = 0;   

    public void SpawnerLogic()
    {
        StartCoroutine(SpawnWave());
    }
    
    IEnumerator SpawnWave()
    {
        for (int i = 0; i < numberOfEnemiesSpawned; i++)
        {
            int randomInteger = Random.Range(0, spawnPoints.Length - 1);
            GameObject spawnedShip = Instantiate(enemyPrefab, spawnPoints[randomInteger]);
            spawnedShip.GetComponent<EnemyVisual>().enemyData = enemyData[currentWaveCount];
            spawnedShip.GetComponent<EnemyMovement>().enemyData = enemyData[currentWaveCount];
            spawnedShip.GetComponent<EnemyLife>().enemyData = enemyData[currentWaveCount];
            yield return new WaitForSeconds(delayBetweenSpawns);
        }
    
        currentWaveCount++;
        if (currentWaveCount > enemyData.Length - 1) 
        {
            currentWaveCount = 0;
        }
    
        yield return new WaitForSeconds(delayBetweenWaves);
        StartCoroutine(SpawnWave());
    
    
    
    }

  
    
}
