using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool Gamepaused = false;
    public GameObject pausemenuui;
    private void Start()
    {
        pausemenuui.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Gamepaused == true)
            {
                resume();
            }
            else
            {
                pause();
            }
        }
    }
    public void resume()
    {
        pausemenuui.SetActive(false);
        Time.timeScale = 1f;
        Gamepaused = false;
    }
    public void pause()
    {
        StartCoroutine("pausemenucoroutine");
    }

    IEnumerator pausemenucoroutine()
    {
        pausemenuui.SetActive(true);
        yield return new WaitForSecondsRealtime(0.5f);
        Time.timeScale = 0f;
        Gamepaused = true;

    }
    public void restartbutton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }
    public void MainMenuButton()
    {
        SceneManager.LoadScene(0);
    }
}
