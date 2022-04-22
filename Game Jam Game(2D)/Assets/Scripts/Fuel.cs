using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Fuel : MonoBehaviour
{
    [SerializeField]
    private float _fuel;
    [SerializeField]
    private float decreaseFuelValue = 1f;
    public float FuelValue
    {
        get
        {
            return _fuel;
        }
    }
    private float _startingFuel;
    public UnityEvent onFuelIncrease;
    private void addListenersToEvents()
    {

        GameManager.instance.onPlayerMoving.AddListener(delegate
        {
            reduceFuel();
        });
        onFuelIncrease.AddListener(delegate
        {
            increaseFuel();
        });
    }
    // Start is called before the first frame update
    void Start()
    {
        addListenersToEvents();
        _startingFuel = _fuel;
        Debug.Log(_startingFuel);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void reduceFuel()
    {
        _fuel -= decreaseFuelValue*Time.deltaTime;

        if (_fuel <= -_startingFuel)
        {
            Debug.Log("Fuel Empty");
            GameManager.instance.onGameEnd?.Invoke();
           
        }
        _fuel = Mathf.Clamp(_fuel, -84f, 84f);
    }
    public void increaseFuel()
    {
        _fuel += 20f;

       
        _fuel = Mathf.Clamp(_fuel, -84f, 84f);
    }
}
