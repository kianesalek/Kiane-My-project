using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermodel : MonoBehaviour
{
    Rigidbody2D rb;
    bool touchingPlatform;
    float jumpVelocity = 12;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

 
    void Update()
    {
        ReadKeys();
    }

    void ReadKeys()
    {
        Vector2 vel = rb.velocity;

        if (Input.GetKey(KeyCode.V) && (touchingPlatform==true))
        {
       
            vel.y = jumpVelocity;
        }
        if (Input.GetKey("left"))
        {
            vel.x = -8;
        }
        if (Input.GetKey("right"))
        {
            vel.x = 8;
        }

        rb.velocity = vel;
        
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            touchingPlatform = true;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            touchingPlatform = false;
        }
    }


}