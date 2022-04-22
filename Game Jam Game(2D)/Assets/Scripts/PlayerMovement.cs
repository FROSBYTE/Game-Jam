using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    [SerializeField]
    private float _speed;
    private float _direction;
    [SerializeField]
    private float _rotationSenitivity;
    private void addListenersToEvents()
    {
        GameManager.instance.onGameStart += startMovement;
         
    }
    private void startMovement()
    {
        _rigidbody.isKinematic = false;
    }
    private void OnDisable()
    {
        GameManager.instance.onGameStart -= startMovement;
    }
    private void initialiseValues()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _rigidbody.isKinematic = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        initialiseValues();
       addListenersToEvents();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.instance.GameStarted==true)
        {
            movement();
            applyRotation();
        }
    }
    
    private void movement()
    {
        if (Input.GetMouseButton(0))
        {

            _rigidbody.AddForce(transform.up * _speed, ForceMode2D.Impulse);
        }
        if (Input.GetMouseButtonDown(0))
        {
            _rigidbody.velocity = Vector2.zero;
        }
    }
    private void applyRotation()
    {
        _direction = Input.GetAxisRaw("Horizontal");
        
        float angle = _direction * _rotationSenitivity;
        Vector3 temp = new Vector3(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
        temp-=Vector3.forward * angle;
        transform.rotation = Quaternion.Euler(temp);
    }
}
