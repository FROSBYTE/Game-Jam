using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemiesHandler : MonoBehaviour
{

    [SerializeField]
    GameObject enemy;
    [SerializeField]
    private float spawnTimer;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

   

    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            Instantiate(enemy, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnTimer);
        }
    }
}
