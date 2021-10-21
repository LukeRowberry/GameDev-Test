using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public float movementSpeed;
    public float jumpForce;
    public Rigidbody2D rig;
    public SpriteRenderer spRender;

    void FixedUpdate()
    {
        float xInput = Input.GetAxis("Horizontal");
        rig.velocity = new Vector2(xInput * movementSpeed, rig.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (rig.velocity.x > 0)
        {
            //Moving Right
            spRender.flipX = true;
        }
        else if (rig.velocity.x < 0)
        {
            //Moving Left
            spRender.flipX = false;
        }

        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && IsGrounded())
        {
            rig.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    bool IsGrounded()
    { 
        RaycastHit2D hit = Physics2D.Raycast(transform.position + new Vector3(0,-0.1f,0),Vector2.down,0.2f);
        return hit.collider != null;
    }
}
