using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{   
    public Animator animator;
    public float movespeed = 5f;
    public Rigidbody2D rb;
    
    Vector2 movement;

    void Update()
    {
        //input
       movement.x =  Input.GetAxisRaw("Horizontal");
       movement.y =  Input.GetAxisRaw("Vertical");
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("speed", movement.sqrMagnitude);
    }

     void FixedUpdate() 
     {
        //more reliable function in using physics
        rb.MovePosition(rb.position + movement * movespeed * Time.fixedDeltaTime);
    }
}
