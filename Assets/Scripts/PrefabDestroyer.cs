using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabDestroyer : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Destroy");
        Destroy(collision.gameObject);
    }
}
