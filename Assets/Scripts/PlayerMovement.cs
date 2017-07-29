using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float jumpForce;
    public bool isGrounded;
    Rigidbody2D playerRB;

    void Awake()
    {
        playerRB = gameObject.GetComponent<Rigidbody2D>();
    }

    void Start ()
    {
		
	}
	
	void Update () {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            // Debug
            Debug.Log("Jump");

            // Code
            playerRB.AddForce(Vector2.up * jumpForce * Time.deltaTime, ForceMode2D.Impulse);
        }
        if (Input.GetButtonDown("Crouch"))
        {
            Debug.Log("Crouch");
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            // Debug
            Debug.Log("Grounded");

            // Code
            isGrounded = true;
        }    
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            // Debug
            Debug.Log("NOT Grounded");

            // Code
            isGrounded = false;
        }
    }

}
