using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Welcome : MonoBehaviour
{
    public GameObject Panel_1;
    public GameObject Panel_2;  
    void Start()
    {
        Panel_1.SetActive(true);
        Panel_2.SetActive(false);
    }
    public void Next()
    {
        Panel_1.SetActive(false);
        Panel_2.SetActive(true);
    }
    public void Done()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

}
