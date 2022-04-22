using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketCollision : MonoBehaviour
{
   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemies"))
        {
            Debug.Log("Enemy Destroyed");
            Destroy(collision.gameObject);

            /*onPlayerCollision?.Invoke();*/
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemies"))
        {
            Debug.Log("Enemy Destroyed");
            Destroy(collision.gameObject);

            /*onPlayerCollision?.Invoke();*/
        }
    }
}
