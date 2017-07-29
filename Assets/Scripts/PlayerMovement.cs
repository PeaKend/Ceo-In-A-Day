using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float jumpForce;
    Rigidbody2D playerRB;

    void Awake()
    {
        playerRB = gameObject.GetComponent<Rigidbody2D>();
    }

    void Start ()
    {
		
	}
	
	void Update () {
        if (Input.GetButtonDown("Jump"))
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
}
