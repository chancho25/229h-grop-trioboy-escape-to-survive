using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   public float speed = 3;
  public float jump = 10;
   
   private Rigidbody2D rb2D;
    void Start()
    {
        rb2D = GetComponent< Rigidbody2D >();
    }//Start

    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        rb2D.velocity = new Vector2 ( move * speed, rb2D.velocity.y );

          if ( Input.GetKeyDown(KeyCode.Space) )
        {
            rb2D.AddForce( new Vector2( 0 , jump ) ,ForceMode2D.Impulse );
        }
    }//Update
}
