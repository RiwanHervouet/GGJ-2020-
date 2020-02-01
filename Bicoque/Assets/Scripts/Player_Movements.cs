using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movements : MonoBehaviour
{
    public Rigidbody2D rb2d;
    Transform player;
    public float jumpForce = 10;
    public float speed = 5;
    private bool inControl = true;

    private void FixedUpdate()
    {
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
}
