using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    bool isGround = false;
    public float jumpForce = 5;
    public KeyCode jumpKey = KeyCode.Space;
    public string groundTag = "Ground";
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(jumpKey)){
            jump();
        }
        
    }

    void jump(){
        if(!isGround) return;
        rb.velocity = new Vector2(0,jumpForce);
        isGround = false;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.transform.CompareTag(groundTag)){
            isGround = true;
        }
    }
}
