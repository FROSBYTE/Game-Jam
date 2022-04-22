using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelBuff : MonoBehaviour
{
    
    private Fuel _fuel;
   
    private void OnEnable()
    {
        _fuel =GameObject.FindGameObjectWithTag("guage").GetComponent<Fuel>();
    }

  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            _fuel.increaseFuel();
            Destroy(gameObject);
        }
    }
}
