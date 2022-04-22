using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
/*    [SerializeField]
    Transform player;*/
    Rigidbody2D rb2d;
    private Transform player;
    private Vector3 movement;
    [SerializeField]
    float moveSpeed;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb2d.rotation = angle;
        //transform.position = direction;
        direction.Normalize();
        movement = direction;

    }
    private void FixedUpdate()
    {
        MoveTowrads(movement);
    }
    public void MoveTowrads(Vector2 direction)
    {
        rb2d.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }
}
