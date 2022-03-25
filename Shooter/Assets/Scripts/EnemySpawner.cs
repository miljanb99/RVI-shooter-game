using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<GameObject> spawnedEnemies;
    public GameObject enemyPrefab;
    public List<Vector3> spawnPoints;
    public int numberOfEnemies;

    public void Awake() {
        spawnedEnemies = new List<GameObject>();
    }

    public GameObject SpawnEnemy() {
        int randomIndex = Random.Range(0, spawnPoints.Count);
        
        GameObject enemyObj = Instantiate(enemyPrefab, spawnPoints[randomIndex], Quaternion.identity);
        Enemy currEnemy = enemyObj.GetComponent<Enemy>();
        currEnemy.player = GameObject.Find("Player");
        
        return enemyObj;
    }

    void Start() {
        for (int i = 0; i < numberOfEnemies; ++i) {
            spawnedEnemies.Add(SpawnEnemy());
        }
    }

    void Update() {
        
    }
}
