using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] GameObject enemy;
    [SerializeField] Transform spawnPos;

    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(this);
        }
        else instance = this;
    }
    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }
    private void Update()
    {
        
    }


    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            Instantiate(enemy, spawnPos.position, Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
    }
}
