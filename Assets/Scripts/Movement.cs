using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float movementSpeed;

	void Start () {
		
	}
	
	void Update () {
        transform.position = transform.position + new Vector3 (-1.0f, 0.0f, 0.0f) * movementSpeed * Time.deltaTime;
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Da;o");
        }
    }

}
