using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyHealthSlider : MonoBehaviour
{
    Slider slider;
    public FloatVariable bossHealth;
    public FloatVariable bossMaxHealth;
    public Image fillimage;

    private void OnEnable()
    {
        bossHealth.value = 500f;
    }

    private void Awake()
    {
        slider = GetComponent<Slider>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value <= slider.minValue) { slider.enabled = false; }
        if (slider.value > slider.minValue && !slider.enabled) { slider.enabled = true; }
        float fillValue = bossHealth.value / bossMaxHealth.value;
        slider.value = fillValue;
        //if (fillValue <= slider.maxValue / 3)
        //{
        //    fillimage.color = Color.red;
        //}
        //else { fillimage.color = Color.green; }
        //if (bossHealth.value <= 0)
        //{
        //    Debug.Log("GameWin");
        //    GameManager.instance.onGameEnd?.Invoke();
        //}
        if(bossHealth.value <= 0)
        {
            SceneManager.LoadScene("EndScene");
        }
    }
}
