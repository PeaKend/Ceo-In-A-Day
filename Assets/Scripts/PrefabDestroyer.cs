using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabDestroyer : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
        } else
        {
            StartCoroutine(waitandDestroy(collision));
        }

    }

    IEnumerator waitandDestroy(Collider2D collision)
    {
        yield return new WaitForSeconds(3.0f);
        Destroy(collision.gameObject);
    }
}
