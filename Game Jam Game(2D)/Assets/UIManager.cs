using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public FloatVariable health;
    [SerializeField] float damage;
    [SerializeField] Slider slider;

    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(this);
        }
        else { instance = this; }
    }

    public void TakeDamage(float damage)
    {
        health.value -= damage;
        slider.value = health.value;

    }
}
