using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillSlider : MonoBehaviour
{
    Slider slider;
    public FloatVariable health;
    public FloatVariable maxHealth;
    public Image fillimage;

    private void OnEnable()
    {
        health.value = 100f;
    }
    private void Awake()
    {
        slider = GetComponent<Slider>();
    }

    void Start()
    {
        
    }
    void Update()
    {
        if(slider.value <= slider.minValue) { slider.enabled = false; }
        if(slider.value > slider.minValue && !slider.enabled) { slider.enabled = true; }
        float fillValue = health.value / maxHealth.value;   
        slider.value = fillValue;
        if(fillValue <= slider.maxValue / 3)
        {
            fillimage.color = Color.red;
        }
        else { fillimage.color = Color.green; }
        if (health.value <= 0)
        {
            Debug.Log("health 0");
            GameManager.instance.onGameEnd?.Invoke();
        }
    }
}
