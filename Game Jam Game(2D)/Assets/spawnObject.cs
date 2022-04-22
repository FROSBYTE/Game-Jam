using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class spawnObject : MonoBehaviour
{
 
    
    public GameObject healthBuff,fuelBuff;
    public Transform spawnPosition;



   
    public void spawnBuff(Vector3 Position)
    {
        int index = UnityEngine.Random.Range(0, 3);
        switch(index)
        {
            case 0:
                Instantiate(healthBuff, Position, Quaternion.identity);
                break;

                case 1:
                Instantiate(fuelBuff, Position, Quaternion.identity);

                break;
            case 2:

                break;
        }
    }
}
