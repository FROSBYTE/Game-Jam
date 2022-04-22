using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public GameObject Credits_Canvas;
    public GameObject MainMenu_Canvas;    

    private void Start()
    {
       MainMenu_Canvas.SetActive(true);
       Credits_Canvas.SetActive(false);
    }
    public void Play()
    {
       SceneManager.LoadScene(1);
    }

    public void Options()
    {

    }
    public void Credits()
    {
        MainMenu_Canvas.SetActive(false);
        Credits_Canvas.SetActive(true);
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Backbutton()
    {
        MainMenu_Canvas.SetActive(true);
        Credits_Canvas.SetActive(false);
    }
}

