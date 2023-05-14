using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlePlayerInputs
{
    public void controlPlayerMovements(Rigidbody2D rb){
        float dirX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(dirX * 7f, rb.velocity.y);

        if(Input.GetKeyDown("space")    ){
            rb.velocity = new Vector2(rb.velocity.x, 7);
        }
    }
}
