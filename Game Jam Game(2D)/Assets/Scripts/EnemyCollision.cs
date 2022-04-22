using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyCollision : MonoBehaviour
{
    //public UnityEvent onPlayerCollision;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            UIManager.instance.TakeDamage();
            Destroy(gameObject);
            
            /*onPlayerCollision?.Invoke();*/
        }
    }
}
