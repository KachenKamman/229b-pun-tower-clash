using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;  
    void Start()
    {
        InvokeRepeating("Spawn", 2, 3);
    }
    
    void Spawn()
    {
        int spawnIdx = Random.Range(0, spawnPoints.Length);
        int enemyIdx = Random.Range(0, enemyPrefabs.Length);

        Instantiate(enemyPrefabs[enemyIdx], spawnPoints[spawnIdx].position, Quaternion.identity);
    }
}
