using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Jump");
        }
        if (Input.GetButtonDown("Crouch"))
        {
            Debug.Log("Crouch");
        }
	}
}
