using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBuffScript : MonoBehaviour
{
    public FloatVariable healthBuff;
    public FloatVariable health;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            health.value += healthBuff.value;
            Destroy(gameObject);
        }
    }
}
