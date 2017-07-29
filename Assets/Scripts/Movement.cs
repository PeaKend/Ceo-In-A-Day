using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public float movementSpeed;
    public float bpmSpeed;

    void Awake()
    {
        bpmSpeed = GameObject.FindGameObjectWithTag("GameController").GetComponent<BPM>().bpm;
        movementSpeed += bpmSpeed / 10.0f;
    }

    void Update () {
        transform.position = transform.position + new Vector3 (-1.0f, 0.0f, 0.0f) * movementSpeed * Time.deltaTime;
    }

}
