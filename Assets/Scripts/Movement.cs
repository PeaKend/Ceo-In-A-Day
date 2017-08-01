using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public float movementSpeed;
    public float bpmSpeed;

    void Awake()
    {
        bpmSpeed = GameObject.FindGameObjectWithTag("GameController").GetComponent<BPM>().bpm;
        if (gameObject.tag != "Floor")
        {
            movementSpeed += bpmSpeed / 10.0f;
        }
    }

    void Update () {
        transform.position = transform.position + new Vector3 (-1.0f, 0.0f, 0.0f) * movementSpeed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && gameObject.tag != "Floor")
        {
            collision.gameObject.GetComponent<PlayerMovement>().isClamped = false;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && gameObject.tag != "Floor")
        {
            collision.gameObject.GetComponent<PlayerMovement>().isClamped = true;
        }
    }
}
