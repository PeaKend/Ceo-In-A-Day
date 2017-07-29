using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float jumpForce;
    public float playermovementSpeed;
    bool isGrounded;
    bool airJump;
    public bool isClamped;
    public bool lost;
    Rigidbody2D playerRB;

    void Awake()
    {
        isClamped = true;
        lost = false;
        playerRB = gameObject.GetComponent<Rigidbody2D>();
    }
	
	void Update () {
        horizontalplayerMovement();
        playerJump();
        playerCrouch();
        if (isClamped && !lost)
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -8.0f, 0.0f),
                                             Mathf.Clamp(transform.position.y, -4.0f, 4.0f),
                                             0.0f);
        }
        }

    // Methods

        // Jump
    void playerJump()
    {
        if (Input.GetButtonDown("Jump") && (isGrounded || airJump))
        {
            // Air jump bool
            if (!isGrounded)
            {
                airJump = false;
            }

            // Jump method
            playerRB.AddForce(Vector2.up * jumpForce * Time.deltaTime, ForceMode2D.Impulse);
        }
    }
        // Crouch 
    void playerCrouch()
    {
        if (Input.GetButton("Crouch"))
        {
            // Debug
            transform.localScale = new Vector3(1.0f, 0.5f);

            // Code TODO
        }
        else
        {
            transform.localScale = new Vector3(1.0f, 1.0f);
        }
    }
        // Go to position in X
    void horizontalplayerMovement()
    {
        transform.position = transform.position + new Vector3(1.0f * Input.GetAxisRaw("Horizontal"), 
                                                              0.0f, 
                                                              0.0f)
                                                              * playermovementSpeed * 5.0f * Time.deltaTime;
    }

    // Events

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
            airJump = true;
        }    
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }

}
