using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {

    // Add force When Character hit platform 

    public float jumpForce = 10f;

     void OnCollisionEnter2D (Collision2D collision) {

         if (collision.relativeVelocity.y <= 0f) {  // Check where is collision come form between below or above

             Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();

             if (rb != null)
             {

                 Vector2 velocity = rb.velocity;
                 velocity.y = jumpForce;
                 rb.velocity = velocity;

             }
         
         }
    
        
  
    }

}
