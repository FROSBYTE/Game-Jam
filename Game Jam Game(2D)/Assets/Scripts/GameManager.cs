using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Action onGameStart,onGameEnd,onFuelEmpty;
    public UnityEvent onPlayerMoving,onGameWin;
    private bool _gameStarted = false;
    
    private void addListenerToUnityEvents()
    {
        onGameEnd += () => { _gameStarted = false; 
            endgame(); };
        onGameWin.AddListener(delegate
        {
            Win();
        });
    }
    private void Start()
    {
        addListenerToUnityEvents();
    }

    private void endgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }

    public bool GameStarted
    {
        get { return _gameStarted; }
    }

    private void Awake()
    {
        instance = this;
    }
    // Start
    // is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && _gameStarted == false)
        {
            onGameStart?.Invoke();
            _gameStarted = true;
        }
    }
    private void Win()
    {
        SceneManager.LoadScene(3);
    }
    

}
