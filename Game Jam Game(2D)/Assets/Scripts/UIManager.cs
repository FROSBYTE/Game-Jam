using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Image gauge;
    public static UIManager instance;
    [SerializeField]
    private Fuel fuel;


    private void Start()
    {
        Vector3 temp = new Vector3(gauge.rectTransform.rotation.eulerAngles.x, gauge.rectTransform.rotation.eulerAngles.y, -84f);
    }

    // Update is called once per frame
    void Update()
    {
        gaugeValue();
    }
    private void gaugeValue()
    {
        
        Vector3 temp = new Vector3(gauge.rectTransform.rotation.eulerAngles.x, gauge.rectTransform.rotation.eulerAngles.y, -fuel.FuelValue);

        gauge.rectTransform.rotation = Quaternion.Euler(temp);
    }
    
}
