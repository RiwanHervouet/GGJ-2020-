using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movements : MonoBehaviour
{
    public Rigidbody2D rb2d;
    Transform player;
    public float jumpForce = 10;
    public float speed = 5;
    public float distanceDetection = 1;
    public bool playerIsOnGround = true;
    private bool inControl = true;

    private void FixedUpdate()
    {
        /*RaycastHit2D hit = Physics2D.Raycast(player.position, Vector2.down, distanceDetection, LayerMask.GetMask("Ground"));

        if (hit)
        {
            playerIsOnGround = true;
        }
        else
        {
            playerIsOnGround = false;
        }*/

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.velocity = new Vector2(-speed , rb2d.velocity.y);
            inControl = true;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.velocity = new Vector2(speed , rb2d.velocity.y);
            inControl = true;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpForce);
            inControl = true;
        }

        if (!inControl)
        {
            rb2d.velocity = new Vector2(0, transform.position.y);
        }
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Item"))
        {
            Destroy(collider.gameObject);
        }
    }
}
