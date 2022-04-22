using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketCollision : MonoBehaviour
{
  
    private spawnObject spawner;
    [SerializeField]
    PlayerCollisionWithBoss collisionWithBoss;

    private void Start()
    {
        spawner=GameObject.FindGameObjectWithTag("objectSpawner").GetComponent<spawnObject>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Boss"))
        {
            Debug.Log("Boss Destroyed");

            /*onPlayerCollision?.Invoke();*/
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemies"))
        {
            Debug.Log("Enemy Destroyed");
            ScoreManager.instance.addScore();
            spawner.spawnBuff(collision.transform.position);
            Destroy(collision.gameObject);

            /*onPlayerCollision?.Invoke();*/
        }
        if (collision.gameObject.CompareTag("Boss"))
        {
            collisionWithBoss.BossTakeDamage();
        }
    }
 
}
