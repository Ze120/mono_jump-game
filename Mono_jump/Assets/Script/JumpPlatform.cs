using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlatform : MonoBehaviour {

    public GameObject pickupEffect;

    public float jumpForce = 30f;

    void OnTriggerEnter2D (Collider2D other) {

        if (other.CompareTag("Player"))
        {
            Pickup(other);
        }
    }

    void Pickup(Collider2D player){
    
        // spawn cool effect
        Instantiate(pickupEffect, transform.position, transform.rotation);

        //Apply effect to player
        Rigidbody2D rb = player.GetComponent<Rigidbody2D>();

        if (rb != null)
        {

            Vector2 velocity = rb.velocity;
            velocity.y = jumpForce;
            rb.velocity = velocity;

        }

        Destroy(gameObject);
    }
    
}
