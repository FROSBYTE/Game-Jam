using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Action onGameStart,onGameEnd,onFuelEmpty;
    public UnityEvent onPlayerMoving;
    private bool _gameStarted = false;
    [SerializeField]
    GameObject enemy;
    [SerializeField]
    Transform spawnPos;
    private void addListenerToUnityEvents()
    {
        onGameEnd += () => { _gameStarted = false; };
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
    void Start()
    {
        StartCoroutine(SpawnEnemy());
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
    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            Instantiate(enemy, spawnPos.position, Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
    }

}
