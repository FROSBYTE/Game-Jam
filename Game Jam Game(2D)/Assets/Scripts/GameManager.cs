using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Action onGameStart;
    private bool _gameStarted = false;
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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && _gameStarted == false)
        {
            onGameStart?.Invoke();
            _gameStarted = true;
        }
    }
}
