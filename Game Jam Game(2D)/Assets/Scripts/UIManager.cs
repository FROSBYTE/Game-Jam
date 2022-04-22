using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Image gauge;
    public static UIManager instance;
    [SerializeField]
    private Fuel fuel;
    public FloatVariable health;
    [SerializeField] float damage;
    [SerializeField] Slider slider;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] ScoreManager scoreManager;
    private void OnEnable()
    {
        health.value = 100f;
    }

    private void Awake()
    {
        if(instance!= null && instance != this)
        {
            Destroy(this);
        }
        else { instance = this; }
    }
    private void Start()
    {
        Vector3 temp = new Vector3(gauge.rectTransform.rotation.eulerAngles.x, gauge.rectTransform.rotation.eulerAngles.y, -84f);
    }

    // Update is called once per frame
    void Update()
    {

        gaugeValue();
        scoreText.text = scoreManager.Score.ToString();
    }
    private void gaugeValue()
    {
        
        Vector3 temp = new Vector3(gauge.rectTransform.rotation.eulerAngles.x, gauge.rectTransform.rotation.eulerAngles.y, -fuel.FuelValue);

        gauge.rectTransform.rotation = Quaternion.Euler(temp);
    }
    public void TakeDamage()
    {
        health.value -= damage;

    }

}
