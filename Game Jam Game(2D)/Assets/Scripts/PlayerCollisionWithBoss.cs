using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionWithBoss : MonoBehaviour
{
    public FloatVariable bossHealth;
    public FloatVariable health;
    [SerializeField]
    float bossDamage;
    [SerializeField]
    float healthDamage;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerTakeDamage();
        }
    }
    public void BossTakeDamage()
    {
        bossHealth.value -= bossDamage;
        Debug.Log("boss damaged");
    }
    public void PlayerTakeDamage()
    {
        health.value -= healthDamage;
    }
}
