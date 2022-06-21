using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float playerSpeed = 8f;
    Vector2 move;
    Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
      //  rb.velocity = move * playerSpeed * Time.deltaTime;
      rb.MovePosition(rb.position + (move * playerSpeed * Time.deltaTime));

    }
    void Update()
    {
        
        move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }
}
