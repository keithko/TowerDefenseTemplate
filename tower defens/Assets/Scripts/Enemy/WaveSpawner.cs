using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public Transform EnemyPrefab;
    public Transform SpawnLocation;

    public float TimerWaves = 10f;
    private float countdown = 2f;

    private int WaveNumber = 0;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (countdown <= 0)
        {
           StartCoroutine(SpawnWave());
            countdown = TimerWaves;
        }

        countdown -= Time.deltaTime;
    }
    
    IEnumerator SpawnWave()
    {
        WaveNumber++;

        for (int i = 0;i < WaveNumber; i++)
        {
            spawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }
        Debug.Log("enemy is spawnd");
    }

    void spawnEnemy ()
    {
        Transform enemyGo = Instantiate(EnemyPrefab, SpawnLocation.position, SpawnLocation.rotation); // Spawnen de enemy en slaan deze op in de "enemyGO" variable.
        Enemy enemy = enemyGo.GetComponent<Enemy>(); // We halen het Enemy script van de net gespawnde enemy.

        ScoreManger scoreManager = FindObjectOfType<ScoreManger>(); // Haal het enige ScoreManager script in de scene op.

    }
}
